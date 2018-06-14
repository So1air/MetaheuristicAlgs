using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    /// <summary>
    /// Прототип алгоритма роя частиц для случая произвольного заданного прямоугольного гиперпаралелепипеда из 
    /// многомерного непрерывного пространства действительных чисел
    /// </summary>
    public class Prototype_PSO
    {
        private static string[] namesOfTopologys = { "star", "random", "circle" };

        #region data 
        int iteration = 0, 
            maxIteration; 
        Func<double[], double> f;
        Func<bool> continueCondition;       
        Random rand = new Random();
        int s = 10, 
            d = 2, 
            gbest, 
            improvement, 
            threshold, 
            K = 0;
        double previous;
        bool relink = true;        
        double[][] x, 
                   v, 
                   p;
        double[] fitness, 
                 fp;
        double[] xmin, 
                 xmax; 
        double w = 0.72, 
               c1 = 1.19, 
               c2 = 1.19;
        byte topology = 0;
        Action tweak;
        bool[][] L;
        #endregion

        /// <summary>
        /// Индексатор для безопасного просмотра состояния роя на текущей итерации
        /// </summary>
        /// <param name="prop">название свойства</param>
        /// <param name="numParticle">номер частицы</param>
        /// <param name="numComponent">номер компоненты частицы</param>
        /// <returns>значение соотвествующего свойства указанной компоненты указанной частицы</returns>
        public double this[string prop, int numParticle, int numComponent]
        {
            get 
            {
                switch (prop)
                {
                    case "x":
                        return x[numParticle][numComponent];
                    case "v":
                        return v[numParticle][numComponent];
                    case "p":
                        return p[numParticle][numComponent];
                    case "fitness":
                        return fitness[numParticle];
                    case "fp":
                        return fp[numParticle];
                    default:
                        throw new ArgumentOutOfRangeException("prop");
                }
            }
        }

        /// <summary>
        /// Возвращает копию двух массивов ограничений задачи оптимизации в виде зубчатого массива, 
        /// первый подмассив которого представляет нижние границы значений компонент вещественных 
        /// векторов, а второй - верхние 
        /// </summary>
        public double[][] GetRanges
        {
            get
            {
                double[][] res = new double[2][] { new double[d], new double[d] };
                xmin.CopyTo(res[0], 0);
                xmax.CopyTo(res[1], 0);
                return res;
            }
        }

        /// <summary>
        /// Возвращает размерность пространства
        /// </summary>
        public int Dimension
        {
            get { return d; }
        }

        /// <summary>
        /// Возвращает количество частиц в рое
        /// </summary>
        public int SizeSwarm
        {
            get { return s; }
        }

        /// <summary>
        /// Вовращает фитнесс-функцию
        /// </summary>
        public Func<double[], double> F
        {
            get { return f; }
        }

        /// <summary>
        /// Возвращает номер текущей итерации
        /// </summary>
        public int Iteration
        {
            get { return iteration; }
        }

        /// <summary>
        /// Возвращает и задает максимальное количество итераций, которым ограничено выполнение алгоритма
        /// </summary>
        public int MaxIteration
        {
            get { return maxIteration; }
            set 
            {
                if (value >= iteration)
                    maxIteration = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает условие продолжения выполнения алгоритма
        /// </summary>
        public Func<bool> ContinueCondition
        {
            get { return continueCondition; }
            set 
            { 
                if (value != null)
                    continueCondition = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент инерции частицы
        /// </summary>
        public double Inertia
        {            
            get { return w; }
            set
            {
                if ((0 < value) && (value <= 1))
                    w = value;
            }
        }       

        /// <summary>
        /// Возвращает и задает коэффициент влияния личного опыта частицы
        /// </summary>
        public double Personal
        {
            get { return c1; }
            set
            {
                if ((1 < value) && (value <= 2))
                    c1 = value;
            }
        }   
    
        /// <summary>
        /// Возвращает и задает коэффициент влияния опыта соседей частицы
        /// </summary>
        public double Global
        {
            get { return c2; }
            set 
            {   
                if ((1 < value) && (value <= 2))
                    c2 = value; 
            }
        }

        /// <summary>
        /// Возвращает текущее лучшее решение, найденное алгоритмом в результате выполнения всех предыдущих итерации в текущем (пере)запуске алгоритма
        /// </summary>
        public double[] Solution
        {
            get 
            { 
                double[] res = new double[d];
                p[gbest].CopyTo(res, 0);
                return res;
            }
        }

        /// <summary>
        /// Возвращает наилучшее значение фитнесс-функции, соответсвующее текущему лучшему решению 
        /// </summary>
        public double FitnessSolution
        {
            get { return fp[gbest]; }
        }

        /// <summary>
        /// Возвращает и задает текущую используемую топологию
        /// </summary>
        public string Topology
        {
            get { return namesOfTopologys[topology]; }
            set
            {
                int ind = 0;
                for (; (ind < namesOfTopologys.Length) && (namesOfTopologys[ind] != value); ind++) 
                    ;
                switch (ind)
                {
                    case 0:
                        topology = 0;
                        tweak = UpdateStar;
                        break;
                    case 1:
                        topology = 1;
                        tweak = UpdateRandom;
                        L = new bool[SizeSwarm][];
                        break;
                    case 2:
                        topology = 2;
                        tweak = UpdateCircle;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает максимальное количество информаторов, которое может быть у частицы 
        /// при использовании случайной топологии     
        /// </summary>
        public int MaxCountInformants
        {
            get { return K; }
            set
            {
                if ((0 <= value) && (value < SizeSwarm)) 
                    K = value;
            }
        }

        /// <summary>
        /// Безусловное выполнение итерации алгоритма PSO
        /// </summary>
        private void NextIteration()
        {
            // Обновление скоростей и положений частиц 
            tweak();

            // Обновление текущего лучшего решения частицы 
            for (int i = 0; i < s; i++)
            {
                fitness[i] = f(x[i]);
                if (fitness[i] < fp[i])
                {
                    fp[i] = fitness[i];
                    for (int j = 0; j < d; j++)
                        p[i][j] = x[i][j];
                }
            }

            // Обновление номера лучшей частицы роя 
            for (int i = 0; i < s; i++)
                if (fp[i] < fp[gbest])
                    gbest = i;
            ++iteration;

            // Проверка факта улучшения решения роя 
            if (fp[gbest] < previous)
            {
                improvement++; 
                relink = false;
            }
            else 
                relink = true;
            // Обновить связи, если они не обновлялись долгое время 
            if (improvement >= threshold) 
                relink = true; 
        }

        /// <summary>
        /// Обновление скоростей и положений частиц (топология «звезда»)
        /// </summary>
        private void UpdateStar()
        {
            for (int i = 1; i < s; i++)
                for (int j = 0; j < d; j++)
                {
                    v[i][j] = w * v[i][j] + c1 * rand.NextDouble() * (p[i][j] - x[i][j]);
                    if (i != gbest)
                        v[i][j] += c2 * rand.NextDouble() * (p[gbest][j] - x[i][j]);

                    x[i][j] = x[i][j] + v[i][j];
                    // Проверка выхода за границы пространства поиска 
                    if (x[i][j] < xmin[j])
                    {
                        x[i][j] = xmin[j];
                        v[i][j] = 0;
                    }

                    if (x[i][j] > xmax[j])
                    {
                        x[i][j] = xmax[j];
                        v[i][j] = 0;
                    }
                }
        }

        /// <summary>
        /// Обновление скоростей и положений частиц (случайная топология)
        /// </summary>
        private void UpdateRandom()
        {
            int lbest;
            double fmin;
            previous = fp[gbest];
            // Обновление связей между частицами роя 
            if (relink)
            {
                int i = 0;
                for (; i < s; i++)
                {
                    L[i] = new bool[s];
                    L[i][i] = true;
                }
                        
                for (int j = 0; j < s; j++)
                    for (int k = 0; k < MaxCountInformants; k++)
                    {
                        i = rand.Next(s - 1);
                        L[j][i] = true;
                    }

                improvement = 0;
            }
            // Обновление состояния роя 
            for (int i = 0; i < s; i++)
            {
                lbest = i;
                fmin = fp[i];
                // Поиск лучшего соседа 
                for (int neighbor = 0; neighbor < s; neighbor++)
                    if (L[i][neighbor])
                        if (fp[neighbor] < fmin)
                        {
                            fmin = fp[neighbor];
                            lbest = neighbor;
                        }

                // Обновление скоростей и положений частиц 
                for (int j = 0; j < d; j++)
                {
                    v[i][j] = w * v[i][j] + c1 * rand.NextDouble() * (p[i][j] - x[i][j]);
                    if (i != lbest)
                    {
                        v[i][j] += c2 * rand.NextDouble() * (p[lbest][j] - x[i][j]);
                    }
                    x[i][j] += v[i][j];
                    // Проверка выхода за границы пространства поиска 
                    if (x[i][j] < xmin[j])
                    {
                        x[i][j] = xmin[j];
                        v[i][j] = 0;
                    }

                    if (x[i][j] > xmax[j])
                    {
                        x[i][j] = xmax[j];
                        v[i][j] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Обновление скоростей и положений частиц (топология «кольцо»)
        /// </summary>
        private void UpdateCircle()
        {            
            double fmin;
            int neighbor1, neighbor2, lbest;

            for (int i = 0; i < s; i++)
            {
                lbest = i;
                fmin = fp[i];
                neighbor1 = i - 1;
                neighbor2 = i + 1;
                if (i == 0)
                    neighbor1 = s;
                if (i == s - 1)
                    neighbor2 = 1;
                if (fp[neighbor1] < fmin)
                {
                    fmin = fp[neighbor1];
                    lbest = neighbor1;
                }
                if (fp[neighbor2] < fmin)
                    lbest = neighbor2;
                for (int j = 0; j < d; j++)
                {
                    v[i][j] = w * v[i][j] + c1 * rand.NextDouble() * (p[i][j] - x[i][j]);
                    if (i != lbest)
                    {
                        v[i][j] += c2 * rand.NextDouble() * (p[lbest][j] - x[i][j]);
                    }
                    x[i][j] += v[i][j];
                    // Проверка выхода за границы пространства поиска 
                    if (x[i][j] < xmin[j])
                    {
                        x[i][j] = xmin[j];
                        v[i][j] = 0;
                    }

                    if (x[i][j] > xmax[j])
                    {
                        x[i][j] = xmax[j];
                        v[i][j] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Метод для пошагового выполнения алгоритма
        /// </summary>
        /// <returns>была ли осуществлена итерация или её выполнение было отменено</returns>
        public bool RunNextIteration()
        {
            if (continueCondition())
            {
                NextIteration();
                return true;
            }
            else return false;
        }
        
        /// <summary>
        /// Выполнение алгоритма до тех пор, пока выполняется заданное условие продолжения
        /// </summary>
        public void RunToEnd()
        {
            // Обновление состояния роя 
            do
            {
                NextIteration();
            } while (continueCondition()); 
        }

        /// <summary>
        /// Метод, позволяющий заново запускать алгоритм
        /// </summary>
        private void InitSwarm()
        {
            x = new double[s][];
            v = new double[s][];
            p = new double[s][];
            fitness = new double[s];
            fp = new double[s];
            for (int i = 0; i < s; i++)
            {
                x[i] = new double[d];
                v[i] = new double[d];
                p[i] = new double[d];
                for (int j = 0; j < d; j++)
                {
                    x[i][j] = rand.NextDouble() * (xmax[j] - xmin[j]) + xmin[j];
                    v[i][j] = (rand.NextDouble() * (xmax[j] - xmin[j]) + xmin[j] - x[i][j]) / 2;
                    p[i][j] = x[i][j];
                }
                fitness[i] = f(x[i]);
                fp[i] = fitness[i];
            }
            // Поиск номера лучшей частицы в рое 
            gbest = 0; 
            for (int i = 1; i < s; i++)  
                if (fp[i] < fp[gbest]) gbest = i;
        }       

        public Prototype_PSO(Func<double[], double> fitnessFunc, double[] lowBounds, double[] highBounds, int sizeSwarm, int dimension, double inertia, double personal, double global, byte topology = 0, double CK = 0.5)
        {
            MaxIteration = 100;  //всегда ограничивает выполнение алгоритма
            //определение условия остановки по умолчанию
            continueCondition = () =>
            {
                return (iteration < MaxIteration); 
            };

            if (fitnessFunc == null)
                throw new ArgumentNullException("fitnessFunc");
            f = fitnessFunc;
            if (lowBounds == null)
                throw new ArgumentNullException("lowBounds"); 
            if (highBounds == null)
                throw new ArgumentNullException("highBounds");
            if ((lowBounds.Length != dimension) && (highBounds.Length != dimension))
                throw new ArgumentOutOfRangeException("dimension");
            //проверка на корректность простых ограничений
            for (int i = 0; i < 0; i++)
                if (lowBounds[i] > highBounds[i])
                    throw new ArgumentException("lowBounds");
            xmin = new double[dimension];
            //делаем копию переданных данных для ограничения доступа и защиты данных
            lowBounds.CopyTo(xmin, 0);
            xmax = new double[dimension];
            //делаем копию переданных данных для ограничения доступа и защиты данных
            highBounds.CopyTo(xmax, 0);

            // Инициализация роя (задание s, d, w, c1, c2 и других переменных)
            if (sizeSwarm < 2)
                throw new ArgumentOutOfRangeException("sizeSwarm");
            s = sizeSwarm;
            d = dimension;
            Inertia = inertia;
            Personal = personal;
            Global = global;
            InitSwarm();
            switch (topology)
            {   
                case 0:                  
                    Topology = namesOfTopologys[0];
                    break;
                case 1:
                    Topology = namesOfTopologys[1];
                    MaxCountInformants = (0 <= CK && (CK < 1)) ? (int)(CK * SizeSwarm) : (int)(0.5 * SizeSwarm); 
                    break;
                case 2:
                    Topology = namesOfTopologys[2];
                    break;
                default:
                    throw new ArgumentOutOfRangeException("topology");
            }
        }
    }
}

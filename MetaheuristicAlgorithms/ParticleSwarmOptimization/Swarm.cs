﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    /// <summary>
    /// Класс, пов'язаний з алгоритмом оптимізації методом рою частинок 
    /// </summary>
    /// <typeparam name="T">тип елементів простору, у якому вирішується оптимізаційна задача та від яких залежить цільова функція</typeparam>
    class Swarm<T>
    {
        //идея о вложенном классе

        //class Particle<T>
        //{
        //    Swarm<T> mySwarm; //наличие доп. ссылки в качестве поля -- однозначный "-", но достаточно ли плох, чтобы перекрыть "++"
        //    T _currPosition;
        //    double _valueFitness;
        //    T _currSpeed;
        //    T _personalBest;
        //    double _fitnessBest;
        //    List<Particle<T>> _informants = new List<Particle<T>>();
        //    Particle<T> _informantBest;

        //    public T CurrPosition
        //    {
        //        get { return _currPosition; }
        //        set { 
        //            _currPosition = value;
        //            _valueFitness = mySwarm._fitness(_currPosition);
        //        }
        //    }

        //    public double ValueFitness
        //    {
        //        get { return _valueFitness; }
        //        set { _valueFitness = value; }
        //    }

        //    public T CurrSpeed
        //    {
        //        get { return _currSpeed; }
        //        set { _currSpeed = value; }
        //    }

        //    public T PersonalBest
        //    {
        //        get { return _personalBest; }
        //        set { _personalBest = value; }
        //    }

        //    public Particle<T> this[int index]
        //    {
        //        get { return _informants[index]; }
        //        //set
        //        //{
        //        //    if ((value != this) && (!_informants.Contains(value)))
        //        //        _informants[index] = value;
        //        //}
        //    }

        //    public int CountInformants
        //    {
        //        get { return _informants.Count; }
        //    }

        //    public Particle<T> InformantBest
        //    {
        //        get { return _informantBest; }
        //        set
        //        {
        //            if (_informants.Contains(value))
        //                _informantBest = value;
        //        }
        //    }

        //    public double FitnessBest
        //    {
        //        get { return _fitnessBest; }
        //        set
        //        {
        //            /*if (_fitnessBest < value)
        //            {
        //                ChangePersonalBest(this);*/
        //            _fitnessBest = value;
        //            /*}*/
        //        }
        //    }

        //    public void DeleteInformants()
        //    {
        //        _informants.Clear();
        //        //потрібно скинути всі посилання на методи у події
        //        //ChangePersonalBest.
        //    }

        //    public bool AddInformant(Particle<T> newInformant)
        //    {
        //        if ((newInformant != null) && (!_informants.Contains(newInformant)))
        //        {
        //            _informants.Add(newInformant);
        //            /**/
        //            /*newInformant.ChangePersonalBest += NewBestInformant;*/
        //            return true;
        //        }
        //        else
        //            return false;
        //    }

        //    //було б гарним рішенням, але виникають дві проблеми:
        //    //   1) частинка не знає кращий напрямок пошуку(можна якось костильно розв'язати);
        //    //   2) використання оновленої інформації на поточній ітерації схожа з методом Зейделя(проконсультуватись, можливо так теж підійде). 
        //    /*
        //    public event Action<Particle<T>> ChangePersonalBest;

        //    private void NewBestInformant(Particle<T> sender)
        //    {
        //        if (sender._fitnessBest > this._informantBest._fitnessBest)
        //            this.InformantBest = sender;         
        //    }
        //    */
        //}

        public const ushort MinSizePopulation = 2;
        
        List<Particle<T>> _population;
        T _bestPosition;
        double _bestFit;
        IArea<T> _areal;
        Func<T, double> _fitness;
        byte _minCountInformants;        
        byte _maxCountInformants;        
        
        /// <summary>
        /// Індексатор для доступу до окремих частинок рою
        /// </summary>
        /// <param name="indexParticle">індекс частинки у рої</param>
        /// <returns>посилання на частинку</returns>
        public Particle<T> this[int indexParticle]
        {
            get { return _population[indexParticle]; }
        }

        /// <summary>
        /// Використовувана роєм топологія зв'язків 
        /// </summary>
        public readonly TopologyLinkages Topology;

        /// <summary>
        /// Визначає тип задачі: мінімізація(при значенні false) або максимізація(при true)
        /// </summary>
        public bool SearchDirection
        {
            protected set;
            get;
        }

        /// <summary>
        /// Повертає дані про позицію, у якій було досягнуте найкраще значення фітнес-функції
        /// </summary>
        public T BestPosition { get { return _bestPosition; } }

        /// <summary>
        /// Повертає найкраще досягнуте якоюсь частинкою рою значення фітнес-функції
        /// </summary>
        public double BestFitness { get { return _bestFit; } }

        /// <summary>
        /// Повертає кількість частинок у рої
        /// </summary>
        public int Size { get { return _population.Count; } }

        /// <summary>
        /// Повертає та задає параметр, що регулює мінімальну кількість інформаторів, яка може бути у частинки
        /// </summary>
        public byte MinCountInformants
        {
            get { return _minCountInformants; }
            set
            {
                if ((0 < value) && (value <= _maxCountInformants))
                    _minCountInformants = value;
            }
        }        

        /// <summary>
        /// Повертає та задає параметр, що регулює максимальну кількість інформаторів, яка може бути у частинки
        /// </summary>
        public byte MaxCountInformants
        {
            get { return _maxCountInformants; }
            set { 
                if ((_minCountInformants <= value) && (value < _population.Count - 1))
                    _maxCountInformants = value; 
            }
        }

        /// <summary>
        /// Метод оновлення інформації про найкращу у рої позицію і значення фітнес-функції у цій позиції 
        /// </summary>
        /// <returns>чи відбулися зміни після оновлення</returns>
        public bool UpdateBest()
        {
            double prevFitBest = _bestFit;
            foreach (Particle<T> ind in _population)
                if (SearchDirection ? ind.FitnessBest > _bestFit : ind.FitnessBest < _bestFit)
                {
                    _bestPosition = ind.PersonalBest;
                    _bestFit = ind.FitnessBest;
                }
            return prevFitBest != _bestFit;
        }

        /// <summary>
        /// Метод оновлення стану рою при переході на наступну ітерацію
        /// </summary>
        /// <param name="tweak">спосіб модифікації позиції та швидкості частки згідно з обмеженнями</param>
        /// <returns>повертає true, якщо було поліпшення глобальної кращої позиції пошуку оптимального рішення, або false в інакшому випадку</returns>
        public bool Move(Action<Particle<T>, IArea<T>> tweak)
        {            
            bool improveIndicator = false;
            //T newPosition;
            foreach (Particle<T> individ in _population)
            {
                tweak(individ, _areal);
                /*???*/
                //newPosition = _areal.Projection(individ.CurrPosition);

                //добавить обнуление скоростей

                //individ.CurrPosition = newPosition;  
                /*???*/
                individ.ValueFitness = _fitness(individ.CurrPosition);
                if (SearchDirection ? individ.ValueFitness > individ.FitnessBest : individ.ValueFitness < individ.FitnessBest)
                {
                    individ.PersonalBest = individ.CurrPosition;
                    individ.FitnessBest = individ.ValueFitness;
                    if (SearchDirection ? individ.FitnessBest > _bestFit : individ.FitnessBest < _bestFit)
                    {
                        _bestPosition = individ.PersonalBest;
                        _bestFit = individ.FitnessBest;
                        improveIndicator = true;
                    }
                }
            }
            return improveIndicator;
        }

        /// <summary>
        /// Оновлення найкращих сусідів 
        /// </summary>
        public void Communication()
        {
            foreach (var ind in _population)
            {
                //исправление соответствующее книге
                //ind.InformantBest = ind;
                for (int i = 0; i < ind.CountInformants; i++)
                    if (SearchDirection ? ind[i].FitnessBest > ind.InformantBest.FitnessBest : ind[i].FitnessBest < ind.InformantBest.FitnessBest)                    
                        ind.InformantBest = ind[i];                    
            }
        }

        /// <summary>
        /// Метод оновлення комунікаційних зв'язків між частинками(раціонально викликати, 
        /// якщо використувана топологія заснована на випадкових зв'язках) 
        /// </summary>
        /// <param name="accidentFactor">випадковий фактор</param>
        public void ResetInformants(Random accidentFactor)
        {
            int s = this.Size - 1;
            switch (Topology)
            {
                case TopologyLinkages.RandomDraft:
                    if (accidentFactor == null)
                        throw new ArgumentNullException("accidentFactor");

                    int count;                    
                    foreach (var ind in _population)
                    {
                        ind.DeleteInformants();
                        count = accidentFactor.Next(_minCountInformants, _maxCountInformants);
                        do
                        {
                            ind.AddInformant(_population[accidentFactor.Next(s)]); 
                        } while (ind.CountInformants != count);
                    }
                    break;

                default:                    
                    //throw new NotImplementedException();
                    break;
            }
        }

        public Swarm(Func<T, double> fitnessFunction, IArea<T> areal, Random accidentFactor, ushort sizePopulation, bool max, TopologyLinkages topology, params object[] topologyOptions) //
        {
            if (fitnessFunction == null)
                throw new ArgumentNullException("fitnessFunction");
            
            if (areal == null)
                throw new ArgumentNullException("areal");

            if (sizePopulation < Swarm<T>.MinSizePopulation)
                throw new ArgumentOutOfRangeException("sizePopulation");

            _fitness = fitnessFunction;
            _areal = areal;
            _population = new List<Particle<T>>();
            for (int i = 0; i < sizePopulation; i++)
            {
                _population.Add(new Particle<T>() 
                                {                                     
                                    CurrPosition = _areal.GetRandomElement(accidentFactor)                                    
                                });
                _population[i].PersonalBest = _population[i].CurrPosition;
                _population[i].FitnessBest = _population[i].ValueFitness = _fitness(_population[i].CurrPosition);
            }
            SearchDirection = max;
            int n = _population.Count - 1;
            switch (Topology)
            {
                case TopologyLinkages.Circle:
                    
                    _population[0].AddInformant(_population[n]);
                    _population[0].AddInformant(_population[1]);
                    for (int i = 1; i < n; i++)
                    {
                        _population[i].AddInformant(_population[i - 1]);
                        _population[i].AddInformant(_population[i + 1]);
                    }
                    _population[n].AddInformant(_population[n - 1]);
                    _population[n].AddInformant(_population[0]);                    
                    break;

                case TopologyLinkages.Star:
                    for (int i = 0; i <= n; i++)
                        for (int j = 0; j <= n; j++)
                            if (i != j)
                                _population[i].AddInformant(_population[j]);
                    break;
                
                default:
                    if (Topology == TopologyLinkages.RandomDraft)
                    {
                        if ((! byte.TryParse(topologyOptions[0].ToString(), out _minCountInformants)) || (_minCountInformants > _population.Count))
                            _minCountInformants = (byte)((_population.Count < 256 ? _population.Count : 255) * 0.3 + 0.5);

                        if ((!byte.TryParse(topologyOptions[1].ToString(), out _maxCountInformants)) || (_maxCountInformants > _population.Count))
                            _maxCountInformants = (byte)((_population.Count < 256 ? _population.Count : 255) * 0.5 + 0.5);

                        if (_maxCountInformants < _minCountInformants)
                            _minCountInformants = (byte)(_maxCountInformants * 0.5 + 0.5);
                    }
                    ResetInformants(accidentFactor);
                    break;
            }
            Communication();
            _bestPosition = _population[0].PersonalBest;
            _bestFit = _population[0].FitnessBest;
            UpdateBest();
        }        
    }
}

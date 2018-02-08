using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDimensionalOptimization;

namespace MultiDimensionalOptimization
{
    static class MethodsConditionalOptimization
    {
        public static Vector ConditionalGradientForLinearCondition(Func<Vector, double> f, Func<Vector, double>[] grad_f, Matrix2D A, Vector b, Vector x0, double eps, out List<Vector> minimizeSequence)
        {            
            int n = grad_f.Length;
            if ((eps <= 0) || (A.ColCount != n) || (x0.Length != n))
                throw new ArgumentException();

            Vector grad_f_x_k = Vector.CreateVector(n),
                   h_k;
            minimizeSequence = new List<Vector>();
            double aljfa_k;
            Func<double, double> g_k; 
            Func<Vector, double> f_k;
            Vector x_k = x0.Copy(),
                   x_k_;
            do
            {
                minimizeSequence.Add(x_k);
                for (int i = 0; i < n; i++)
                    grad_f_x_k[i] = grad_f[i](x_k);

                f_k = (x) => (f(x_k) + grad_f_x_k * (x - x_k));                            //?????????????????????????
                if (f_k(x_k_ = SimplexForInequalitys(-grad_f_x_k, grad_f_x_k * x_k, A, b)) == 0) //?????????????????????
                    return x_k;

                h_k = x_k_ - x_k;
                g_k = (aljfa) => (f(x_k + aljfa * h_k));
                aljfa_k = MethodsSearchPointMinOfFunction.M_GoldenSection(g_k, 0, 1d, eps);
            }
            while ((x_k - (x_k = x_k + aljfa_k * h_k)).Norm >= eps);
            minimizeSequence.Add(x_k);
            return x_k;             
        }

        /// <summary>
        /// Симплекс-метод для знаходження максимуму цільової функції z = (c, x) + z0 в області заданій системою нерівностей (A, x) ≤ b 
        /// </summary>
        /// <param name="c">вектор коефіцієнтів цільової функції</param>
        /// <param name="z0">значення функції у точці (0; ...; 0)</param>
        /// <param name="A">матриця системи обмежень</param>
        /// <param name="b">вектор вільних членів системи обмежень</param>
        /// <returns>вектор оптимального плану</returns>
        public static Vector SimplexForInequalitys(Vector c, double z0, Matrix2D A, Vector b)//+-+-+-
        {
            if ((c.Length != A.ColCount) || (A.RowCount != b.Length))
                throw new ArgumentException();

            //for (int i = 0; i < b.Length; i++)
            //    if (b[i] < 0)
            //        throw new ArgumentException();

            int n = A.ColCount,
                m = A.RowCount;
            double z_i = z0; //значення цільової функції на поточній ітерації
            //double[] c_basis = new double[m];
            double[,] P = new double[m, n + m + 1]; //основна частина таблиці: матриця таблиці рівностей
            int[] basis_indexis = new int[m];       //індекси 1..(n + m) змінних, які на поточній ітерації є базисними 
            double[] delta = new double[n + m];     //нижній рядок симплекс-таблиці
            for (int i = 0; i < m; i++)
            {
                P[i, 0] = b[i];
                for (int j = 1; j <= n; j++)
                    P[i, j] = A.GetElement(i, j - 1);
                P[i, basis_indexis[i] = n + i + 1] = 1d;                
            }
            for (int j = 0; j < n; j++)
                delta[j] = z0 - c[j];

            int r/*виводимо з базису*/, k/*вводимо до базису*/;
            double tetaMin, teta;
            while (delta[k = SearchIndexFirstMin(delta)] < 0)  //теорема 1
            {
                k++;
                r = 0;
                //теорема 3
                while ((r < m) && ((tetaMin = P[r, 0] / P[r, k]) < 0))  //?????????????????????????????????
                    r++;

                if (r == m) //теорема 2 
                    return null;

                tetaMin = P[r, 0] / P[r, k];
                for (int i = r + 1; i < m; i++)
                    if (((teta = P[i, 0] / P[i, k]) > 0) && (teta < tetaMin))
                    {
                        r = i;
                        tetaMin = teta;
                    }
                              
                basis_indexis[r] = k;
                //перераховуємо таблицю
                for (int i = m - 1; i >= 0; i--)
                    if (i != r)
                    {                   
                        for (int j = n + m; j >= 0; j--)
                            if (j != k)
                                P[i, j] = P[i, j] - P[r, j] * P[i, k] / P[r, k];                                            
                    }
                z_i = z_i - P[r, 0] * delta[k - 1] / P[r, k]; //перераховуємо значення цільової функції 
                P[r, 0] = P[r, 0] / P[r, k];
                for (int j = 0; j < delta.Length; j++)
                    if (j != k - 1)
                    {
                        delta[j] = delta[j] - delta[k - 1] * P[r, j + 1] / P[r, k]; //перерахунок нижнього рядка
                        P[r, j + 1] = P[r, j + 1] / P[r, k]; //перерахунок направляючого рядка 
                    }
                //заповнення направляючого стовпця
                delta[k - 1] = 0;
                for (int i = 0; i < m; i++)
                    if (i != r)
                        P[i, k] = 0;
                P[r, k] = 1;

            }
            Vector result = Vector.CreateVector(n);
            for (int i = 0; i < m; i++)
                if (basis_indexis[i] - 1 < n)
                    result[basis_indexis[i] - 1] = P[i, 0];
            return result;
        }

        private static int SearchIndexFirstMin(double[] seq) 
        {
            int indMin = 0;
            for (int i = 1; i < seq.Length; i++)
                if (seq[i] < seq[indMin])
                    indMin = i;
            return indMin;
        }

        public static Vector Simplex(Vector c, double z0, Matrix2D A, bool[] equality, Vector b, bool[] conditionNotNegative, bool max) //-----------
        {
            if ((c.Length != A.ColCount) || (A.RowCount != b.Length) || (equality.Length != b.Length) || (conditionNotNegative.Length != c.Length))
                throw new ArgumentException();

            int n = A.ColCount,
                m = A.RowCount,
                countInequalitys = equality.Count<bool>((x) => (x == false)),
                countConditionsNotNeg = conditionNotNegative.Count<bool>((x) => (x)),
                countImportantVariables = 2*n - countConditionsNotNeg;
            
            double[][] P = new double[m][];
            double[] basisSolution = new double[m];
            int[] basisIndexis = new int[m];
            for (int i = 0, j, k, num_ineq = 0; i < m; i++)
            {
                P[i] = new double[countImportantVariables + countInequalitys];
                basisSolution[i] = Math.Abs(b[i]);
                if (b[i] < 0)
                    for (j = 0, k = 0; j < countImportantVariables; j++, k++)
                    {
                        P[i][j] = -A.GetElement(i, k);
                        if (!conditionNotNegative[k])
                            P[i][++j] = A.GetElement(i, k);
                    }
                else
                    for (j = 0, k = 0; j < countImportantVariables; j++, k++)
                    {
                        P[i][j] = A.GetElement(i, k);
                        if (!conditionNotNegative[k])
                            P[i][++j] = -A.GetElement(i, k);
                    }
                
                if (!equality[i])
                    if (b[i] < 0)
                        P[i][countImportantVariables + num_ineq++] = basisIndexis[i] = -1;
                    else                    
                        P[i][basisIndexis[i] = countImportantVariables + num_ineq++] = 1; 
                else
                    basisIndexis[i] = -1;
            }
            double z_i = -z0;
            double[] indexRow = new double[P[0].Length];
            for (int i = 0, k = 0; k < n; i++, k++)
            {
                indexRow[i] = c[k];
                if (!conditionNotNegative[k])
                    indexRow[++i] = -c[k];
            }
            int pivotCol = -1, pivotRow = -1;
            Func<bool> SignOfOptim, SignOfInfinity;
            Action NewSolution;
            #region Задание делегатов-теорем в зависимости от параметра max
            if (max)
            {
                SignOfOptim = () =>
                {
                    for (int i = 0; i < indexRow.Length; i++)
                        if (indexRow[i] > 0)
                            return false;
                    return true;
                };

                SignOfInfinity = () =>
                {
                    for (int i = 0, j = m + 1; i < indexRow.Length; i++)
                    {
                        if (indexRow[i] > 0)
                            for (j = 0; j < m; j++)
                                if (P[j][i] >= 0)
                                    j = m;
                        if (j == m)
                            return true;
                    }
                    return false;
                };

                NewSolution = () =>
                {
                    for (int i = 0, j; i < indexRow.Length; i++)                        
                        if (indexRow[i] > 0)                            
                            for (j = 0; j < m; j++)
                                if (P[j][i] > 0)
                                {
                                    pivotCol = i;
                                    pivotRow = j;
                                    for (int k = j + 1; k < m; k++)
                                    {
                                        if ((P[k][pivotCol] > 0) && (basisSolution[k] / P[k][pivotCol] < basisSolution[pivotRow] / P[pivotRow][pivotCol]))
                                            pivotRow = k;
                                    }
                                }
                    pivotCol = -1;
                    pivotRow = -1;
                };
            }
            else
            {
                SignOfOptim = () =>
                {
                    for (int i = 0; i < indexRow.Length; i++)
                        if (indexRow[i] < 0)
                            return false;
                    return true;
                };

                SignOfInfinity = () =>
                {
                    for (int i = 0, j = m + 1; i < indexRow.Length; i++)
                    {
                        if (indexRow[i] < 0)
                            for (j = 0; j < m; j++)
                                if (P[j][i] >= 0)
                                    j = m;
                        if (j == m)
                            return true;
                    }
                    return false;
                };

                NewSolution = () =>
                {
                    for (int i = 0, j; i < indexRow.Length; i++)
                        if (indexRow[i] < 0)
                            for (j = 0; j < m; j++)
                                if (P[j][i] > 0)
                                {
                                    pivotCol = i;
                                    pivotRow = j;
                                    for (int k = j + 1; k < m; k++)
                                    {
                                        if ((P[k][pivotCol] > 0) && (basisSolution[k] / P[k][pivotCol] < basisSolution[pivotRow] / P[pivotRow][pivotCol]))
                                            pivotRow = k;
                                    }
                                }
                    pivotCol = -1;
                    pivotRow = -1;
                };
            }
            #endregion
            Action ReCalcTable = () =>
                {
                    basisIndexis[pivotRow] = pivotCol;
                    //перераховуємо таблицю
                    for (int i = m - 1; i >= 0; i--)
                        if (i != pivotRow)
                        {                   
                            for (int j = indexRow.Length - 1; j >= 0; j--)
                                if (j != pivotCol)
                                    P[i][j] -= P[pivotRow][j] * P[i][pivotCol] / P[pivotRow][pivotCol];
                            basisSolution[i] -= basisSolution[pivotRow] * P[i][pivotCol] / P[pivotRow][pivotCol];                 
                        }
                    /*можна добавить проверку возростания-убывания целевой функции*/
                    z_i -= basisSolution[pivotRow] * indexRow[pivotCol] / P[pivotRow][pivotCol]; //перераховуємо значення цільової функції 
                    basisSolution[pivotRow] /=  P[pivotRow][pivotCol];
                    for (int j = 0; j < indexRow.Length; j++)
                        if (j != pivotCol)
                        {
                            indexRow[j] -= indexRow[pivotCol] * P[pivotRow][j] / P[pivotRow][pivotCol]; //перерахунок нижнього рядка
                            P[pivotRow][j] /= P[pivotRow][pivotCol]; //перерахунок направляючого рядка 
                        }
                    //заповнення направляючого стовпця
                    indexRow[pivotCol] = 0;
                    for (int i = 0; i < m; i++)
                        if (i != pivotRow)
                            P[i][pivotCol] = 0;
                    P[pivotRow][pivotCol] = 1;
                };
            
            //for (int i = 0, countDeficientIndexis = basisIndexis.Count<int>(x => x == -1); i < countDeficientIndexis; i++)
            //{
            //    pivotCol = 
            //}
            double tetaMin;
            foreach (int pivotR in basisIndexis.Where<int>(x => x == -1).Select<int, int>((x, index) => index))
            {
                tetaMin = double.PositiveInfinity;
                for (int i = 0; i < countImportantVariables; i++)
                {
                    if ((P[pivotR][i] > 0) && (basisSolution[pivotR]/P[pivotR][i] < tetaMin))
                    {
                        tetaMin = basisSolution[pivotR]/P[pivotR][i];
                        pivotCol = i;
                    }
                }
                if (double.IsPositiveInfinity(tetaMin))                
                    throw new NotImplementedException("Система обмежень не сумісна");
                else
                    pivotRow = pivotR;
                ReCalcTable();
                if (basisSolution.Any<double>(x => x < 0))
                    throw new NotImplementedException("Порушення умови невід'ємності при перерахунку таблиці");
            }
            while (!SignOfOptim())
            {
                if (SignOfInfinity())
                    throw new NotImplementedException("Цільова функція не обмежена в заданій області");

                NewSolution();
                ReCalcTable();
            }
            Vector x1 = Vector.CreateVector(n),
                   x2 = Vector.CreateVector(n);
            for (int i = 0, j = 0; j < n; i++, j++)
            {
                for (int k = 0; k < m; k++) 
                    if (basisIndexis[k] == i)
			        {
                        x1[j] = basisSolution[k];
			            k = m;
			        }
                if (!equality[j])
                {
                    i++;
                    for (int k = 0; k < m; k++)
                        if (basisIndexis[k] == i)
                        {
                            x2[j] = basisSolution[k];
                            k = m;
                        }
                }
            }
            return x1 - x2;
        }
    }
}

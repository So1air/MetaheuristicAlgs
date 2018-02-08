using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalOptimization
{
    static class MethodsSearchPointMinOfFunction
    {
        private static double _a = double.NaN, _b = double.NaN, _eps = 0.00001;

        /// <summary>
        /// Получает и задает значение левого(меньшего по значению) конца отрезка, на котором находится локальный минимум
        /// </summary>
        public static double A
        {
            get
            {
                return _a;
            }

            set
            {
                if ((double.IsNaN(_b)) || (value < _b))
                    _a = value;
            }
        }
        /// <summary>
        /// Получает и задает значение правого(большего по значению) конца отрезка, на котором находится локальный минимум
        /// </summary>
        public static double B
        {
            get
            {
                return _b;
            }
            set
            {
                if ((double.IsNaN(_a)) || (value > _a))
                    _b = value;
            }
        }
        /// <summary>
        /// Получает и задает значение точности, с которой требуется найти точку минимума на заданном отрезке
        /// </summary>
        public static double Eps
        {
            get
            {
                return _eps;
            }
            set
            {
                if (value > 0)
                    _eps = value;
            }
        }

        public struct M_Info
        {
            public int k;
            public double a_k; 
            public double b_k; 
            public double ljambda_k; 
            public double mju_k; 

            public M_Info(int k, double a_k, double b_k, double ljambda_k, double mju_k)
            {
                this.k = k;
                this.a_k = a_k;
                this.b_k = b_k;
                this.ljambda_k = ljambda_k;
                this.mju_k = mju_k;
            }
        }

        public static double M_HalfInterval(Func<double, double> f, double a, double b, double eps)
        {
            A = a;
            B = b;
            Eps = eps;
            return M_HalfInterval(f);
        }

        public static double M_HalfInterval(Func<double, double> f)
        {
            List<M_Info> list;
            return M_HalfInterval(f, out list);
        }

        public static double M_HalfInterval(Func<double, double> f, out List<M_Info> m_info)
        {
            m_info = new List<M_Info>();

            double delta = _eps / 2d;
            m_info.Add(new M_Info(0, _a, _b, (_a + _b - delta) / 2, (_a + _b + delta) / 2));
            if (_b - _a < _eps)
                return (_b + _a) / 2;
            for (int k = 0, n = (int)Math.Log((_b - _a - delta) / (_eps - delta), 2); k < n; k++)
                m_info.Add((f(m_info[k].ljambda_k) <= f(m_info[k].mju_k)) ? 
                    new M_Info(k + 1, m_info[k].a_k, m_info[k].mju_k, (m_info[k].a_k + m_info[k].mju_k - delta) / 2, (m_info[k].a_k + m_info[k].mju_k + delta) / 2) :
                    new M_Info(k + 1, m_info[k].ljambda_k, m_info[k].b_k, (m_info[k].ljambda_k + m_info[k].b_k - delta) / 2, (m_info[k].ljambda_k + m_info[k].b_k + delta) / 2));
            return (m_info[m_info.Count - 1].a_k + m_info[m_info.Count - 1].b_k) / 2;            
        }

        public static double M_GoldenSection(Func<double, double> f, double a, double b, double eps)
        {
            A = a;
            B = b;
            Eps = eps;
            return M_GoldenSection(f);
        }

        public static double M_GoldenSection(Func<double, double> f)
        {
            List<M_Info> list;
            return M_GoldenSection(f, out list);
        }

        public static double M_GoldenSection(Func<double, double> f, out List<M_Info> m_info)
        {
            m_info = new List<M_Info>();
            double c_ljambda = (3 - Math.Sqrt(5)) / 2,
                   c_mju     = (Math.Sqrt(5) - 1) / 2;

            m_info.Add(new M_Info(0, _a, _b, _a + (_b - _a) * c_ljambda, _a + (_b - _a) * c_mju));
            double f1 = f(m_info[0].ljambda_k),
                   f2 = f(m_info[0].mju_k);
            for(int k = 0; m_info[k].b_k - m_info[k].a_k >= _eps; k++)
                if (f1 <= f2)
                {
                    m_info.Add(new M_Info(k + 1, m_info[k].a_k, m_info[k].mju_k, m_info[k].a_k + c_ljambda * (m_info[k].mju_k - m_info[k].a_k), m_info[k].ljambda_k));
                    f2 = f1;
                    f1 = f(m_info[k + 1].ljambda_k);
                }
                else
                {
                    m_info.Add(new M_Info(k + 1, m_info[k].ljambda_k, m_info[k].b_k, m_info[k].mju_k, m_info[k].ljambda_k + c_mju * (m_info[k].b_k - m_info[k].ljambda_k)));
                    f1 = f2;
                    f2 = f(m_info[k + 1].mju_k);
                }

            return (m_info[m_info.Count - 1].a_k + m_info[m_info.Count - 1].b_k) / 2;
        }

        public static double M_Fibonacci(Func<double, double> f, double a, double b, double eps)
        {
            A = a;
            B = b;
            Eps = eps;
            return M_Fibonacci(f);
        }

        public static double M_Fibonacci(Func<double, double> f)
        {
            List<M_Info> list;
            return M_Fibonacci(f, out list);
        }

        public static double M_Fibonacci(Func<double, double> f, out List<M_Info> m_info)
        {
            m_info = new List<M_Info>();
            if (_b - _a < _eps)
            {
                m_info.Add(new M_Info(0, _a, _b, (_a + _b) / 2, (_a + _b) / 2));
                return (_a + _b) / 2;
            }

            List<uint> Fib = new List<uint>();
            Fib.Add(1);
            Fib.Add(1);
            int n_2 = 1;
            double b_a_eps = (_b - _a) / _eps;
            do
            {
                Fib.Add(Fib[n_2 - 1] + Fib[n_2]);
            } while /*((Fib[n_2 - 1] > b_a_eps) || */(b_a_eps > Fib[++n_2])/*)*/;
            
            m_info.Add(new M_Info(0, _a, _b, _a + Fib[n_2 - 2] * (_b - _a)/ Fib[n_2],  _a + Fib[n_2 - 1] * (_b - _a)/ Fib[n_2]));
            double f1 = f(m_info[0].ljambda_k),
                   f2 = f(m_info[0].mju_k);            
            for (int k = 0, n = n_2 - 3; k < n; k++)
                if(f1 <= f2) 
                {
                    m_info.Add(new M_Info(k + 1, m_info[k].a_k, m_info[k].mju_k, m_info[k].a_k + Fib[n - k] * (_b - _a) / Fib[n_2], m_info[k].ljambda_k));
                    f2 = f1;
                    f1 = f(m_info[k + 1].ljambda_k);
                }
                else
                {
                    m_info.Add(new M_Info(k + 1, m_info[k].ljambda_k, m_info[k].b_k, m_info[k].mju_k, m_info[k].ljambda_k + Fib[n - k + 1] * (_b - _a) / Fib[n_2]));
                    f1 = f2;
                    f2 = f(m_info[k + 1].mju_k);
                }

            return (m_info[m_info.Count - 1].a_k + m_info[m_info.Count - 1].b_k) / 2;
        }
    }
}

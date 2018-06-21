using System;

namespace MultiDimensionalOptimization
{
    /// <summary>
    /// Вектор дійсних чисел
    /// </summary>
    public class Vector
    {
        public const int MAXCOUNTCOORDINATS = ushort.MaxValue;

        private double[] _vectorElements;

        /// <summary>
        /// Довільний доступ до будь-якої компоненты вектора
        /// </summary>
        /// <param name="i">індекс компоненти</param>
        /// <returns>компонента вектора</returns>
        public double this[int i]
        {
            get 
            {
                return _vectorElements[i];
            }
            set 
            {
                _vectorElements[i] = value;
            }
        }

        public int Length
        {
            get
            {
                return _vectorElements.Length;
            }
        }

        /// <summary>
        /// Унарна операція зміни знаків кожної компоненти вектора 
        /// </summary>
        /// <param name="v">вектор, компоненти якого змінюються</param>
        /// <returns>вектор з протилежними за знаком компонентами</returns>
        public static Vector operator -(Vector v)
        {
            Vector result = new Vector(v._vectorElements.Length);
            for(int i = 0; i < result.Length; i++)
                result._vectorElements[i] = - v._vectorElements[i];

            return result;
        }

        /// <summary>
        /// Бінарна операція множення вектора на число
        /// </summary>
        /// <param name="alfa">дійсне число</param>
        /// <param name="v">вектор дійсних чисел</param>
        /// <returns>вектор, колінеарний вихідному</returns>
        public static Vector operator *(double alfa, Vector v)
        {
            Vector result = new Vector(v._vectorElements.Length);
            for (int i = 0; i < result.Length; i++)
                result[i] = v._vectorElements[i] * alfa;
            return result;
        }
        

        public static Vector operator *(double[] alfas, Vector v) // ???????
        {
            Vector result = new Vector(v._vectorElements.Length);
            for (int i = 0; i < result.Length; i++)
                result[i] = v._vectorElements[i] * alfas[i];
            return result;
        }

        /// <summary>
        /// Бінарна операція скалярного добутку векторів
        /// </summary>
        /// <param name="left_v">перший операнд</param>
        /// <param name="right_v">другий операнд</param>
        /// <returns>дійсне число - результат скалярного добутку</returns>
        public static double operator *(Vector left_v, Vector right_v)
        {
            double result = 0;
            if (left_v.Length == right_v.Length)
                for (int i = 0; i < left_v.Length; i++)
                    result += left_v._vectorElements[i] * right_v._vectorElements[i];
            else
                result = double.NaN;
            return result;
        }

        /// <summary>
        /// Бінарна операція покомпонентного додавання векторів
        /// </summary>
        /// <param name="left_v">лівий операнд</param>
        /// <param name="right_v">правий операнд</param>
        /// <returns>вектор - результат додавання</returns>
        public static Vector operator +(Vector left_v, Vector right_v)
        {
            Vector result = new Vector(left_v.Length);
            if (left_v.Length == right_v.Length)
                for (int i = 0; i < result.Length; i++)
                    result._vectorElements[i] = left_v._vectorElements[i] + right_v._vectorElements[i];
            else
                result = null;
            return result;
        }

        /// <summary>
        /// Бінарна операція покомпонентного віднімання векторів
        /// </summary>
        /// <param name="left_v">лівий операнд</param>
        /// <param name="right_v">правий операнд</param>
        /// <returns>вектор - результат віднімання</returns>
        public static Vector operator -(Vector left_v, Vector right_v)
        {
            //return left_v + (-right_v);
            Vector result = new Vector(left_v.Length);
            if (left_v.Length == right_v.Length)
                for (int i = 0; i < result.Length; i++)
                    result._vectorElements[i] = left_v._vectorElements[i] - right_v._vectorElements[i];
            else
                result = null;
            return result;
        }

        public static bool operator ==(Vector left_v, Vector right_v)
        {
            if (object.ReferenceEquals(left_v, null))
                return object.ReferenceEquals(right_v, null);

            if (object.ReferenceEquals(right_v, null))
                return false;

            if (object.ReferenceEquals(left_v, right_v))
                return true;                
            else
                if (left_v.Length == right_v.Length) 
                {
                    for (int i = 0; i < left_v.Length; i++)
                        if (left_v[i] != right_v[i])
                            return false;
                }
                else
                    return false; 

            return true;
        }

        /// <summary>
        /// Бінарна операція виявлення відмінності у значеннях відповідних компонент векторів
        /// </summary>
        /// <param name="left_v">перший операнд</param>
        /// <param name="right_v">другий операнд</param>
        /// <returns>булеве значення, що дорівнює true тільки у разі наявності відмінності між відповідними компонентами вектора</returns>
        public static bool operator !=(Vector left_v, Vector right_v)
        {
            return !(left_v == right_v);
        }

        public override bool Equals(object obj)
        {
            return (obj is Vector) ? (Vector)obj == this : false;
        }

        public bool IsNullVector
        {
            get
            {
                for (int i = 0; i < this._vectorElements.Length; i++)
                    if (this._vectorElements[i] != 0)
                        return false;

                return true;
            }
        }

        /// <summary>
        /// Третя(сферична, або евклідова) норма.
        /// </summary>
        public double Norm
        {
            get
            {
                double result = 0;
                foreach (double x in _vectorElements)
                    result += x * x;
                return Math.Sqrt(result);
            }
        }

        public Vector Copy()
        {
            return new Vector(this._vectorElements);
        }

        public bool CopyTo(Vector target)
        {
            if (target != null)
                if (target.Length == this.Length)
                {
                    for (int i = 0; i < this.Length; i++)
                        target._vectorElements[i] = this._vectorElements[i];
                    return true;
                }

            return false;
        }

        public double[] ToArray()
        {
            double[] res = new double[this._vectorElements.Length];
            this._vectorElements.CopyTo(res, 0);
            return res;
        }

        public override string ToString()
        {
            string res = this._vectorElements[0].ToString();
            for (int i = 1; i < this._vectorElements.Length; i++)
                res += "; " + this._vectorElements[i];
            return res;
        }

        public static Vector CreateVector(int length)
        {
            if ((length > 0) && (length <= MAXCOUNTCOORDINATS))
                return new Vector(length);
            else
                return null;
        }             

        public static Vector CreateVector(double[] coordinats)
        {
            if ((coordinats != null) && (coordinats.Length <= MAXCOUNTCOORDINATS))
                return new Vector(coordinats);
            else
                return null;
        }

        private Vector(int len)
        {
            _vectorElements = new double[len];
        }

        private Vector(double[] coordinats)
            :this(coordinats.Length)
        {
            coordinats.CopyTo(_vectorElements, 0);
        }
    }
}

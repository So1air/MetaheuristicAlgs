using System;

namespace MultiDimensionalOptimization
{
    public class Vector
    {
        public const int MAXCOUNTCOORDINATS = ushort.MaxValue;

        private double[] _vectorElements;

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

        public static Vector operator -(Vector v)
        {
            Vector result = new Vector(v._vectorElements.Length);
            for(int i = 0; i < result.Length; i++)
                result._vectorElements[i] = - v._vectorElements[i];

            return result;
        }

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

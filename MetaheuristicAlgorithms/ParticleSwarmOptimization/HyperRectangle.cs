using MultiDimensionalOptimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics
{
    class HyperRectangle : IArea<Vector>
    {
        public Vector LeastVertex { private set; get; }
        double[] _sides;

        public double GetSide(int index)
        {
            return _sides[index];
        }

        public void SetSide(int index, double newValue)
        {
            if (newValue < 0)
            {
                LeastVertex[index] += newValue;
                _sides[index] = -newValue;
            }
            else
                _sides[index] = newValue;
        }

        public int Dimensionality
        {
            get { return _sides.Length; }
        }

        public bool IsContains(Vector element)
        {
            if (element == null)
                throw new ArgumentNullException("element");
            
            if (element.Length != LeastVertex.Length)
                throw new ArgumentException("element");
            
            int i = 0;
            for (; (i < element.Length) && (element[i] >= LeastVertex[i]) && (element[i] - LeastVertex[i] <= _sides[i]); i++)
                ;
            return i == element.Length;
        }

        public Vector Projection(Vector element)
        {
            if (element == null)
                throw new ArgumentNullException("element");
            
            if (element.Length != LeastVertex.Length)
                throw new ArgumentException("element");

            Vector result = Vector.CreateVector(LeastVertex.Length);
            for (int i = 0; i < result.Length; i++)
            {
                if (element[i] < LeastVertex[i])
                    result[i] = LeastVertex[i];
                else
                    if (element[i] - LeastVertex[i] <= _sides[i])
                        result[i] = element[i];
                    else result[i] = LeastVertex[i] + _sides[i]; 
            }
            return result;
        }

        public void Projection(ref Vector element)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            if (element.Length != LeastVertex.Length)
                throw new ArgumentException("element");

            for (int i = 0; i < element.Length; i++)
            {
                if (element[i] < LeastVertex[i])
                    element[i] = LeastVertex[i];
                else
                    if (element[i] - LeastVertex[i] > _sides[i])
                        element[i] = LeastVertex[i] + _sides[i];
            }
        }

        public Vector GetRandomElement(Random accidentFactor)
        {
            Vector result = Vector.CreateVector(LeastVertex.Length);
            for (int i = 0; i < result.Length; i++)            
                result[i] = LeastVertex[i] + accidentFactor.NextDouble() * _sides[i];
            return result;

        }

        public HyperRectangle(Vector leastVertex, double[] sides)
        {
            if (leastVertex == null)
                throw new ArgumentNullException("leastPoint");
            if (sides == null)
                throw new ArgumentNullException("sides");
            if (sides.Length != leastVertex.Length)
                throw new ArgumentException("sides");

            LeastVertex = leastVertex.Copy();
            _sides = new double[LeastVertex.Length];
            for (int i = 0; i < _sides.Length; i++)
                this.SetSide(i, sides[i]);
        }
    }
}

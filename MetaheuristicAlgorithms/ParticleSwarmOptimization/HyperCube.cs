using MultiDimensionalOptimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics
{
    public class HyperCube : IArea<Vector>
    {        
        public Vector LeastVertex { private set; get; }
        double _side;

        public double Side
        {
            get { return _side; }
            set 
            {
                if (value < 0)
                {
                    for (int i = 0; i < LeastVertex.Length; i++)
                        LeastVertex[i] += value;
                    _side = -value;
                }
                else
                    _side = value; 
            }
        }

        public int Dimensionality
        {
            get { return LeastVertex.Length; }
        }

        public bool IsContains(Vector element)
        {
            if (element == null)
                throw new ArgumentNullException("element");
            
            if (element.Length != LeastVertex.Length)
                throw new ArgumentException("element");
            
            int i = 0;
            for (; (i < element.Length) && (element[i] >= LeastVertex[i]) && (element[i] - LeastVertex[i] <= _side); i++)
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
                    if (element[i] - LeastVertex[i] <= _side)
                        result[i] = element[i];
                    else result[i] = LeastVertex[i] + _side; 
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
                    if (element[i] - LeastVertex[i] > _side)
                        element[i] = LeastVertex[i] + _side;
            }
        }

        public Vector GetRandomElement(Random accidentFactor)
        {
            Vector result = Vector.CreateVector(LeastVertex.Length);
            for (int i = 0; i < result.Length; i++)            
                result[i] = LeastVertex[i] + accidentFactor.NextDouble() * _side;
            return result;
        }

        public HyperCube(Vector leastVertex, double side)
        {
            if (leastVertex == null)
                throw new ArgumentNullException("leastPoint");

            LeastVertex = leastVertex.Copy();
            Side = side;
        }        
    }
}

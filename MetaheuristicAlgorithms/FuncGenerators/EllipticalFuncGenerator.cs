using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public class EllipticalFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d < 2)
                throw new ArgumentException("d");            
            if (d == 2)
                return (x) => x[0] * x[0] + 1000000d * x[1] * x[1];

            if (d == 3)
            {
                double c = Math.Sqrt(1000000d);
                return (x) => x[0] * x[0] + c * x[1] * x[1] + 1000000d * x[2] * x[2];
            }
            double[] coefs = new double[d];
            coefs[0] = 1d;
            int n = d - 1;
            for (int i = 1; i < n; i++)
                coefs[i] = Math.Pow(1000000d, i / n);
            coefs[n] = 1000000d;
            return (x) =>
            {
                double res = coefs[0] * x[0] * x[0];
                for (int i = 1; i < d; i++)
                    res += coefs[i] * x[i] * x[i];
                return res;
            };
        }
    }    
}

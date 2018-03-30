using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    class SphericalFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                throw new ArgumentException("d");
            if (d == 1)
                return (x) => x[0] * x[0];
            if (d == 2)
                return (x) => x[0] * x[0] + x[1] * x[1];
            if (d == 3)
                return (x) => x[0] * x[0] + x[1] * x[1] + x[2] * x[2];
            return (x) =>
            {
                double res = 0;
                for (int i = 0; i < d; i++)
                    res += x[i] * x[i];
                return res;
            };
        }
    }   
}

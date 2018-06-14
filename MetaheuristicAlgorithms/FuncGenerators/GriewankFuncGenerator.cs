using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public class GriewankFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                return (x) => 1d;
            if (d == 1)
                return (x) => x[0] * x[0] / 4000d - x[0] + 1d;
            if (d == 2)
            {
                double sqrt2 = Math.Sqrt(2d);
                return (x) => (x[0] * x[0] + x[1] * x[1]) / 4000d - x[0] * x[1] / sqrt2 + 1d;
            }
            if (d == 3)
            {
                double sqrt6 = Math.Sqrt(6d);
                return (x) => (x[0] * x[0] + x[1] * x[1] + x[2] * x[2]) / 4000d - x[0] * x[1] * x[2] / sqrt6 + 1d;
            }

            return (x) =>
            {
                double res1 = 0d, res2 = 1d, res3 = 1d;
                for (int i = 0; i < d; i++)
                {
                    res1 += x[i] * x[i];
                    res2 *= x[i];
                    res3 *= i + 1;
                }
                return res1 / 4000d - res2 / Math.Sqrt(res3) + 1d;
            };
        }
    }
}

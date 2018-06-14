using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public class Schwefel1_2FuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                throw new ArgumentException("d");
            if (d == 1)
                return (x) => x[0] * x[0];
            if (d == 2)
                return (x) => x[0] * x[0] + Math.Pow(x[0] + x[1], 2d);
            if (d == 3)
                return (x) => x[0] * x[0] + Math.Pow(x[0] + x[1], 2d) + Math.Pow(x[0] + x[1] + x[2], 2d);

            return (x) =>
            {
                double res = x[0] * x[0],
                       summ = x[0];
                for (int i = 1; i < d; i++)
                {
                    summ += x[i];
                    res += Math.Pow(summ, 2d);
                }
                return res;
            };
        }
    }
}

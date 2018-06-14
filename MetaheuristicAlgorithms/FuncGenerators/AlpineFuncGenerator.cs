using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public class AlpineFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                throw new ArgumentException("d");
            if (d == 1)
                return (x) => Math.Abs(x[0] * Math.Sin(x[0]) + x[0] / 10d);
            if (d == 2)
                return (x) => Math.Abs(x[0] * Math.Sin(x[0]) + x[0] / 10d) + Math.Abs(x[1] * Math.Sin(x[1]) + x[1] / 10d);
            if (d == 3)
                return (x) => Math.Abs(x[0] * Math.Sin(x[0]) + x[0] / 10d) + Math.Abs(x[1] * Math.Sin(x[1]) + x[1] / 10d) + Math.Abs(x[2] * Math.Sin(x[2]) + x[2] / 10d);

            return (x) =>
            {
                double res = 0;
                for (int i = 0; i < d; i++)
                    res += Math.Abs(x[i] * Math.Sin(x[i]) + x[i] / 10d);
                return res;
            };
        }
    }
}

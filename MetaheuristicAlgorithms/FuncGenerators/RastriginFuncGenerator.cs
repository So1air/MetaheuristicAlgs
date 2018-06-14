using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public class RastriginFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                throw new ArgumentException("d");
            if (d == 1)
                return (x) => x[0] * x[0] - 10d * Math.Cos(2 * Math.PI * x[0]) + 10d;
            if (d == 2)
                return (x) => x[0] * x[0] + x[1] * x[1] - 10d * (Math.Cos(2 * Math.PI * x[0]) + Math.Cos(2 * Math.PI * x[1])) + 20d;
            if (d == 3)
                return (x) => x[0] * x[0] + x[1] * x[1] + x[2] * x[2] - 10d * (Math.Cos(2 * Math.PI * x[0]) + Math.Cos(2 * Math.PI * x[1]) + Math.Cos(2 * Math.PI * x[2])) + 30d;

            return (x) =>
            {
                double res = 0;
                for (int i = 0; i < d; i++)
                    res += x[i] * x[i] - 10d * Math.Cos(2 * Math.PI * x[i]);
                res += d * 10;
                return res;
            };
        }
    }
}

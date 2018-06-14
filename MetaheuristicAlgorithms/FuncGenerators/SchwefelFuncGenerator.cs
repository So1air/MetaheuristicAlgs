using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public class SchwefelFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                return (x) => 418.983;
            if (d == 1)
                return (x) => -x[0] * Math.Sin(Math.Sqrt(Math.Abs(x[0]))) + 418.983;
            if (d == 2)
                return (x) => -0.5 * (x[0] * Math.Sin(Math.Sqrt(Math.Abs(x[0]))) + x[1] * Math.Sin(Math.Sqrt(Math.Abs(x[1])))) + 418.983;
            if (d == 3)
                return (x) => (-1d / 3d) * (x[0] * Math.Sin(Math.Sqrt(Math.Abs(x[0]))) + x[1] * Math.Sin(Math.Sqrt(Math.Abs(x[1]))) + x[2] * Math.Sin(Math.Sqrt(Math.Abs(x[2])))) + 418.983;

            return (x) =>
            {
                double res = x[0] * Math.Sin(Math.Sqrt(Math.Abs(x[0])));
                for (int i = 1; i < d; i++)
                    res += x[i] * Math.Sin(Math.Sqrt(Math.Abs(x[i])));
                res /= -d;
                res += 418.983;
                return res;
            };
        }
    }
}

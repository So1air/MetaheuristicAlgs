using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{    
    public class RosenbrockFuncGenerator : IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d < 2)
                throw new ArgumentException("d");
            if (d == 2)
                return (x) => (100d * Math.Pow(x[1] - x[0] * x[0], 2d) + Math.Pow(1 - x[0], 2d));
            if (d == 3)
                return (x) => (100d * (Math.Pow(x[1] - x[0] * x[0], 2d) + Math.Pow(x[2] - x[1] * x[1], 2d)) + Math.Pow(1 - x[0], 2d) + Math.Pow(1 - x[1], 2d));

            return (x) =>
            {
                double res = 100d * Math.Pow(x[1] - x[0] * x[0], 2d) + Math.Pow(1 - x[0], 2d);
                for (int i = d - 1; i > 0; i++)
                    res += 100d * Math.Pow(x[i + 1] - x[i] * x[i], 2d) + Math.Pow(1 - x[i], 2d);
                return res;
            };
        }
    }
}

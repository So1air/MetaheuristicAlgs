using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{    
    class AckleyFuncGenerator : IMultiDimFuncGenerator
    {
        private const double _20plusE = 20d + Math.E,
                             _2PI = 2d * Math.PI;
        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                return (x) => _20plusE;
            if (d == 1)
                return (x) => -20d * Math.Exp(-0.2 * Math.Abs(x[0])) - Math.Exp(Math.Cos(_2PI * x[0])) + _20plusE;
            if (d == 2)
                return (x) => -20d * Math.Exp(-0.2 * Math.Sqrt(0.5 * (x[0] * x[0] + x[1] * x[1]))) - Math.Exp(0.5 * (Math.Cos(_2PI * x[0]) + Math.Cos(_2PI * x[1]))) + _20plusE;
            double _1divide_d = 1d / d;
            if (d == 3)
                return (x) => -20d * Math.Exp(-0.2 * Math.Sqrt(_1divide_d * (x[0] * x[0] + x[1] * x[1] + x[2] * x[2]))) - Math.Exp(_1divide_d * (Math.Cos(_2PI * x[0]) + Math.Cos(_2PI * x[1]) + Math.Cos(_2PI * x[2]))) + _20plusE;

            return (x) =>
            {
                double res1 = 0, res2 = 0;
                for (int i = 0; i < d; i++)
                {
                    res1 += x[i] * x[i];
                    res2 += Math.Cos(_2PI * x[i]);
                }
                return -20d * Math.Exp(-0.2 * Math.Sqrt(_1divide_d * res1)) - Math.Exp(_1divide_d * res2) + _20plusE;
            };
        }
    }
}

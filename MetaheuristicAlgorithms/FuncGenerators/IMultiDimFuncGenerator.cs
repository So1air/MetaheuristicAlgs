using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    interface IMultiDimFuncGenerator
    {
        public Func<Vector, double> GetFunc(ushort d = 2);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{
    public interface IMultiDimFuncGenerator
    {
        Func<Vector, double> GetFunc(ushort d = 2);
    }
}

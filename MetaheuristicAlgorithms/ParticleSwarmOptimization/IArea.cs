using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics
{
    interface IArea<T>
    {
        bool IsContains(T element);
        T Projection(T element);
        void Projection(ref T element);
        T GetRandomElement(Random accidentFactor);       
    }
}

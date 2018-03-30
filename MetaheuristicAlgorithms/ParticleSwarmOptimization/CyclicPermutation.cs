using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    class CyclicPermutation<T> 
    {
        private int[] _permutation;
        private T[] _objects;        

        public T this[int index] 
        {
            get { return _objects[_permutation[index]]; }
        }

        public static CyclicPermutation<T> operator- (CyclicPermutation<T> cp_left, CyclicPermutation<T> cp_right)
        {
            throw new NotImplementedException();
        }
    }
}

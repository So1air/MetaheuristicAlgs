using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    public class PermutationArea/*<TPos>*/ : IArea<Permutation/*<TPos>*/>
    {
        private int _dimensionality; 

        public bool IsContains(Permutation/*<TPos>*/ element)
        {
            return element.Dimension == _dimensionality; //пока так            
        }

        public Permutation/*<TPos>*/ Projection(Permutation/*<TPos>*/ element)
        {
            throw new NotImplementedException();
        }

        public void Projection(ref Permutation/*<TPos>*/ element)
        {
            throw new NotImplementedException();
        }

        public Permutation/*<TPos>*/ GetRandomElement(Random accidentFactor)
        {
            Permutation/*<TPos>*/ res = new Permutation(_dimensionality);
            for (int i = _dimensionality - 1; i > 0 ; i--)            
                res.Swap(i, accidentFactor.Next(0, i));

            return res;
        }
    }
}

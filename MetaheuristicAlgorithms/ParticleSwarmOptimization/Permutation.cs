using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    public class Permutation
    {
        private int[] _permutation;

        public int this[int index] 
        {
            get { return _permutation[index]; }
        }

        public int Dimension
        {
            get { return _permutation.Length; }
        }

        public static int operator-(Permutation l, Permutation r)
        {
            if (l.Dimension != r.Dimension)
                throw new ArgumentException();

            int difference = 0; 
            Permutation t = new Permutation(l);
            for(int i = 0, n = l.Dimension - 1; i < n; i++)  
                if (t[i] != r[i])
                { 
                    difference++;
                    for (int j = i + 1; (t[i] != r[i]) && (j <= n); j++)
                        if (t[j] == r[i])
                            t.Swap(i, j);
                }
            return difference;
        }

        public Permutation MoveTo(Permutation other, Random accidentFactor, double k)
        {                     
            int difference = this - other; 
            int step = (int)(difference * k + 0.5);
 
            if (step >= difference)
            {
                other._permutation.CopyTo(this._permutation, 0);
                for(int n = 0, over = step - difference; n < over; n++)                 
                    this.Swap(accidentFactor.Next(0, this.Dimension), accidentFactor.Next(0, this.Dimension)); 
            }
            else
            {

                int i;
                bool find;
                do
                {
                    i = accidentFactor.Next(0, this.Dimension);
                    if (!(find = this._permutation[i] != other._permutation[i]))
                    {
                        for (int j = i + 1; (!find) && (j < this.Dimension); j++)
                            if (this._permutation[j] != other._permutation[j])
                            {
                                i = j;
                                find = true;
                            }

                        if (!find)
                            for (int j = 0; (!find) && (j < i); j++)
                                if (this._permutation[j] != other._permutation[j])
                                {
                                    i = j;
                                    find = true;
                                }
                    }

                    if (find)
                        for (int j = 0; find && (j < this.Dimension); j++)
                            if (this._permutation[j] == other._permutation[i])
                            {
                                this.Swap(i, j);
                                find = false;
                            }                    
                }
                while (this - other > difference - step);
            }              
                
            return this;
        }

        public void MoveSwap(Random accidentFactor, int v = 1)
        {
            for (int k = 0; k < v; k++)
                this.Swap(accidentFactor.Next(0, this.Dimension), accidentFactor.Next(0, this.Dimension));
        }

        public void MoveInvert(Random accidentFactor, int v = 1)
        {
            for (int k = accidentFactor.Next(0, this.Dimension - v), n = 2 * k + v; k < n / 2; k++)
                this.Swap(k, n - k);            
        }

        public void MoveReplace(Random accidentFactor, int v = 1)
        {
            int beg = accidentFactor.Next(0, this.Dimension - v);
            int beyondEnd = beg + v;
            int pos = accidentFactor.Next(0, this.Dimension - v);
            if (pos != beg)
            {
                int[] m = new int[v];
                for (int k = 0; k < v; k++)
                    m[k] = this._permutation[beg + k];

                int j_i_1 = v + 1;
                if (pos < beg)
                {
                    for (int k = 1; k <= beg - pos; k++)
                        this._permutation[beyondEnd - k] = this._permutation[beg - k];
                    for (int k = 0; k < v; k++)
                        this._permutation[pos + k] = m[k];
                }

                if (pos > beg)
                {
                    
                    for (int k = 0, n = pos - beg; k < n; k++)
                        this._permutation[beg + k] = this._permutation[beyondEnd + k];
                    
                        
                    //for (int k = beg; k < this.Dimension - j_i_1; k++)
                    //    this._permutation[k] = this._permutation[k + j_i_1];
                    //for (int k = this.Dimension - 1; k >= pos + j_i_1; k--)
                    //    this._permutation[k] = this._permutation[k - j_i_1];
                    
                    for (int k = 0; k < v; k++)
                        this._permutation[pos + k] = m[k];
                }
            }
        }

        public double Diversity(Permutation other)
        {
            if (this.Dimension != other.Dimension)
                throw new ArgumentException();

            int div = 0;
            for (int i = 0; i < this.Dimension; i++)            
                if (this._permutation[i] != other._permutation[i])
                    div++;
            return div / (double)this.Dimension; 
        }

        public void Swap(int i, int j)
        {
            int tmp = _permutation[i];
            _permutation[i] = _permutation[j];
            _permutation[j] = tmp;
        }

        public void Reverse(int i, int j)
        {
            if (i > j)
            {
                int tmp = i;
                i = j;
                j = tmp;
            }

            if (i < 0)
                throw new ArgumentOutOfRangeException("i");
            if (j >= this.Dimension)
                throw new ArgumentOutOfRangeException("j");
            for (int k = i, n = i + j; k < n / 2; k++)
                this.Swap(k, n - k);
        }

        public Permutation(int countElements)
        {
            _permutation = new int[countElements];
            for (int i = 0; i < countElements; i++)
                _permutation[i] = i;
        }

        public Permutation(Permutation origin)
        {
            this._permutation = new int[origin.Dimension];
            origin._permutation.CopyTo(this._permutation, 0);
        }
    }
}

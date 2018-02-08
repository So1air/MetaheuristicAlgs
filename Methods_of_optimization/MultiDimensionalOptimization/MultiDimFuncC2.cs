using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegateGenerator;

namespace MultiDimensionalOptimization
{
    class MultiDimFuncC2
    {
        private MultiDimFuncWithText _f;
        private MultiDimFuncWithText[] _grad_f;
        private MultiDimFuncWithText[,] _hessian_f;        

        public MultiDimFuncWithText F { get { return _f; } }
        public MultiDimFuncWithText this[int index] 
        { 
            get { return _grad_f[index]; }
            set 
            { 
                if (value.Dimension != this.Dimension)
                    throw new ArgumentException("Параметр является недопустимым для присвоения: размерность кофликтует с имеющейся функцией.");
                else
                    _grad_f[index] = value;
            }
        }
        public MultiDimFuncWithText this[int index1, int index2] 
        { 
            get { return _hessian_f[index1, index2]; } 
            set 
            {
                if (value.Dimension != this.Dimension)
                    throw new ArgumentException("Параметр является недопустимым для присвоения: размерность кофликтует с имеющейся функцией.");
                else
                    _hessian_f[index1, index2] = value;
            }
        }
        
        public int Dimension { get { return _f.Dimension; } }

        public Func<Vector, double>[] GradF
        {
            get
            {
                Func<Vector, double>[] res = new Func<Vector, double>[this._grad_f.Length];
                for (int i = 0; i < res.Length; i++)
                    res[i] = this._grad_f[i].F;
                return res;
            }
        }

        public Func<Vector, double>[,] HessianF
        {
            get 
            {
                int n = this.Dimension;
                Func<Vector, double>[,] res = new Func<Vector, double>[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        res[i, j] = _hessian_f[i, j].F;

                return res; 
            }
        }

        public override string ToString()
        {
            return _f.ToString();
        }

        public MultiDimFuncC2() //????????????
        {
            _f = new MultiDimFuncWithText();
            _grad_f = new MultiDimFuncWithText[_f.Dimension];
            _hessian_f = new MultiDimFuncWithText[_f.Dimension, _f.Dimension];
            for (int i = 0; i < _f.Dimension; i++)
            {
                _grad_f[i] = new MultiDimFuncWithText();
                for (int j = 0; j < _f.Dimension; j++)
                    _hessian_f[i, j] = new MultiDimFuncWithText();
            }
        }

        public MultiDimFuncC2(string text_func, string[] text_grad_func, string[,] text_hessian_func, int dimension)
        {
            if ((dimension != text_grad_func.Length) && (dimension != text_hessian_func.GetLength(0)) && (dimension != text_hessian_func.GetLength(1)))
                throw new ArgumentException();

            _f = MultiDimFuncWithText.CreateInstance(text_func, dimension);
            _grad_f = new MultiDimFuncWithText[_f.Dimension];
            _hessian_f = new MultiDimFuncWithText[_f.Dimension, _f.Dimension];
            for (int i = 0; i < dimension; i++)
            {
                _grad_f[i] = MultiDimFuncWithText.CreateInstance(text_grad_func[i], dimension);
                for (int j = 0; j < dimension; j++)
                    _hessian_f[i, j] = MultiDimFuncWithText.CreateInstance(text_hessian_func[i, j], dimension);
            }
        }

        public MultiDimFuncC2(MultiDimFuncWithText func, MultiDimFuncWithText[] grad_func, MultiDimFuncWithText[,] hessian_func)
        {
            if ((func.Dimension != grad_func.Length) && (func.Dimension != hessian_func.GetLength(0)) && (func.Dimension != hessian_func.GetLength(1)))
                throw new ArgumentException();

            _f = func;
            _grad_f = new MultiDimFuncWithText[_f.Dimension];
            _hessian_f = new MultiDimFuncWithText[_f.Dimension, _f.Dimension];
            for (int i = 0; i < func.Dimension; i++)
            {                
                _grad_f[i] = grad_func[i];
                for (int j = 0; j < func.Dimension; j++)
                    _hessian_f[i, j] = hessian_func[i, j];
            }
        }
    }
}

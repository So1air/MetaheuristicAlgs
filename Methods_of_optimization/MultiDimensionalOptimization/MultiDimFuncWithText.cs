using System;
using System.Linq;
using MultiDimensionalOptimization;

namespace DelegateGenerator
{
    class MultiDimFuncWithText
    {
        protected static string[] NAME_VAR_FOR_SPLIT = new string[1] { "x[" }; 

        private Func<Vector, double> _f;        
        private string _textf;
        private int _dim;        

        public Func<Vector, double> F
        {
            get { return _f; }            
        }         

        public override string ToString()
        {            
            return _textf;
        }

        public int Dimension
        {
            get { return _dim; }
        }

        public static MultiDimFuncWithText CreateInstance(string textf, int dimension) 
        {
            if (dimension <= 0)
                throw new ArgumentOutOfRangeException("dimension");
            try
            {
                //проверяем строку на соответствие переданному параметру "dimension" 
                if (dimension <= textf.Split(NAME_VAR_FOR_SPLIT, StringSplitOptions.None)
                                      .Where<string>((x, i) => (i != 0))
                                      .Select<string, int>((x) => (int.Parse(x.Split(']')[0])))
                                      .Max())
                    throw new ArgumentException("textf");
            }
            catch (InvalidOperationException)
            {
                if (textf.IndexOf('x') != -1)
                    throw new ArgumentException("textf");
            }
            catch (Exception)
            {
                throw new ArgumentException("textf");
            }

            Func<Vector, double> f = TextToFuncTranslater.CreateMultiDimFuncFromText(textf);
            if (f != null)
                return new MultiDimFuncWithText(textf, f, dimension);
            return null;
        }

        public MultiDimFuncWithText()
        {
            _textf = "0";
            _f = (x) => 0;
            _dim = 1;
        }

        private MultiDimFuncWithText(string textf, Func<Vector, double> f, int dimension)
        {
            _textf = textf;
            _f = f;
            _dim = dimension;
        }
    }
}

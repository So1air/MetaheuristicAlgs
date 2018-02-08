using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class FuncWithText
    {
        private Func<double, double> _f;        
        private string _textf;
        
        public Func<double, double> F
        {
            get { return _f; }            
        }

        public override string ToString()
        {            
            return _textf;
        }

        public static FuncWithText CreateInstance(string textf) 
        {
            Func<double, double> f = TextToFuncTranslater.CreateFuncFromText(textf);
            if (f != null)
                return new FuncWithText(textf, f);

            return null;
        }

        private FuncWithText(string textf, Func<double, double> f)
        {
            _textf = textf;
            _f = f;
        }
    }
}

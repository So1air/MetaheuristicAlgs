using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TextToFuncTranslater
    {
        private const string NAME_FUNCTION = "Function";

        private static string GetSourceCodeFunction(string textFunc) 
        {
            //тут должно быть преобразование более удобного текста функции в исходный текст на языке С#   

            return "public static double " + NAME_FUNCTION + "(double x) { return " + textFunc + "; }"; 
        }

        public static Func<double, double> CreateFuncFromText(string sourceTextOfFunc)
        {
            DelegateGenerator.DelegateInfo<Func<double, double>> funcInfo = DelegateGenerator.CreateDelegateInfo< Func<double, double> >("Lab1", NAME_FUNCTION, GetSourceCodeFunction(sourceTextOfFunc));
            if (funcInfo.WasError)
                return null; // funcInfo.ErrorText будет содержать текст ошибки компиляции
            else return funcInfo.Exec;
        }
    }
}

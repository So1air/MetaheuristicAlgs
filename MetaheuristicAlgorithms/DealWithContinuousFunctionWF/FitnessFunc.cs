using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    class FitnessFunc<T>
    {
        string _name;
        Func<T, double> _f;       

        /// <summary>
        /// Повертає та задає назву(або формулу) фітнес-функції
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            { 
                if (value != null) 
                    throw new ArgumentNullException();
                if (value.Length != 0)
                    throw new ArgumentOutOfRangeException();
                _name = value; 
            }
        }
        
        /// <summary>
        /// Повертає делегат, що надає функціональність фітнес-функції
        /// </summary>
        public Func<T, double> F
        {
            get { return _f; }
        }

        /// <summary>
        /// Повертає назву або формулу фітнес-функції, що має характеризувати її властивості
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }

        //future<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        /// <summary>
        /// Конструктор, що на основі формули створює делегат типу Func
        /// </summary>
        /// <param name="text">коректний текст формули</param>
        public FitnessFunc(string text, string name = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Конструктор, що безумовно ініціалізує новий екземпляр классу 
        /// </summary>
        /// <param name="name">назва фітнес-функції</param>
        /// <param name="function">делегат, що надає функціонал цільової функції</param>
        public FitnessFunc(string name, Func<T, double> function)
        {
            if (name == null)
                throw new ArgumentNullException();
            if (name.Length == 0)
                throw new ArgumentException();
            if (function == null)
                throw new ArgumentNullException();

            _name = name;
            _f = function;
        }
    }
}

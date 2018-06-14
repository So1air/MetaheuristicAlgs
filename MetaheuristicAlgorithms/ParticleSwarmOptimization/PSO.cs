using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{ 
    public enum StepModification
    {
        NoModifications,
        FixedSplitStep,
        RandomSplitStep,
        LocalSearch
    }

    /// <summary>
    /// Набір доступних топологій зв'язків між частками у рої
    /// </summary>
    public enum TopologyLinkages
    {
        /// <summary>
        /// "Зірка" - кожна частка інформується всіма іншими частками
        /// </summary>
        Star,
        /// <summary>
        /// "Кільце" - кожна частка інформується двома сусідніми за індексом частками, причому перша(нульова) й остання частки вважаються сусідніми
        /// </summary>
        Circle,
        /// <summary>
        /// "Випадкові інформатори" - кожна частка може мати відмінну від інших часток та змінну впродовж роботи алгоритму кількість інформаторів серед часток 
        /// рою, але межі зміни кількості регулюються користувачем    
        /// </summary>
        RandomInformants
    }   

    /// <summary>
    /// Класс, що являє собою реалізацію загальної схеми алгоритму оптимізації методом рою часток
    /// </summary>
    /// <typeparam name="TPos">тип елементів простору, у якому вирішується оптимізаційна задача та від яких залежить цільова функція</typeparam>
    public abstract class PSO<TPos, TSpeed>
    {
        protected Random _accidentFactor = new Random();
        protected Swarm<TPos, TSpeed> _currSwarm;
        double _cInertiа = 1d / (2 * Math.Log(2)); //~0.72;
        double _cСognitive = 0.5 + Math.Log(2);//~1.19;
        double _cSocial = 0.5 + Math.Log(2);

        //???????
        double _cGlobal = 0.5 + Math.Log(2);

        public double CGlobal
        {
            get { return _cGlobal; }
            set { _cGlobal = value; }
        }

        double _sizeStep = 1.0;

        public double SizeStep
        {
            get { return _sizeStep; }
            set
            {
                if (0 < value && value <= 1)
                    _sizeStep = value;
            }
        }

        StepModification _stMod = StepModification.NoModifications;

        public StepModification StepModification
        {
            get { return _stMod; }
            set { _stMod = value; }
        }

        byte _countStepLocalSearch = 5;

        public byte CountStepLocalSearch
        {
            get { return _countStepLocalSearch; }
            set { 
                if (value > 1)
                    _countStepLocalSearch = value; 
            }
        }
        //?

        ushort _improvement = 0;

        /// <summary>
        /// Довжина серії успішних ітерацій алгоритму, після якої потрібно змінити зв'язки між частками 
        /// при використанні випадкової топології зв'язків. Якщо має значення 0, то зміна зв'язків 
        /// не відбувається за будь-якої довжини серії. 
        /// </summary>
        public ushort Threshold { set; get; } 
        
        /// <summary>
        /// Коефіцієнт інерції, що регулює вплив поточної швидкості частки на обчислення нової швидкості
        /// </summary>
        public double CInertiа
        {
            get { return _cInertiа; }
            set 
            { 
                if ((0 < value) && (value <= 1))    
                    _cInertiа = value; 
            }
        }
        
        /// <summary>
        /// Коефіцієнт власного досвіду, що регулює вплив найкращої знайденої часткою позиції впродовж її 
        /// "руху" на формування її нової швидкості
        /// </summary>
        public double CСognitive
        {
            get { return _cСognitive; }
            set 
            {   
                if ((1 < value) && (value <= 2))
                    _cСognitive = value; 
            }
        } 
        
        /// <summary>
        /// Коефіцієнт досвіду інформаторів, що регулює вплив найкращої знайденої інформаторами позиції 
        /// впродовж їх "руху" на формування нової швидкості частки
        /// </summary>
        public double CSocial
        {
            get { return _cSocial; }
            set
            {
                if ((1 < value) && (value <= 2))
                    _cSocial = value; 
            }
        }

        /// <summary>
        /// Номер поточної ітерації
        /// </summary>
        public int Iteration { protected set; get; }

        /// <summary>
        /// Кількість часток у рої
        /// </summary>
        public int SizeSwarm
        {
            get { return _currSwarm.Size; }
        }

        /// <summary>
        /// Здійснює count наступних ітерацій
        /// </summary>
        /// <param name="count">кількість ітерацій, яку необхідно здійснити(за замовчуванням 1)</param>
        public virtual void NextIteration(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                if (_currSwarm.Move(ModifyMethod))
                    _improvement++;
                else
                    switch (_currSwarm.Topology)
                    {
                        case TopologyLinkages.RandomInformants:
                            _currSwarm.ResetInformants(this._accidentFactor);
                            _improvement = 0;
                            break;
                        default:
                            break;
                    }

                if ((Threshold != 0) && (_improvement >= Threshold))
                {
                    switch (_currSwarm.Topology)
                    {
                        case TopologyLinkages.RandomInformants:
                            _currSwarm.ResetInformants(this._accidentFactor);
                            _improvement = 0;
                            break;
                        default:
                            break;
                    }
                }
                _currSwarm.Communication();
            }
        }

        public TPos CurrentSolution
        {
            get { return _currSwarm.BestPosition; }
        }

        public double ValueFitnessCurrentSolution
        {
            get { return _currSwarm.BestFitness; } 
        }

        /// <summary>
        /// Змінює швидкість та позицію переданої частки
        /// </summary>
        /// <param name="particleForModify">частка, яку треба змінити</param>
        /// <param name="ranges">допустима область, в межах якої мають выдбуватися зміни</param>
        public abstract void ModifyMethod(Particle<TPos, TSpeed> particleForModify, IArea<TPos> ranges);      

        /// <summary>
        /// Конструктор, що конфігурує метод існуючим роєм  
        /// </summary>
        /// <param name="swarm">існуючий рій</param>
        public PSO(Swarm<TPos, TSpeed> swarm)
        {
            if (swarm == null)
                throw new ArgumentNullException("swarm");

            _currSwarm = swarm;
            Iteration = 0;
        }
    }
}

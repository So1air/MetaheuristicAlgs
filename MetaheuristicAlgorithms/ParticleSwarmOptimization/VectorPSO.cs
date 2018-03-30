using MultiDimensionalOptimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    /// <summary>
    /// Клас-реалізації алгоритму неперервної оптимізації роєм часток
    /// </summary>
    class VectorPSO : PSO<Vector>
    {
        /// <summary>
        /// Змінює швидкість та позицію переданої частки
        /// </summary>
        /// <param name="particleForModify">частка, яку треба змінити</param>
        /// <param name="ranges">допустима область, в межах якої мають выдбуватися зміни</param>
        public virtual override void Tweak(Particle<Vector> particleForModify, IArea<Vector> ranges)
        {            
            double[] randNumbers = new double[particleForModify.CurrPosition.Length];
            for (int i = randNumbers.Length; i > 0; i--)
                randNumbers[i] = _accidentFactor.NextDouble();
            particleForModify.CurrSpeed = CInertiа * particleForModify.CurrSpeed + CСognitive * (randNumbers * (particleForModify.PersonalBest - particleForModify.CurrPosition));
            if (particleForModify.PersonalBest != particleForModify.InformantBest.PersonalBest)
            {
                //исправление соответствующее книге
                //for (int i = randNumbers.Length; i > 0; i--) //?
                //    randNumbers[i] = _accidentFactor.NextDouble();
                particleForModify.CurrSpeed += CSocial * (randNumbers * (particleForModify.InformantBest.PersonalBest - particleForModify.CurrPosition));
            }
            //???????????????
            if ((CGlobal != 0) && (particleForModify.InformantBest.PersonalBest != _currSwarm.BestPosition))
            {
                //исправление соответствующее книге
                //for (int i = randNumbers.Length; i > 0; i--)  //?
                //    randNumbers[i] = _accidentFactor.NextDouble();
                particleForModify.CurrSpeed += CGlobal * (randNumbers * (_currSwarm.BestPosition - particleForModify.CurrPosition));
            }
            //?
            particleForModify.CurrPosition = particleForModify.CurrPosition + SizeStep * particleForModify.CurrSpeed;
            Vector legalPosition = ranges.Projection(particleForModify.CurrPosition);
            for (int i = 0; i < legalPosition.Length; i++)
                if (legalPosition[i] != particleForModify.CurrPosition[i])
                    particleForModify.CurrSpeed[i] = 0;
            particleForModify.CurrPosition = legalPosition;
        }
    }
}

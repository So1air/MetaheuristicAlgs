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
    public class VectorPSO : PSO<Vector, Vector>
    {
        /// <summary>
        /// Змінює швидкість та позицію переданої частки
        /// </summary>
        /// <param name="particleForModify">частка, яку треба змінити</param>
        /// <param name="ranges">допустима область, в межах якої мають выдбуватися зміни</param>
        public override void ModifyMethod(Particle<Vector, Vector> particleForModify, IArea<Vector> ranges)
        {            
            double[] randNumbers = new double[particleForModify.CurrPosition.Length];
            for (int i = randNumbers.Length; i > 0; i--)
                randNumbers[i] = _accidentFactor.NextDouble();
            particleForModify.CurrSpeed = CInertiа * particleForModify.CurrSpeed + CСognitive * (randNumbers * (particleForModify.PersonalBest - particleForModify.CurrPosition));
            if (particleForModify.PersonalBest != particleForModify.InformantBest.PersonalBest)
            {
                for (int i = randNumbers.Length; i > 0; i--)
                    randNumbers[i] = _accidentFactor.NextDouble();
                particleForModify.CurrSpeed += CSocial * (randNumbers * (particleForModify.InformantBest.PersonalBest - particleForModify.CurrPosition));
            }

            //???????????????
            if ((CGlobal != 0) && (particleForModify.InformantBest.PersonalBest != _currSwarm.BestPosition))
            {
                for (int i = randNumbers.Length; i > 0; i--) 
                    randNumbers[i] = _accidentFactor.NextDouble();
                particleForModify.CurrSpeed += CGlobal * (randNumbers * (_currSwarm.BestPosition - particleForModify.CurrPosition));
            }
            //?

            switch (StepModification)
            {
                case BehavioralAlgs.StepModification.NoModifications:
                    particleForModify.CurrPosition = particleForModify.CurrPosition + particleForModify.CurrSpeed;
                    break;
                case BehavioralAlgs.StepModification.FixedSplitStep:
                    particleForModify.CurrPosition = particleForModify.CurrPosition + ((SizeStep != 1) ? SizeStep * particleForModify.CurrSpeed : particleForModify.CurrSpeed);
                    break;
                case BehavioralAlgs.StepModification.RandomSplitStep:
                    particleForModify.CurrPosition = particleForModify.CurrPosition + (_accidentFactor.NextDouble() - 0.5) * particleForModify.CurrSpeed;
                    break;
                case BehavioralAlgs.StepModification.LocalSearch:
                    Vector candidatSolution;
                    double fitnessOfCandidat,
                           localBest = _currSwarm.FitnessFunc(particleForModify.CurrPosition += (-CountStepLocalSearch / 2.0) * particleForModify.CurrSpeed);
                    for (double m = -CountStepLocalSearch / 2.0 + 1; m <= CountStepLocalSearch / 2.0; m++)
                        /*???*/
                        if ((_currSwarm.SearchDirection) ?
                             (fitnessOfCandidat = _currSwarm.FitnessFunc(candidatSolution = particleForModify.CurrPosition + m * particleForModify.CurrSpeed))
                             > localBest
                             : (fitnessOfCandidat = _currSwarm.FitnessFunc(candidatSolution = particleForModify.CurrPosition + m * particleForModify.CurrSpeed))
                             < localBest)
                        {
                            localBest = fitnessOfCandidat;
                            particleForModify.CurrPosition = candidatSolution;
                        }
                    break;
                default:
                    throw new NotImplementedException();
            }

            Vector legalPosition = ranges.Projection(particleForModify.CurrPosition);
            for (int i = 0; i < legalPosition.Length; i++)
                if (legalPosition[i] != particleForModify.CurrPosition[i])
                    particleForModify.CurrSpeed[i] = 0;
            particleForModify.CurrPosition = legalPosition;
        }

        /// <summary>
        /// Конструктор, що конфігурує метод існуючим роєм та ініціалізує швидкості часток
        /// </summary>
        /// <param name="swarm">існуючий рій</param>
        public VectorPSO(Swarm<Vector, Vector> swarm)
            :base(swarm)
        {
            //инициализация начальных скоростей
            for (int i = 0; i < _currSwarm.Size; i++)
                _currSwarm[i].CurrSpeed = 0.5 * (_currSwarm.Areal.GetRandomElement(_accidentFactor) - _currSwarm[i].CurrPosition);
        }
    }

    
}

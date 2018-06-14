using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    public class PermutationPSO : PSO<Permutation, double>
    {
        const double THIRD = 1.0 / 3.0;
        
        //КОСТЫЛЬ
        protected int _counterChangeParticles;
        private double _diversity;

        //private double _w = 0.995; //коефіцієнт гасіння швидкості
        private double _thresholdDiversity = 0.4;

        //public double W
        //{
        //    get { return _w; }
        //    set 
        //    { 
        //        if ((value > 0) && (value <= 1))
        //            _w = value; 
        //    }
        //}

        public int Dimension
        {
            get { return _currSwarm[0].CurrPosition.Dimension; }  //??????????????????????????????????????
        }

        //КОСТЫЛЬ
        protected void Diversity(double div)
        {
            if (_counterChangeParticles == _currSwarm.Size)
            {
                _counterChangeParticles = 1;
                _diversity = div;
            }
            else
            {
                _counterChangeParticles++;
                _diversity += div;
                if (_counterChangeParticles == _currSwarm.Size)                
                    _diversity /= _currSwarm.Size;               
            }
        }

        public double DiversitySwarm
        {
            get
            {
                if (_counterChangeParticles == _currSwarm.Size)
                    return _diversity;
                else
                {
                    double diversity = 0;
                    for (int i = 0; i < _currSwarm.Size; i++)                    
                        diversity += THIRD * (_currSwarm[i].CurrPosition.Diversity(_currSwarm[i].PersonalBest) 
                                              + _currSwarm[i].CurrPosition.Diversity(_currSwarm[i].InformantBest.PersonalBest) 
                                              + _currSwarm[i].PersonalBest.Diversity(_currSwarm[i].InformantBest.PersonalBest));
                    return diversity / _currSwarm.Size;
                }
            }
        }

        public override void ModifyMethod(Particle<Permutation, double> particleForModify, IArea<Permutation> ranges)
        {
            particleForModify.CurrPosition.MoveTo(particleForModify.PersonalBest, _accidentFactor, _accidentFactor.NextDouble() * CСognitive);
            particleForModify.CurrPosition.MoveTo(particleForModify.InformantBest.PersonalBest, _accidentFactor, _accidentFactor.NextDouble() * CSocial);
            

            double div = THIRD *(particleForModify.CurrPosition.Diversity(particleForModify.PersonalBest) 
                                       + particleForModify.CurrPosition.Diversity(particleForModify.InformantBest.PersonalBest) 
                                       + particleForModify.PersonalBest.Diversity(particleForModify.InformantBest.PersonalBest)); 
            if (div > 1)  
                particleForModify.CurrSpeed = CInertiа * particleForModify.CurrSpeed; 

            double r = _accidentFactor.Next(); 
            if (r < THIRD) 
                particleForModify.CurrPosition.MoveSwap(_accidentFactor, (int)(particleForModify.CurrSpeed * this.Dimension + 0.5)); 
            else
                if ((r >= THIRD) && (r < 2 * THIRD))
                    particleForModify.CurrPosition.MoveInvert(_accidentFactor, (int)(particleForModify.CurrSpeed * this.Dimension + 0.5)); 
                else
                    if (r >= 2 * THIRD)
                        particleForModify.CurrPosition.MoveReplace(_accidentFactor, (int)(particleForModify.CurrSpeed * this.Dimension + 0.5)); 
            
            //КОСТЫЛЬ
            this.Diversity(div);
            if (_counterChangeParticles == _currSwarm.Size)
                if (DiversitySwarm < _thresholdDiversity)
                    for (int i = 0; i < _currSwarm.Size; i++)                    
                        _currSwarm[i].CurrSpeed = _accidentFactor.NextDouble(); 
                    //может лучше скорость сделать типом int                     
                        //_currSwarm[i].CurrSpeed = _accidentFactor.Next(1, this.Dimension);
        }

        /// <summary>
        /// Конструктор, що конфігурує метод існуючим роєм та ініціалізує швидкості часток
        /// </summary>
        /// <param name="swarm">існуючий рій</param>
        public PermutationPSO(Swarm<Permutation, double> swarm)
            :base(swarm)
        {
            for (int i = 0; i < _currSwarm.Size; i++)
                _currSwarm[i].CurrSpeed = _accidentFactor.NextDouble();
            //??????????????????
            CInertiа = 0.995f;
        }
    }
}

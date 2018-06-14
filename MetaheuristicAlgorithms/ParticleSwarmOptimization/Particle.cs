using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    public class Particle<TPos, TSpeed>
    {
        TPos _currPosition;
        double _valueFitness;
        TSpeed _currSpeed;
        TPos _personalBest;
        double _fitnessBest;
        List<Particle<TPos, TSpeed>> _informants = new List<Particle<TPos, TSpeed>>();
        Particle<TPos, TSpeed> _informantBest;

        public TPos CurrPosition
        {
            get { return _currPosition; }
            set { _currPosition = value; }
        }

        public double ValueFitness
        {
            get { return _valueFitness; }
            set { _valueFitness = value; }
        }

        public TSpeed CurrSpeed
        {
            get { return _currSpeed; }
            set { _currSpeed = value; }
        }

        public TPos PersonalBest
        {
            get { return _personalBest; }
            set { _personalBest = value; }
        }

        public Particle<TPos, TSpeed> this[int index]
        {
            get { return _informants[index]; }
            //set
            //{
            //    if ((value != this) && (!_informants.Contains(value)))
            //        _informants[index] = value;
            //}
        }

        public int CountInformants
        {
            get { return _informants.Count; }
        }

        public Particle<TPos, TSpeed> InformantBest
        {
            get { return _informantBest; }
            set
            {
                //исправление соответсвующее книге
                if (/*(value == this) ||*/ _informants.Contains(value))
                    _informantBest = value;
            }
        }

        public double FitnessBest
        {
            get { return _fitnessBest; }
            set
            {
                /*if (_fitnessBest < value)
                {
                    ChangePersonalBest(this);*/
                _fitnessBest = value;
                /*}*/
            }
        }

        public void DeleteInformants()
        {
            _informants.Clear();
            //потрібно скинути всі посилання на методи у події
            //ChangePersonalBest.
        }

        public bool AddInformant(Particle<TPos, TSpeed> newInformant)
        {
            if ((newInformant != null) && (!_informants.Contains(newInformant)))
            {
                _informants.Add(newInformant);
                /**/
                /*newInformant.ChangePersonalBest += NewBestInformant;*/
                return true;
            }
            else
                return false;
        }

        //було б гарним рішенням, але виникають дві проблеми:
        //   1) частинка не знає кращий напрямок пошуку(можна якось костильно розв'язати);
        //   2) використання оновленої інформації на поточній ітерації схожа з методом Зейделя(проконсультуватись, можливо так теж підійде). 
        /*
        public event Action<Particle<TPos, TSpeed>> ChangePersonalBest;

        private void NewBestInformant(Particle<TPos, TSpeed> sender)
        {
            if (sender._fitnessBest > this._informantBest._fitnessBest)
                this.InformantBest = sender;         
        }
        */
    }
}

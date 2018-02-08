using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    class Particle<T>
    {
        T _currPosition;
        double _valueFitness; 
        T _currSpeed;
        T _personalBest;               
        double _fitnessBest;
        List<Particle<T>> _neighbors;
        Particle<T> _neighborBest;

        public T CurrPosition
        {
            get { return _currPosition; }
            set { _currPosition = value; }
        }    

        public double ValueFitness
        {
            get { return _valueFitness; }
            set { _valueFitness = value; }
        }

        public T CurrSpeed
        {
            get { return _currSpeed; }
            set { _currSpeed = value; }
        }
        
        public T PersonalBest
        {
            get { return _personalBest; }
            set { _personalBest = value; }
        }        

        public Particle<T> this[int index]
        {
            get { return _neighbors[index]; }
            set
            {
                if ((value != this) && (!_neighbors.Contains(value)))
                    _neighbors[index] = value;
            }
        }        

        internal Particle<T> NeighborBest
        {
            get { return _neighborBest; }
            set 
            {
                if (_neighbors.Contains(value))
                    _neighborBest = value; 
            }
        }                
        
        public double FitnessBest
        {
            get { return _fitnessBest; }
            set { _fitnessBest = value; }
        }

        public Particle(T position)
        {
        }
    }
}

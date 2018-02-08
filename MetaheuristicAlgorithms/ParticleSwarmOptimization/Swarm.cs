using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    class Swarm<T>
    {
        public const ushort MinSizePopulation = 1;

        Particle<T>[] _population;
        Particle<T> _bestIndividual;
        IArea<T> _areal;
        Func<T, double> _fitness;

        public bool SearchDirection { protected set; get; }

        public Particle<T> BestIndividual { get { return _bestIndividual; } }

        public int Size { get { return _population.Length; } }

        public Swarm(Func<T, double> fitnessFunction, IArea<T> areal, ushort sizePopulation, bool max, TopologyLinkages topology, params object[] topologyOptions)
        {
            if (fitnessFunction == null)
                throw new ArgumentNullException("fitnessFunction");

            if (areal == null)
                throw new ArgumentNullException("areal");

            if (sizePopulation < Swarm<T>.MinSizePopulation)
                throw new ArgumentOutOfRangeException("sizePopulation");

            _population = new Particle<T>[sizePopulation];

        }
    }
}

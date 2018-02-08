using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metaheuristics.PopulationAlgs.BehavioralAlgs
{
    enum TopologyLinkages
    {
        Star,
        Circle,
        RandomDraft
    }   

    abstract class PSO<T>
    {
        Random _accidentFactor = new Random();
        byte _minCountNeighbors;
        byte _maxCountNeighbors;
        Swarm<T> _currSwarm;
        float _cInertiа = (float)(1d / (2 * Math.Log(2))); //~0.72f;
        float _cСognitive = (float)(0.5 + Math.Log(2));//~1.19f;
        float _cSocial = (float)(0.5 + Math.Log(2));
        ushort _improvement = 0;
        //bool _relink = true;

        public TopologyLinkages Topology { private set; get; }

        public ushort Threshold { set; get; } 
        
        public float CInertiа
        {
            get { return _cInertiа; }
            set 
            { 
                if ((0 < value) && (value <= 1))    
                    _cInertiа = value; 
            }
        }
        
        public float CСognitive
        {
            get { return _cСognitive; }
            set 
            {   
                if ((1 < value) && (value <= 2))
                    _cСognitive = value; 
            }
        } 
        
        public float CSocial
        {
            get { return _cSocial; }
            set
            {
                if ((1 < value) && (value <= 2))
                    _cSocial = value; 
            }
        }

        public int Iteration { protected set; public get; }

        public int SizeSwarm
        {
            get { return _currSwarm.Size; }
        }


    }
}

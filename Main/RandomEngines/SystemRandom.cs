using RNG.Base;
using System;

namespace RNG.RandomEngines
{
    public class SystemRandom : IDeterministicRandom
    {
        private double _value;
        public double Value => _value;

        private readonly int _seed = 0;
        public int Seed => _seed;

        private uint _count;
        public int Count => (int)_count;

        private Random _rand;

        public SystemRandom()
        {
            _seed = (int)DateTime.Now.Ticks;
            _rand = new Random(_seed);
        }

        public SystemRandom(int seed)
        {
            _seed = seed;
            _rand = new Random(seed);
        }

        public double Next()
        {
            _count++;
            _value = _rand.NextDouble();
            return _value;
        }
    }
}
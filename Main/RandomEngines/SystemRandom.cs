using RNG.Base;

namespace RNG.RandomEngines;

public class SystemRandom : System.Random, IDeterministicRandom
{
    private double _value;
    public double Value => _value;

    private int _seed = 0;
    public int Seed => _seed;

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
        _value = _rand.NextDouble();
        return _value;
    }
}
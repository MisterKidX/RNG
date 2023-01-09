using RNG.Base;

namespace RNG.RandomCollections;

public abstract class RandomCollection : IRandomCollection
{
    protected IRandom _random;

    IRandom IRandomCollection._random => _random;
}

public interface IRandomCollection
{
    protected IRandom _random { get; }
}
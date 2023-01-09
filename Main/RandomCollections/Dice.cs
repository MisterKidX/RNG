using RNG.Base;
using RNG.Utility.Extensions;

namespace RNG.RandomCollections;

public class Dice<T> : RandomCollection
{
    T[] _sides;

    public Dice(int sides, IRandom random) : this(new T[sides], random)
    {
        
    }

    public Dice(T[] values, IRandom random)
    {
        if (random == null)
            throw new ArgumentNullException(nameof(random));

        _sides = values;
        _random = random;
    }

    public T Roll()
    {
        _random.Next();
        return _random.RandomElement(_sides);
    }
}
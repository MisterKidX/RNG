using RNG.Base;
using RNG.Utility.Extensions;

namespace RNG.RandomCollections;

public class Deck<T> : RandomCollection
{
    Stack<T> _cards;

    public Deck(int sides, IRandom random) : this(new T[sides], random)
    {

    }

    public Deck(T[] values, IRandom random)
    {
        if (random == null)
            throw new ArgumentNullException(nameof(random));

        _cards = new Stack<T>(values);
        _random = random;
    }

    public void Shuffle()
    {
        _cards = new Stack<T>(_cards.Shuffle(_random));
    }

    public T Pull()
    {
        return _cards.Pop();
    }
}
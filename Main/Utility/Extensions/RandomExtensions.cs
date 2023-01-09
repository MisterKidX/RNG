using RNG.Base;

namespace RNG.Utility.Extensions;

public static class RandomExtensions
{
    /// <summary>
    /// Creates a new integer within the specified range 
    /// </summary>
    /// <param name="random"> the random provider. Will not call Next().</param>
    /// <param name="range"> the range, minima being 0 (inclusive), maxima being range (exclusive). Can be negative. </param>
    /// <returns> returns an integer within the specified range </returns>
    public static int Range(this IRandom random, int range)
    {
        return (int)(random.Value * range);
    }

    /// <summary>
    /// returns a random element within the <paramref name="array"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="random"></param>
    /// <param name="array"></param>
    /// <returns></returns>
    public static T RandomElement<T>(this IRandom random, T[] array)
    {
        return array[random.Range(array.Length)];
    }
}
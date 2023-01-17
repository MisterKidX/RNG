using RNG.Base;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RNG.Utility.Extensions
{
    public static class EnumerablesExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> enumerable, IRandom rng)
        {
            var sequence = enumerable.ToArray();
            var indices = EnumerablesRandomUtility.GenerateRandomNonRepeatableSequence(sequence.Length, rng).ToArray();

            for (int i = 0; i < sequence.Length; i++)
            {
                yield return sequence[indices[i]];
            }
        }
    }
}
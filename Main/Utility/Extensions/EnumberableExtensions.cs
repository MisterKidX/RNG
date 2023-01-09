using RNG.Base;
using System.Collections;

namespace RNG.Utility.Extensions
{
    public static class EnumerablesExtensions
    {
        //public static T ChooseRandom<T>(this IEnumerable<T> enumerable, IRandom rng)
        //{
        //    if (enumerable == null || !enumerable.GetEnumerator().MoveNext())
        //        return default(T);

        //    var count = enumerable.Count();

        //}

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
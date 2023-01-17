
using RNG.Base;
using RNG.RandomEngines;
using RNG.Utility.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace RNG.Utility
{
    public static class EnumerablesRandomUtility
    {
        public static IRandom Random { get; set; }

        static EnumerablesRandomUtility()
        {
            Random = new SystemRandom();
        }

        public static IEnumerable<int> GenerateRandomNonRepeatableSequence(int size, IRandom random = null)
        {
            if (random == null)
                random = Random;

            var enumerable = Enumerable.Range(0, size);
            var list = new List<int>(enumerable);

            while (list.Count > 0)
            {
                var index = random.Range(list.Count);
                var item = list[index];
                list.RemoveAt(index);

                yield return item;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class KidsWithTheGreatestNumberOfCandies_1431
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> Result = new List<bool> { };
            var max = candies.Max();

            foreach (var c in candies) Result.Add(c + extraCandies >= max);
            
            return Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class DistributeCandies_575
    {
        public static int DistributeCandies(int[] candies)
        {
            return Math.Min(candies.Count() / 2, candies.Distinct().Count());

            //return (candies.Count() /2 >= candies.Distinct().Count() ) 
            //        ? candies.Distinct().Count() 
            //        : candies.Count()/2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class DistanceBetweenBusStops_1184
    {
        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int liMin = Math.Min(start, destination);
            int liMax = Math.Max(start, destination);

            int liSumOfMax = distance.Skip(liMin).Take(liMax - liMin).Sum();

            return Math.Min(liSumOfMax, distance.Sum() - liSumOfMax);

        }
    }
}

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
            int liMin = 0;
            int liMax = 0;

            if (start < destination)
            {
                liMin = start;
                liMax = destination;
            }
            else
            {
                liMin = destination;
                liMax = start;
            }

            int liSumOfMax = distance.Skip(liMin).Take(liMax - liMin).Sum();

            return Math.Min(liSumOfMax, distance.Sum() - liSumOfMax);

        }
    }
}

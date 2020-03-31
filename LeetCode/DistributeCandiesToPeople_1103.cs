using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DistributeCandiesToPeople_1103
    {
        public static int[] DistributeCandies(int candies, int num_people)
        {
            var Final = new int[num_people];
            var counter = 1;
            var index = 0;
            while (counter<candies)
            {
                //if (index == num_people) index = 0;
                Final[index] += counter;
                candies -= counter;
                counter++;
                index = (index + 1) % num_people;
            }
            //if (index == num_people) index = 0;
            Final[index] += candies;
            return Final;
        }
    }
}

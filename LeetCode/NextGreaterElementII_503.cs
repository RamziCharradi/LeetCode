using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NextGreaterElementII_503
    {
        public static int[] NextGreaterElements(int[] nums)
        {
            var Result = new int[nums.Length];
            var circular = new List<int>() { };
            circular.AddRange(nums);
            circular.AddRange(nums);
            for (int i = 0; i < nums.Length ; i++)
            {
                var counter = i+1;
                var exist = false;
                while (counter < nums.Length + i)
                {
                    if (nums[i] < circular[counter])
                    {
                        Result[i] = circular[counter];
                        exist = true;
                        break;
                    }
                    counter++;
                }
                if (!exist) Result[i] = -1;
            }

            return Result;

        }
    }
}

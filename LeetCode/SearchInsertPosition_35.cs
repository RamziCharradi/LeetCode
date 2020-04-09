using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class SearchInsertPosition_35
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int Result = 0;
            while (Result < nums.Length)
            {
                if (nums[Result] >= target) return Result;
                Result++;
            }
            return Result;
        }
    }
}

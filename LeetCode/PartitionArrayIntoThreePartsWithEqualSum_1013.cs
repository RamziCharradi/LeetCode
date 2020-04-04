using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class PartitionArrayIntoThreePartsWithEqualSum_1013
    {
        public static bool CanThreePartsEqualSum(int[] A)
        {
            int totalSum = A.Sum();
            if (totalSum % 3 != 0)
            {
                return false;
            }
            int targetSum = totalSum / 3;
            int currentSum = 0;
            int reachCount = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                currentSum += A[i];
                if (currentSum == targetSum)
                {
                    reachCount++;
                    currentSum = 0;
                }
            }
            return reachCount >= 3;
        }
    }
}

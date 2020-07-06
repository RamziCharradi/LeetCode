using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ArithmeticProgressionFromSequence_1502
    {
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            var ans = true;
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] - arr[i-1] != diff)
                {
                    ans = false;
                    break;
                }
            }
            return ans;

            /**** c++ *****
             
            sort(arr.begin(), arr.end());
            int diff = arr[1] - arr[0];
            bool ans = true;
            for (int i = 1; i < arr.size(); i++)
            {
                if (arr[i] - arr[i - 1] != diff)
                {
                    ans = false;
                    break;
                }
            }
            return ans;
            */

        }
    }
}

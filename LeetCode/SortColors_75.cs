using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SortColors_75
    {
        public void SortColors(int[] nums)
        {

            int[] counts = new int[3];
            foreach (int x in nums)
            {
                counts[x]++;
            }


            for (int i = 0; i < nums.Length; i++)
            {
                if (i < counts[0]) nums[i] = 0;
                else if (i < counts[0] + counts[1]) nums[i] = 1;
                else nums[i] = 2;
            }

            /****** c++ *******

            int counts [3];
        
            for (int x : nums)
            {
                counts[x]++;
            }

            
            for (int i = 0; i < nums.size() ; i++)
            {
                if (i < counts[0]) nums[i] = 0;
                else if(i< counts[0] + counts[1]) nums[i] = 1;
                else nums[i] = 2;
            }


            */
        }
    }
}

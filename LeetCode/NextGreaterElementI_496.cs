using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NextGreaterElementI_496
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                var index = Array.IndexOf(nums2, nums1[i]) + 1 ;
                bool exist = false; 
                while(index< nums2.Length)
                {
                    if (nums1[i] < nums2[index]) 
                    {
                        result[i] = nums2[index];
                        exist = true;
                        break;
                    } 
                    index++;
                }
                if (!exist) result[i] = -1;
            }
            return result;
        }
    }
}

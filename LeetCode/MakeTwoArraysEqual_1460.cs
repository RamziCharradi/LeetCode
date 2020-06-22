using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MakeTwoArraysEqual_1460
    {
        public static bool CanBeEqual(int[] target, int[] arr)
        {
            return target.OrderBy(x => x).SequenceEqual(arr.OrderBy(x => x));

        }
    }
}

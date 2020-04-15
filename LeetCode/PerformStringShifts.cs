using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class PerformStringShifts
    {
        public static string StringShift(string s, int[][] shift)
        {
            List<char> l = s.ToList();

            foreach (var direction in shift)
            {
                int i = 0;
                while (i < direction[1])
                {
                    Shift(l, direction[0]);
                    i++;
                }

            }

            return new String(l.ToArray());
        }

        public static void Shift(List<char> list, int direction)
        {
            
            if(direction == 0)
            {
                //abc
                char c = list[0];
                list.RemoveAt(0);
                list.Add(c);
                //bca
            }
            else
            {
                char c = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, c);
            }
        }

    }
}

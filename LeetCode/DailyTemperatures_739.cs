using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DailyTemperatures_739
    {
        public static int[] DailyTemperatures(int[] T)
        {
            var result = new int[T.Length];
            for (int i = 0; i < T.Length; i++)
            {
                var x = i + 1;
                var exist = false;
                var counter = 0;
                while (x < T.Length)
                {
                    counter++;
                    if (T[x] > T[i]) 
                    {
                        result[i] = counter;
                        exist = true;
                        break;
                    }
                    x++;
                }
                if (!exist) result[i] = 0;
            }

            return result;
        }
    }
}

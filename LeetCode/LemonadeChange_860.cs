using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LemonadeChange_860
    {
        public static bool LemonadeChange(int[] bills)
        {
            Dictionary<int, int> d = new Dictionary<int, int> { { 5, 0 }, { 10, 0 } };
            foreach (var b in bills)
            {
                if (b == 5) d[5]++;
                
                if (b == 10)
                {
                    if (d[5] == 0) return false;
                    else
                    {
                        d[5]--;
                        d[10]++;
                    }
                }
                if(b == 20)
                {
                    if (d[10] == 0)
                    {
                        if (d[5] < 3) return false;
                        else
                        {
                            d[5]-=3;
                        }
                    }
                    else
                    {
                        if (d[5] == 0) return false;
                        else
                        {
                            d[5]--;
                            d[10]--;
                        }
                    }
                }
            }
            return true;
            
        }
    }
}

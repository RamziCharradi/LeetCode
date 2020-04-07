using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class XOfAKindInADeckOfCards_914
    {
        public static bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> d = deck.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            if (d.ContainsValue(1))
            {
                return false;
            }
            else
            {
                
                var gcd = d.Values.Min();
                foreach (var x in d.Values.Distinct())
                {
                    gcd = GCD(x, gcd);

                }

                return gcd > 1;
            }

            
        }

        static int GCD(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
   public class RevealCardsInIncreasingOrder_950
    {
        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            Array.Reverse(deck);

            Queue<int> q = new Queue<int>();

            foreach (var x in deck)
            {
                if (q.Count == 0) q.Enqueue(x);
                else
                {
                    int aux = q.Dequeue();
                    q.Enqueue(aux);
                    q.Enqueue(x);
                }
            }

            return q.Reverse().ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BestTimetoBuyAndSellStock_121
    {
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            int current;
            int min = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                current = prices[i];
                min = Math.Min(current, min);
               
                if (current > min) 
                {
                    profit = Math.Max(profit, current - min);
                } 
            }

            return profit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FinalPricesWithASpecialDiscountInAShop_1475
    {
        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] -= prices[j];
                        break;
                    }
                }
              
            }
            return prices;

        }
    }
}

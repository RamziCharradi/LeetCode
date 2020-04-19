﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MinimumPathSum_64
    {
        public static int MinPathSum(int[][] grid)
        {
            var n = grid.Length;
            if (n == 0) return 0;
            var m = grid[0].Length;

            var dp = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0) dp[i, j] = grid[i][j];
                    else if (i == 0) dp[i, j] = dp[i,j - 1] + grid[i][j];
                    else if (j == 0) dp[i, j] = dp[i - 1,j] + grid[i][j];
                    else dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                }
            }

            return dp[n - 1, m - 1];
        }
    }
}

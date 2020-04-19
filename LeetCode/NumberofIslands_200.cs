using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class NumberofIslands_200
    {
        public static int NumIslands(char[][] grid)
        {
            int island = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        Helper(grid, i, j);

                        island++;
                    }
                    
                }
            }

            return island;
        }

        public static void Helper(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return;
            }
            grid[i][j] = '0';

            Helper(grid, i + 1, j);
            Helper(grid, i - 1, j);
            Helper(grid, i, j + 1);
            Helper(grid, i, j - 1);


        }
    }
}

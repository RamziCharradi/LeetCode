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
                    if (grid[i][j] != '0')
                    {
                        Helper(ref grid, i, j);

                        island++;
                    }
                    
                }
            }

            return island;
        }

        public static void Helper(ref char[][] grid, int i, int j)
        {
            if (!(i < grid.Length && j < grid[i].Length && j >= 0 && i >= 0))
            {
                return;
            }
            else if(grid[i][j] != '0')
            {
                grid[i][j]--;
                Helper(ref grid, i + 1, j);
                Helper(ref grid, i, j + 1);
                Helper(ref grid, i, j - 1);
            }

        }
    }
}

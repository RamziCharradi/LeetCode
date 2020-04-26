using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IslandPerimeter_463
    {
        public static int IslandPerimeter(int[][] grid)
        {
            int Result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length ; j++)
                {
                    
                    int counter = 0;
                    if (i - 1 >= 0 && grid[i - 1][j] == 1) counter++;
                    if (i + 1 < grid.Length && grid[i + 1][j] == 1) counter++;
                    if (j - 1 >= 0 && grid[i][j - 1] == 1) counter++;
                    if(j + 1 < grid[0].Length && grid[i][j + 1] == 1) counter++;

                    if (grid[i][j] == 1) Result += 4 - counter;

                }
            }

            return Result;
        }
    }
}

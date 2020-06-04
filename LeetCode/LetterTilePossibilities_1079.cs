using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LetterTilePossibilities_1079
    {
        public static int NumTilePossibilities(string tiles)
        {
            int[] record = new int[26];
            foreach (var t in tiles)
            {
                record[t - 'A']++;
            }

            return dfs(record);

        }
        private static int dfs(int[] record)
        {
            int sum = 0;

            for (int i = 0; i < 26; i++)
            {
                if (record[i] > 0)
                {
                    sum++;
                    record[i]--;
                    sum += dfs(record);
                    record[i]++;
                }
            }

            return sum;
        }
    }
}

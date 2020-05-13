using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class OccurrencesAfterBigram_1078
    {
        public static string[] FindOcurrences(string text, string first, string second)
        {
            var array_text = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> Result = new List<string>();
            for (int i = 0; i < array_text.Length-2; i++)
            {
                if (array_text[i] == first && array_text[i + 1] == second) Result.Add(array_text[i + 2]);          
            }
            return Result.ToArray();
        }
    }
}

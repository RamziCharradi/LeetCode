using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class StringMatchingInAnArray_1408
    {
        public static IList<string> StringMatching(string[] words)
        {
            IList<string> Result = new List<string>();

            for (int i = 0; i < words.Length ; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if(words[i].Length<words[j].Length && words[i] != words[j])
                    {
                        if (words[j].Contains(words[i])) Result.Add(words[i]);
                    }
                }
            }
            return Result.Distinct().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MostCommonWord_819
    {
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            return paragraph.Split('!', '?', ',', '.', ';', ' ', '\'')
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Select(x => x.ToLower())
                            .Where(x => !banned.Contains(x))
                            .GroupBy(x => x)
                            .ToDictionary(x => x.Key, x => x.Count())
                            .OrderBy(x => x.Value)
                            .Last()
                            .Key;

        }
    }
}

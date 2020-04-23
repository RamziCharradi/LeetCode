using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class LongestWordInDictionary_720
    {
        public static string LongestWord(string[] words)
        {
            if (words == null) return null;
            Array.Sort(words);
            var visitedPrefix = new HashSet<string>();
            string maximumWord = "";

            foreach (var word in words)
            {
                var length = word.Length;

                if (length == 1 || visitedPrefix.Contains(word.Substring(0, length - 1)))
                {
                    maximumWord = word.Length > maximumWord.Length ? word : maximumWord;
                    visitedPrefix.Add(word);
                }
            }
            return maximumWord;


            //if (words.Length == 1) return words[0];
            //string Result = "";

            //var g1 = words.GroupBy(x => x).ToDictionary(x=>x.Key,x=>x.Key.Length)
            //    .OrderByDescending(x => x.Value)
            //    .ThenBy(x => x.Key)
            //    .Select(x => x.Key);

            //foreach (var w in g1)
            //{
            //    bool test = true;
            //    int counter = w.Length;
            //    if (w.Length > Result.Length)
            //    {
            //        foreach (var x in g1.Where(x=>x[0]==w[0]))
            //        {
            //            if(x.Length < w.Length && w.Substring(0,x.Length) == x)
            //            {
            //                if (!w.Contains(x))
            //                {
            //                    test = false;
            //                    break;
            //                }
            //                else
            //                {
            //                    counter--;
            //                }
            //            }
            //        }
            //        if (test && counter==1 && w.Length>Result.Length) return w;
            //    }

            //}
            //return Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class PrintWordsVertically_1324
    {
        public static IList<string> PrintVertically(string s)
        {

            var whitespace = ' ';
            var words = s.Split(whitespace, StringSplitOptions.RemoveEmptyEntries);

            var max = words.Select(x => x.Length).Max();
            return Enumerable.Range(0, max)
                              .Select(i => string.Join( string.Empty,
                                // If the word is shorter than max, fill with whitespace
                                words.Select(x => i < x.Length ? x[i] : whitespace))
                                // No trailing whitespace	
                                .TrimEnd())
                                .ToList();

            //var w = s.Split(" ");
            //var max = w.Select(x => x.Length).Max();
            //string[] Result = new string[max];
            //var counter = 0;
            //for (int j = 0; j < max; j++)
            //{
            //    for (int i = 0; i < w.Length; i++)
            //    {
            //        if (w[i].Length > j ) 
            //        {
            //            if (Result[counter] == "")
            //            {
            //                if (!char.IsWhiteSpace(w[i][j])) Result[counter] = w[i][j].ToString();
            //                else Result[counter] = " ";
            //            }
            //            else 
            //            {
            //                if (!char.IsWhiteSpace(w[i][j])) Result[counter] += w[i][j].ToString();
            //                else Result[counter] += " ";
            //            }
            //        }
            //        else
            //        {
            //            if (Result[counter] == "") Result[counter] = " ";
            //            else Result[counter] += " ";
            //        } 

            //    }

            //    counter++;
            //}

            //return Result.Select(x=>x.TrimEnd()).ToArray();
        }
    }
}

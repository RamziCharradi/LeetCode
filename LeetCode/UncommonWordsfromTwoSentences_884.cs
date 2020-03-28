using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LeetCode
{
    public class UncommonWordsfromTwoSentences_884
    {
        public static string[] UncommonFromSentences(string A, string B)
        {
            var arr_A = A.Split(" ");
            var arr_B = B.Split(" ");

            var arr_AA = arr_A.GroupBy(x => x)
                                    .Where(x => x.Count() == 1)
                                    .Select(x => x.Key).ToArray();
            var arr_BB = B.Split(" ").GroupBy(x => x)
                                    .Where(x => x.Count() == 1)
                                    .Select(x => x.Key).ToArray();

            var arr_X = arr_AA.Concat(arr_BB);

            return arr_X.Where(x => !arr_A.Any(y => y == x) || !arr_B.Any(y => y == x))
                        .ToArray();

           /*** One Line Solution ******
            
             return string
                         .Format("{0} {1}", A, B)
                         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                         .GroupBy(x => x)
                         .Where(x => x.Count() == 1)
                         .Select(x => x.Key)
                         .ToArray();

             ****************************/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ReformatTheString_1417
    {
        public static string Reformat(string s)
        {
            var d = s.Where(x => char.IsDigit(x)).ToList();
            var a = s.Where(x => char.IsLetter(x)).ToList();
            var Result = new StringBuilder();
            if (d.Count() > a.Count()) if (a.Count() + 1 != d.Count()) return "";
            if (d.Count() < a.Count()) if (d.Count() + 1 != a.Count()) return "";

            for (int i = 0; i < Math.Min(d.Count(),a.Count()); i++)
            {
                if (d.Count() >= a.Count())
                {
                    Result.Append(d[i]);
                    Result.Append(a[i]);
                }
                else
                {
                    Result.Append(a[i]);
                    Result.Append(d[i]);
                }
                   
            }
            if (d.Count() > a.Count()) Result.Append(d[d.Count() - 1]);
            if (a.Count() > d.Count()) Result.Append(a[a.Count() - 1]);

            return Result.ToString();

        }
    }
}

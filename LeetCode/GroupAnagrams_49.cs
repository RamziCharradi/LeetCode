using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class GroupAnagrams_49
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
           // IList<IList<string>> Result = new List<IList<string>>();
            Dictionary<string, IList<string>> d = new Dictionary<string, IList<string>>();
            foreach (var s in strs)
            {
                string os = String.Concat(s.OrderBy(c => c))
;
                if (d.Keys.Contains(os))
                {
                    d[os].Add(s);
                }
                else
                {
                    d.Add(os, new List<string> { s });
                }
            }

            //Result = d.Select(x => x.Value).ToList();
            return d.Select(x => x.Value).ToList();
        }
    }
}

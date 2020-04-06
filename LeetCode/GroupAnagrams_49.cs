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
            Dictionary<string, IList<string>> d = new Dictionary<string, IList<string>>();
            foreach (var s in strs)
            {
                string os = String.Concat(s.OrderBy(c => c));
                if (d.Keys.Contains(os))
                {
                    d[os].Add(s);
                }
                else
                {
                    d.Add(os, new List<string> { s });
                }
            }

            return d.Select(x => x.Value).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class GroupsOfSpecialEquivalentStrings_893
    {
        public static int NumSpecialEquivGroups(string[] A)
        {
            return A.Select(Order).Distinct().Count();

            static string Order(string s)
            {
                var chars = s.Select((c, i) => (i, c)).ToArray();
                var evens = chars.Where(t => t.i % 2 == 0).Select(t => t.c).OrderBy(c => c);
                var odds = chars.Where(t => t.i % 2 == 1).Select(t => t.c).OrderBy(c => c);

                return new string(evens.Concat(odds).ToArray());
            }
        }
    }
}

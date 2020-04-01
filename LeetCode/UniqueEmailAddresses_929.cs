using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class UniqueEmailAddresses_929
    {
        public static int NumUniqueEmails(string[] emails)
        {
            return emails.Select(x => x.Split('@'))
                         .Select(x => x[0].Split('+')[0].Replace(".", "") + "@" + x[1])
                         .Distinct()
                         .Count();
        }
    }
}

using System.Linq;

namespace LeetCode
{
    public class FirstUniqueCharacterInAString_387
    {
        public static int FirstUniqChar(string s)
        {
            return s.IndexOf(s.GroupBy(x => x)
                    .Where(x => x.Count() == 1)
                    .Select(x => x.Key)
                    .FirstOrDefault());
        }
    }
}

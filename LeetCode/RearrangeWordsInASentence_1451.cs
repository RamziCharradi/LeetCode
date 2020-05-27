using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class RearrangeWordsInASentence_1451
    {
        public static string ArrangeWords(string text)
        {
            var newWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x.Length).Select(x => x.ToLowerInvariant()).ToArray();

            if (newWords.Length > 0)
            {
                newWords[0] = (newWords[0].Substring(0, 1).ToUpperInvariant() + newWords[0].Substring(1));
            }

            return string.Join(" ", newWords);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PrefixOfAnyWordInASentence_1455
    {
        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            var tab = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var counter = 0;
            foreach (var w in tab)
            {
                counter++;
                if (w.Length >= searchWord.Length)
                {
                    if (w.Substring(0, searchWord.Length) == searchWord)
                    {
                        return counter;
                    }
                }
                
            }

            return -1;
            
        }
    }
}

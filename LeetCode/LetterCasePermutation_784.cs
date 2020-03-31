using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LetterCasePermutation_784
    {
        public static IList<string> LetterCasePermutation(string S)
        {
            IList<string> Result = new List<string>();
            LetterCasePermutationHelper(S, 0, string.Empty, Result);
            return Result;

        }

        private static void LetterCasePermutationHelper(string S, int index, string curr, IList<string> Result)
        {
            if (curr.Length == S.Length)
                Result.Add(curr);
            else
            {
                if (Char.IsDigit(S[index]))
                {
                    LetterCasePermutationHelper(S, index + 1, curr + S[index], Result);
                }
                else
                {
                    LetterCasePermutationHelper(S, index + 1, curr + Char.ToLower(S[index]), Result);
                    LetterCasePermutationHelper(S, index + 1, curr + Char.ToUpper(S[index]), Result);
                }
            }

        }
    }
}

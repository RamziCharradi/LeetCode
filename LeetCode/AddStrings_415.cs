using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class AddStrings_415
    {
        public static string AddStrings(string num1, string num2)
        {
            if (num1 == null || num1.Length == 0)
                return num2;
            if (num2 == null || num2.Length == 0)
                return num1;

            var length1 = num1.Length;
            var length2 = num2.Length;

            var sumString = new StringBuilder();
            int carry = 0;

            for (int i = length1 - 1, j = length2 - 1; i >= 0 || j >= 0 || carry == 1; i--, j--)
            {
                int x = i < 0 ? 0 : (num1[i] - '0');
                int y = j < 0 ? 0 : (num2[j] - '0');

                var sum = x + y + carry;
                sumString.Append(sum % 10);
                carry = sum / 10;
            }

            var reverse = sumString.ToString().ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
    }
}

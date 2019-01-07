using System;
// https://leetcode.com/problems/reverse-integer/

namespace LeetCodeResolvedTasks.Easy.ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            try
            {
                var z = checked(handleReverse(x));
                return z;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        private static int handleReverse(int x)
        {
            bool negative = false;
            if (x < 0)
            {
                negative = true;
                x = checked(x * -1);
            }
            string number = x.ToString();
            return negative ? ReverseToInt(number) * -1 : ReverseToInt(number);
        }
        public static int ReverseToInt(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            var result = new string(charArray);
            return int.Parse(result);
        }

    }
}

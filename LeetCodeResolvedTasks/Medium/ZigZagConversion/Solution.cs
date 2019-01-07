// https://leetcode.com/problems/zigzag-conversion/

namespace LeetCodeResolvedTasks.Medium.ZigZagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            string result = "";
            for (int i = 0; i < numRows; i++)
            {
                var letterSpacing = (numRows - i - 1 + numRows - i - 2) < 0 ? numRows - 1 + numRows - 2 : numRows - i - 1 + numRows - i - 2;
                for (int j = i; j < s.Length; j += letterSpacing + 1)
                {
                    result += s[j];
                    if (numRows == 1)
                    {
                        result = s;
                        j = s.Length;
                    }
                    if (i != 0 && i != numRows - 1 && j != i)
                    {
                        j += i + 1 * i;
                        if (j < s.Length)
                        {
                            result += s[j];
                        }
                    }

                }
            }
            return result;
        }
    }
}

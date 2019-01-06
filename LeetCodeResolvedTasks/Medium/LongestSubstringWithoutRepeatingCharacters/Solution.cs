using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolvedTasks.Medium.LongestSubstringWithoutRepeatingCharacters
{
    class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var resultArray = new List<char>();
                resultArray.Add(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (resultArray.Contains(s[j]))
                    {
                        j = s.Length;
                    }
                    else resultArray.Add(s[j]);
                }
                if (resultArray.Count > length) length = resultArray.Count;
            }
            return length;
        }
    }
}

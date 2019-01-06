using System;
using System.Collections.Generic;
// https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace LeetCodeResolvedTasks.Hard.MedianofTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            bool doubleResult = (nums1.Length + nums2.Length) % 2 == 0 ? true : false;
            var resultList = new List<int>();
            resultList.AddRange(nums1);
            resultList.AddRange(nums2);
            resultList.Sort();
            double res;
            var ind = (nums1.Length + nums2.Length) / 2;
            if (doubleResult)
            {
                res = (resultList[ind] + resultList[ind - 1]) / 2.0;
            }
            else res = resultList[ind];
            return res;
        }
    }
}

// https://leetcode.com/problems/two-sum/

namespace LeetCodeResolvedTasks.Easy.TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i == j) { j++; }
                    if (nums[i] + nums[j] == target)
                        return new int[2] { i, j };
                }
            }
            return new int[2] { 0, 0 };
        }
    }
}

// Source : https://leetcode-cn.com/problems/two-sum/
// Author : aaron wang
// Date   : 2019-11-02

/**********************************************************************************
 *
 * 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
 * 不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。
 *
 * 示例 1:
 * 给定 nums = [2, 7, 11, 15], target = 9
 * 因为 nums[0] + nums[1] = 2 + 7 = 9
 * 所以返回 [0, 1]
 * 
 **********************************************************************************/

using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 7, 11, 15 };
            Console.WriteLine(TwoSum(nums, 9));
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// two sum
        /// </summary>
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dict[target - nums[i]] };
                }
                dict[nums[i]] = i;
            }
            return null;
        }
    }
}

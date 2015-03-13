﻿using System;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// 
    /// Given an array of integers, find two numbers such that they add up to a specific target number.
    /// The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
    /// You may assume that each input would have exactly one solution.
    /// Input: numbers={2, 7, 11, 15}, target=9
    /// Output: index1=1, index2=2
    /// </summary>
    public class Problem001
    {
        public static Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            var length = numbers.Length;
            var left = 0;
            while (left < length - 1)
            {
                var right = length - 1;
                while (right > left)
                {
                    if (numbers[left] + numbers[right] == target)
                        return new Tuple<int, int>(left + 1, right + 1);
                    right--;
                }
                left++;
            }

            return null;
        }
    }
}
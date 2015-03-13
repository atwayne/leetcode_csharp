using System;
using System.Collections.Generic;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// 
    /// Given a collection of numbers, return all possible permutations.
    /// For example,
    /// [1,2,3] have the following permutations:
    /// [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], and [3,2,1].
    /// </summary>
    public class Problem046
    {
        public static IList<IList<int>> Permute(int[] num)
        {
            var result = new List<IList<int>>();

            var previous = PreviousNumber(num);
            while (previous != null)
            {
                result.Add(previous);
                previous = PreviousNumber(previous);
            }

            var next = NextNumber(num);
            while (next != null)
            {
                result.Add(next);
                next = NextNumber(next);
            }

            result.Add(num);
            return result;
        }

        public static int[] NextNumber(int[] num)
        {
            var length = num.Length;
            if (length <= 1)
                return null;

            // from right to left, find the first element which is smaller that it's right element
            var left = length - 2;
            while (left > 0 && num[left] >= num[left + 1])
            {
                left--;
            }

            // return null if none element found
            if (num[left] >= num[left + 1])
                return null;

            // from right to left, find the first element which is greater that num[left]
            var right = length - 1;
            while (num[left] >= num[right])
            {
                right--;
            }

            var result = new int[length];
            Array.Copy(num, result, length);

            // switch num[left] and num[right]
            result[left] = num[right];
            result[right] = num[left];

            // reverse all the elements right to num[left]
            Reverse(result, left + 1, length - 1);
            return result;
        }

        public static int[] PreviousNumber(int[] num)
        {
            var length = num.Length;
            if (length <= 1)
                return null;

            // from right to left, find the first element which is greater than it's right element
            var left = length - 2;
            while (left > 0 && num[left] <= num[left + 1])
            {
                left--;
            }

            // return null if none element found
            if (num[left] <= num[left + 1])
                return null;

            // from right to left, find the first element which is smaller that num[left]
            var right = length - 1;
            while (num[left] <= num[right])
            {
                right--;
            }

            var result = new int[length];
            Array.Copy(num, result, length);

            // switch num[left] and num[right]
            result[left] = num[right];
            result[right] = num[left];

            // reverse all the elements right to num[left]
            Reverse(result, left + 1, length - 1);
            return result;
        }


        public static void Reverse(int[] nums, int start, int end)
        {
            Problem189.Reverse(nums, start, end);
        }
    }
}

using System.Collections.Generic;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element/
    /// 
    /// Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
    /// You may assume that the array is non-empty and the majority element always exist in the array.
    /// 
    /// </summary>
    public class Problem169
    {
        public static int MajorityElement(int[] nums)
        {
            var n = nums.Length;

            var bitmap = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var key = nums[i];
                if (bitmap.ContainsKey(key))
                {
                    bitmap[key]++;
                }
                else
                {
                    bitmap[key] = 1;
                }

                if (bitmap[key] > nums.Length / 2)

                    if (bitmap[key] > n / 2)
                    {
                        return key;
                    }
            }

            return default(int);
        }
    }
}

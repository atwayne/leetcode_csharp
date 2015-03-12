
using System;
namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-array/
    /// 
    /// 
    /// Rotate an array of n elements to the right by k steps.
    /// For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].
    /// </summary>
    public class Problem189
    {
        public static void Rotate(int[] nums, int k)
        {
            var length = nums.Length;

            k = k % length;
            if (k < 0) k += length;

            if (k == 0)
                return;


            
            var result = new int[length];
            var shift = length - k;

            for (var i = 0; i < length; i++)
            {
                result[i] = nums[(shift + i) % length];
            }

            for (var i = 0; i < length; i++)
            {
                nums[i] = result[i];
            }
        }
    }
}

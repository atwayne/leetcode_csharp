using System.Collections.Generic;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/largest-number/
    /// 
    /// Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.
    /// 
    /// For example,
    /// Given [3,2,1,5,6,4] and k = 2, return 5.
    /// 
    /// </summary>
    public class Problem215
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            var pivot = nums[nums.Length / 2];

            var smaller = new List<int>();
            var greater = new List<int>();
            var count = 0;

            var index = 0;
            while (index < nums.Length)
            {
                if (nums[index] < pivot)
                {
                    smaller.Add(nums[index]);
                }
                else if (nums[index] > pivot)
                {
                    greater.Add(nums[index]);
                }
                else
                {
                    count++;
                }
                index++;
            }


            if (greater.Count >= k)
            {
                return FindKthLargest(greater.ToArray(), k);
            }

            if (greater.Count == k - 1 || greater.Count + count >= k)
            {
                return pivot;
            }

            return FindKthLargest(smaller.ToArray(), k - greater.Count - count);
        }
    }
}

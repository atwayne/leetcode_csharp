using System;
using System.Collections.Generic;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/trapping-rain-water/
    /// 
    /// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
    /// For example, 
    /// Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
    /// </summary>
    public class Problem042
    {
        public static int Trap(IList<int> height)
        {
            // we need at least three elements
            if (height.Count < 3)
                return 0;

            var left = 0;
            var right = height.Count - 1;
            var maxLeft = 0;
            var maxRight = 0;
            var result = 0;
            while (left <= right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] > maxLeft)
                    {
                        maxLeft = height[left];
                    }
                    else
                    {
                        result += maxLeft - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] > maxRight)
                    {
                        maxRight = height[right];
                    }
                    else
                    {
                        result += maxRight - height[right];
                    }
                    right--;
                }
            }
            return result;
        }
    }
}

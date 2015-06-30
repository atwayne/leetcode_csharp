using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/majority-element-ii/
    /// 
    /// Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.
    /// </summary>
    public class Problem229
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            var majority = 0;
            var secondMajority = 0;

            var counter = 0;
            var secondCounter = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                if (majority == number)
                {
                    counter++;
                }
                else if (secondMajority == number)
                {
                    secondCounter++;
                }
                else if (counter == 0)
                {
                    counter = 1;
                    majority = number;
                }
                else if (secondCounter == 0)
                {
                    secondCounter = 1;
                    secondMajority = number;
                }
                else
                {
                    counter--;
                    secondCounter--;
                }
            }

            counter = 0;
            secondCounter = 0;
            // reset counter
            for (var i = 0; i < nums.Length; i++)
            {
                if (majority == nums[i])
                {
                    counter++;
                }
                else if (secondMajority == nums[i])
                {
                    secondCounter++;
                }
            }
            var result = new List<int>();
            var baseline = nums.Length / 3;
            if (counter > baseline)
                result.Add(majority);
            if (secondCounter > baseline)
                result.Add(secondMajority);

            return result;
        }
    }
}

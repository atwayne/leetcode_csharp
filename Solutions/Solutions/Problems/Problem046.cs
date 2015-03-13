using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //var 

            return result;
        }

        public static IList<int> Next(int[] num)
        {
            var i = 0;
            var length = num.Length;
            while (i < length - 2 && num[i] < num[i + 1])
            {
                i++;
            }

            if (num[i] < num[i + 1])
                return null;





        }

        public static IList<int> Prev(int[] num) { }
    }
}

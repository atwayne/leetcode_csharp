
namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-1-bits/
    /// 
    /// Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).
    /// For example, the 32-bit integer ’11' has binary representation 00000000000000000000000000001011, so the function should return 3.
    /// </summary>
    public class Problem191
    {
        public static int HammingWeight(uint n)
        {
            var count = 0;
            while (n != 0)
            {
                n = n & n - 1;
                count++;
            }
            return count;
        }
    }
}

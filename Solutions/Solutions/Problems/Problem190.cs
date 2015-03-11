
namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-bits/
    /// 
    /// Reverse bits of a given 32 bits unsigned integer.
    /// For example, given input 43261596 (represented in binary as 00000010100101000001111010011100), return 964176192 (represented in binary as 00111001011110000010100101000000).
    /// Follow up:
    /// If this function is called many times, how would you optimize it?
    /// </summary>
    public class Problem190
    {
        public static uint ReverseBits(uint n)
        {
            uint result = 0;
            var count = 0;
            while (n > 0)
            {
                result = result * 2 + (n & 1);
                n = n >> 1;
                count++;
            }
            return result << (32 - count);
        }
    }
}

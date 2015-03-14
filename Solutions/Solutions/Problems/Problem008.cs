namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// 
    /// Reverse digits of an integer.
    /// Example1: x = 123, return 321
    /// Example2: x = -123, return -321
    /// 
    /// </summary>
    public class Problem008
    {
        public static int Reverse(int x)
        {
            if (x == 0)
                return 0;

            var result = 0;
            var overflow = 214748364;

            while (x != 0)
            {
                var remainder = x % 10;
                if ((x > 0 && result > overflow)
                    || (x < 0 && result < -overflow))
                    return 0;
                result = result * 10 + remainder;
                x /= 10;
            }

            return result;
        }
    }
}

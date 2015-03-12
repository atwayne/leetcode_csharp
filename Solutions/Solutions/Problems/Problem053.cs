
namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// 
    /// Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
    /// For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
    /// the contiguous subarray [4,−1,2,1] has the largest sum = 6.
    /// </summary>
    public class Problem053
    {
        public static int MaxSubArray(int[] A)
        {
            var length = A.Length;
            var sum = new int[length];

            CaculateSubArray(A, length - 1, sum);
            return Max(sum);
        }

        private static void CaculateSubArray(int[] array, int k, int[] sum)
        {
            if (k == 0)
            {
                sum[k] = array[k];
            }
            else
            {
                CaculateSubArray(array, k - 1, sum);
                sum[k] = sum[k - 1] > 0 ? sum[k - 1] + array[k] : array[k];
            }
        }

        private static int Max(int[] array)
        {
            var max = array[0];
            var i = 1;
            var length = array.Length;
            while (i < length)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                ++i;
            }
            return max;
        }
    }
}

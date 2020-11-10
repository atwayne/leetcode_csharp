using System.Linq;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
    /// </summary>
    ///
    /// Say you have an array for which the ith element is the price of a given stock on day i.
    /// Design an algorithm to find the maximum profit. You may complete at most two transactions.
    /// Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).
    public class Problem123
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            var minValue = int.MinValue;
            var days = prices.Length;

            var dp = new int[days, 3, 2];
            dp[0, 2, 0] = 0;
            dp[0, 1, 1] = prices[0] * -1;
            dp[0, 2, 1] = minValue;
            dp[0, 1, 0] = minValue;
            dp[0, 0, 0] = minValue;
            dp[0, 0, 1] = minValue;

            for (var i = 1; i < days; i++)
            {
                dp[i, 2, 0] = dp[i - 1, 2, 0];
                dp[i, 2, 1] = minValue;

                dp[i, 1, 0] = Max(dp[i - 1, 1, 0], dp[i - 1, 1, 1] + prices[i]);
                dp[i, 1, 1] = Max(dp[i - 1, 1, 1], dp[i - 1, 2, 0] == int.MinValue ? int.MinValue : dp[i - 1, 2, 0] - prices[i]);

                dp[i, 0, 0] = Max(dp[i - 1, 0, 0], dp[i - 1, 0, 1] + prices[i]);
                dp[i, 0, 1] = Max(dp[i - 1, 0, 1], dp[i - 1, 1, 0] == int.MinValue ? int.MinValue : dp[i - 1, 1, 0] - prices[i]);
            }

            return Max(dp[days - 1, 2, 0], Max(dp[days - 1, 1, 0], dp[days - 1, 0, 0]));
        }

        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}

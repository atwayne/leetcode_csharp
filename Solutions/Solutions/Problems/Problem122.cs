namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
    /// 
    /// Say you have an array prices for which the ith element is the price of a given stock on day i.
    /// Design an algorithm to find the maximum profit.You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
    /// Note: You may not engage in multiple transactions at the same time(i.e., you must sell the stock before you buy again).
    /// </summary>
    public class Problem122
    {
        public static int MaxProfit(int[] prices)
        {
            var days = prices.Length;
            var dp = new int[days, 2];

            // day 1
            dp[0, 0] = 0;
            dp[0, 1] = prices[0] * -1;

            for (var i = 1; i < days; i++)
            {
                dp[i, 0] = Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);
            }

            return dp[days - 1, 0];
        }

        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}

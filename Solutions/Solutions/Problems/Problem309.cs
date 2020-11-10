namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
    /// </summary>
    /// Say you have an array for which the ith element is the price of a given stock on day i.
    /// Design an algorithm to find the maximum profit.You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times) with the following restrictions:
    /// You may not engage in multiple transactions at the same time(ie, you must sell the stock before you buy again).
    /// After you sell your stock, you cannot buy stock on next day. (ie, cooldown 1 day)
    /// 
    public class Problem309
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            var days = prices.Length;
            var dp = new int[days, 2];

            // day 1
            dp[0, 0] = 0;
            dp[0, 1] = prices[0] * -1;

            for (var i = 1; i < days; i++)
            {
                dp[i, 0] = Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                if (i > 1)
                {
                    dp[i, 1] = Max(dp[i - 1, 1], dp[i - 2, 0] - prices[i]);
                }
                else
                {
                    dp[i, 1] = Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);
                }
            }

            return dp[days - 1, 0];
        }

        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}

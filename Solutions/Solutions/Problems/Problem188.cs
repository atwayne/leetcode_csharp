using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv/
    /// </summary>
    /// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
    /// Design an algorithm to find the maximum profit.You may complete at most k transactions.
    /// Notice that you may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).
    public class Problem188
    {
        public static int MaxProfit(int k, int[] prices)
        {
            if (prices.Length <= 1 || k == 0)
            {
                return 0;
            }

            var minValue = prices.Sum() * -1;
            var days = prices.Length;
            var dp = new int[days, k + 1, 2];

            dp[0, 0, 0] = 0;
            dp[0, 0, 1] = minValue;
            dp[0, 1, 0] = minValue;
            dp[0, 1, 1] = prices[0] * -1;

            var maxTransactions = days / 2 + 1;
            if (k < maxTransactions)
            {
                maxTransactions = k;
            }

            for (var today = 1; today < days; today++)
            {
                for (var usedTransactions = 0; usedTransactions <= maxTransactions; usedTransactions++)
                {
                    if (usedTransactions == 0)
                    {
                        dp[today, usedTransactions, 1] = minValue;
                        continue;
                    }

                    if (today / 2 + 1 < usedTransactions)
                    {
                        dp[today, usedTransactions, 0] = minValue;
                        dp[today, usedTransactions, 1] = minValue;
                        continue;
                    }

                    dp[today, usedTransactions, 0] = Max(dp[today - 1, usedTransactions, 0],
                        dp[today - 1, usedTransactions, 1] + prices[today]);

                    dp[today, usedTransactions, 1] = Max(dp[today - 1, usedTransactions - 1, 0] - prices[today],
                        dp[today - 1, usedTransactions, 1]);
                }
            }

            var max = 0;
            for (var j = 0; j <= k; j++)
            {
                if (dp[days - 1, j, 0] > max)
                {
                    max = dp[days - 1, j, 0];
                }
            }

            return max;
        }

        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}

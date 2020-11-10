using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem123Test
    {
        [Test]
        public void MaxProfitTest1()
        {
            var prices = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };
            var expected = 6;

            var actual = Problem123.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxProfitTest2()
        {
            var prices = new int[] { 1, 2, 3, 4, 5 };
            var expected = 4;

            var actual = Problem123.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxProfitTest3()
        {
            var prices = new int[] { 7, 6, 4, 3, 1 };
            var expected = 0;

            var actual = Problem123.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxProfitTest4()
        {
            var prices = new int[] { 1 };
            var expected = 0;

            var actual = Problem123.MaxProfit(prices);
            Assert.AreEqual(expected, actual);
        }

    }
}

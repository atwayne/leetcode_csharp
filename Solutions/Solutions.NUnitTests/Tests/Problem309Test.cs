using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem1309Test
    {
        [Test]
        public void MaxProfitTest1()
        {
            var input = new int[] { 1, 2, 3, 0, 2 };
            var result = Problem309.MaxProfit(input);
            var expected = 3;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest2()
        {
            var input = new int[0];
            var result = Problem309.MaxProfit(input);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest3()
        {
            var input = new int[] { 1 };
            var result = Problem309.MaxProfit(input);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest4()
        {
            var input = new int[] { 2, 1, 4 };
            var result = Problem309.MaxProfit(input);
            var expected = 3;

            Assert.AreEqual(expected, result);
        }

    }
}

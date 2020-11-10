using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem188Test
    {
        [Test]
        public void MaxProfitTest1()
        {
            var input = new int[] { 2, 4, 1 };
            var result = Problem188.MaxProfit(2, input);
            var expected = 2;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest2()
        {
            var input = new int[] { 3, 2, 6, 5, 0, 3 };
            var result = Problem188.MaxProfit(2, input);
            var expected = 7;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest3()
        {
            var input = new int[0];
            var result = Problem188.MaxProfit(2, input);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest4()
        {
            var input = new int[2] { 1, 3 };
            var result = Problem188.MaxProfit(0, input);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }
    }
}
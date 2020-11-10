using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem122Test
    {
        [Test]
        public void MaxProfitTest1()
        {
            var input = new int[] { 7, 1, 5, 3, 6, 4 };
            var result = Problem122.MaxProfit(input);
            var expected = 7;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MaxProfitTest2()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var result = Problem122.MaxProfit(input);
            var expected = 4;

            Assert.AreEqual(expected, result);
        }


        [Test]
        public void MaxProfitTest3()
        {
            var input = new int[] { 7, 6, 4, 3, 1 };
            var result = Problem122.MaxProfit(input);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }
    }
}

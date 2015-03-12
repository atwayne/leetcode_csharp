using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Problems;

namespace Solutions.Tests.Problems.Tests
{
    [TestClass]
    public class Problem053Test
    {
        [TestMethod]
        public void MaxSubArrayTest()
        {
            var input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var expected = 6;
            var actual = Problem053.MaxSubArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Problems;

namespace Solutions.Tests.Problems.Tests
{
    [TestClass]
    public class Problem001Test
    {
        [TestMethod]
        public void TwoSumTest()
        {
            var numbers = new [] { 2, 7, 11, 15 };
            var target = 9;

            var actual = Problem001.TwoSum(numbers, target);
            Assert.AreEqual(actual.Item1, 1);
            Assert.AreEqual(actual.Item2, 2);
        }
    }
}

using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem001Test
    {
        [Test]
        public void TwoSumTest()
        {
            var numbers = new[] { 2, 7, 11, 15 };
            var target = 9;

            var actual = Problem001.TwoSum(numbers, target);
            Assert.AreEqual(actual.Item1, 1);
            Assert.AreEqual(actual.Item2, 2);
        }
    }
}

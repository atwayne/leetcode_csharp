using Solutions.Problems;
using NUnit.Framework;

namespace Solutions.NUnitTests.Tests
{
	[TestFixture ]
    public class Problem053Test
    {
		[Test]
        public void MaxSubArrayTest()
        {
            var input = new [] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var expected = 6;
            var actual = Problem053.MaxSubArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

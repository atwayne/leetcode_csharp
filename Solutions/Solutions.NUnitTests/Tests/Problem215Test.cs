using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture()]
    public class Problem215Test
    {
        [Test()]
        public void FindKthLargestTest()
        {
            var input = new int[] { 3, 2, 1, 5, 6, 4 };
            var k = 2;
            var actual = Problem215.FindKthLargest(input, k);
            var expected = 5;
            Assert.AreEqual(actual, expected);

            input = new int[] { -1, -1 };
            k = 2;
            actual = Problem215.FindKthLargest(input, k);
            expected = -1;
            Assert.AreEqual(actual, expected);


            input = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            k = 9;
            actual = Problem215.FindKthLargest(input, k);
            expected = 1;
            Assert.AreEqual(actual, expected);

            input = new int[] { 2, 1 };
            k = 1;
            actual = Problem215.FindKthLargest(input, k);
            expected = 2;
            Assert.AreEqual(actual, expected);
        }


    }
}

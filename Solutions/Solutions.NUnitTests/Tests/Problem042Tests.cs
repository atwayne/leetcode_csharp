using System.Collections.Generic;
using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem042Tests
    {
        [Test]
        public void TrapTestOfficalExampleShouldPass()
        {
            var input = new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var actual = Problem042.Trap(input);
            var expected = 6;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TrapTestAllSameHeightShouldPass()
        {
            var input = new List<int> { 1, 1, 1, 1, 1, 1 };
            var actual = Problem042.Trap(input);
            var expected = 0;
            Assert.AreEqual(actual, expected);
        }


        [Test]
        public void TrapTestSortedArrayShouldPass()
        {
            var input = new List<int> { 1, 2, 3, 4, 5, 6 };
            var actual = Problem042.Trap(input);
            var expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TrapTestReversedSortedArrayShouldPass()
        {
            var input = new List<int> { 6, 5, 4, 3, 2, 1 };
            var actual = Problem042.Trap(input);
            var expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TrapTestMonutainShapeArrayShouldPass()
        {
            var input = new List<int> { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };
            var actual = Problem042.Trap(input);
            var expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TrapTestValleryArrayShouldPass()
        {
            var input = new List<int> { 4, 2, 2, 3 };
            var actual = Problem042.Trap(input);
            var expected = 2;
            Assert.AreEqual(actual, expected);
        }
    }
}

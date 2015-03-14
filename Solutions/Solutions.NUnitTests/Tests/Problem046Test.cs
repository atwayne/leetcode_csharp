using System.Collections.Generic;
using Solutions.Problems;
using NUnit.Framework;


namespace Solutions.NUnitTests.Tests
{
	[TestFixture]
    public class Problem046Test
    {
		[Test]
        public void PermuteTest()
        {
            var input = new[] { 1, 2, 3 };
            var expected = new List<IList<int>>
            {
                new []{1,2,3},
                new []{1,3,2},
                new []{2,1,3},
                new []{2,3,1},
                new []{3,1,2},
                new []{3,2,1},
            };
            var actual = Problem046.Permute(input);
            Assert.IsNotNull(actual);
            // compare count first before I think about another solution
            Assert.AreEqual(expected.Count, actual.Count);
        }

		[Test]
        public void NextNumberTest()
        {
            var input = new[] { 1, 2, 5, 3 };
            var expected = new[] { 1, 3, 2, 5 };
            var actual = Problem046.NextNumber(input);
            CollectionAssert.AreEqual(expected, actual);
        }

		[Test]
        public void NextNumberTestMaxNumberShouldReturnNull()
        {
            var input = new[] { 5, 3, 2, 1 };
            var actual = Problem046.NextNumber(input);
            Assert.IsNull(actual);
        }

		[Test]
        public void PreviousNumberTest()
        {
            var input = new[] { 1, 3, 2, 5 };
            var expected = new[] { 1, 2, 5, 3 };
            var actual = Problem046.PreviousNumber(input);
            CollectionAssert.AreEqual(expected, actual);
        }

		[Test]
        public void PreviousNumberTestSmallestNumberShouldReturnNull()
        {
            var input = new[] { 1, 2, 3 };
            var actual = Problem046.PreviousNumber(input);
            Assert.IsNull(actual);
        }
    }
}

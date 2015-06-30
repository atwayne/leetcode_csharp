using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture()]
    public class Problem229Test
    {
        [Test()]
        public void MajorityElementTest()
        {
            var input = new int[] { 1 };
            var actual = Problem229.MajorityElement(input);
            var expected = new int[] { 1 };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);

            input = new int[] { 1, 1, 1, 1 };
            actual = Problem229.MajorityElement(input);
            expected = new int[] { 1 };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);

            input = new int[] { 1, 2 };
            actual = Problem229.MajorityElement(input);
            expected = new int[] { 1, 2 };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);


            input = new int[] { 1, 2, 3 };
            actual = Problem229.MajorityElement(input);
            expected = new int[] { };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);

            input = new int[] { 1, 2, 1, 2 };
            actual = Problem229.MajorityElement(input);
            expected = new int[] { 1, 2 };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);

            input = new int[] { 2, 2, 1, 3 };
            actual = Problem229.MajorityElement(input);
            expected = new int[] { 2 };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);

            input = new int[] { 3, 2, 3 };
            actual = Problem229.MajorityElement(input);
            expected = new int[] { 3 };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}

using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture()]
    public class Problem169Test
    {
        [Test()]
        public void MajorityElementTest()
        {
            var input = new int[] { 1 };
            var expected = 1;
            var actual = Problem169.MajorityElement(input);

            Assert.AreEqual(expected, actual);


            input = new int[] { 1, 2, 3, 4, 5, 3, 3, 3, 3, 3 };
            expected = 3;
            actual = Problem169.MajorityElement(input);
            Assert.AreEqual(expected, actual);


            input = new int[] { 3, 3, 3, 3, 4, 4, 4 };
            expected = 3;
            actual = Problem169.MajorityElement(input);
            Assert.AreEqual(expected, actual);


            input = new int[] { 2, 2, 2, 3, 3, 3, 3 };
            expected = 3;
            actual = Problem169.MajorityElement(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

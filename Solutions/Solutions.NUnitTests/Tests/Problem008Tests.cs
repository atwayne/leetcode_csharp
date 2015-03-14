using System.Collections.Generic;
using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem008Tests
    {
        [Test]
        public void ReverseTest()
        {
            var testcases = new Dictionary<int, int>
            {
                {-1,-1},
                {123,321},
                {-98765,-56789},
                {2147483647,0},
                {-2147483648,0},
                {2147447412,2147447412},
                {-2147447412,-2147447412},
                {0,0}
            };

            foreach (var testcase in testcases)
            {
                var input = testcase.Key;
                var expected = testcase.Value;
                var actual = Problem008.Reverse(input);
                Assert.AreEqual(expected, actual);

            }
        }
    }
}

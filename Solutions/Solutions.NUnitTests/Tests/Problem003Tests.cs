using System.Collections.Generic;
using NUnit.Framework;
using Solutions.Problems;

namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem003Tests
    {
        [Test]
        public void LengthOfLongestSubstringTest()
        {
            var testcases = new Dictionary<string, int>
            {
                {"bbbbbb",1},
                {"",0},
                {"abcabcbb",3},
                {"abcdefg",7}
            };

            foreach (var testcase in testcases)
            {
                var input = testcase.Key;
                var expected = testcase.Value;
                var actual = Problem003.LengthOfLongestSubstring(input);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

using System.Collections.Generic;
using Solutions.Problems;
using NUnit.Framework;

namespace Solutions.NUnitTests.Tests
{
	[TestFixture ()]
    public class Problem191Test
    {
		[Test()]
        public void HammingWeightTests()
        {
            var data = new Dictionary<uint, int>
            {
                {1,1},
                {2,1},
                {3,2},
                {11,3},
                {12,2}
            };

            foreach (var pair in data)
            {
                var input = pair.Key;
                var expected = data[input];
                var actual = Problem191.HammingWeight(input);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

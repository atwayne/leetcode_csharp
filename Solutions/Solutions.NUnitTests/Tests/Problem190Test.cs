using System.Collections.Generic;
using Solutions.Problems;
using NUnit.Framework;

namespace Solutions.NUnitTests.Tests
{
	[TestFixture ()]
    public class Problem190Test
    {
		[Test()]
        public void ReverseBits()
        {
            var data = new Dictionary<uint, uint>
            {
                {43261596,964176192}
            };

            foreach (var pair in data)
            {
                var input = pair.Key;
                var expected = data[input];
                var actual = Problem190.ReverseBits(input);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

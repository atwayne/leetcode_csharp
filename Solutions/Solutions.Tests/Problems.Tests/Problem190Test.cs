using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Problems;

namespace Solutions.Tests.Problems.Tests
{
    [TestClass]
    public class Problem190Test
    {
        [TestMethod]
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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Problems;

namespace Solutions.Tests.Problems.Tests
{
    [TestClass]
    public class Problem191Test
    {
        [TestMethod]
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

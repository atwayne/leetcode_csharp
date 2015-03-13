using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Problems;

namespace Solutions.Tests.Problems.Tests
{
    [TestClass]
    public class Problem046Test
    {
        [TestMethod]
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
    }
}

using System;
using System.Collections.Generic;
using Solutions.Problems;
using NUnit.Framework;


namespace Solutions.NUnitTests.Tests
{
	[TestFixture ()]
    public class Problem189Test
    {
		[Test()]
        public void RotateTest()
        {
            var testcases = new List<TestCase>
            {
                new TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 },3,new int[] { 5, 6, 7, 1, 2, 3, 4 }),
                new TestCase(new int[] { 1, 2 },0,new int[] { 1,2 }),
                new TestCase(new int[] { 1, 2 },3,new int[] { 2,1 })
            };

            foreach (var testcase in testcases)
            {
                var input = testcase.input;
                var rotate = testcase.rotate;
                var expected = testcase.expected;
                Problem189.Rotate(input, rotate);
                CollectionAssert.AreEqual(expected, input);
            }
        }

		[Test()]
        public void ReverseTest()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var start = 0;
            var end = input.Length - 1;

            var expected = (int[])input.Clone();
            Array.Reverse(expected);

            Problem189.Reverse(input, start, end);
            CollectionAssert.AreEqual(expected, input);
        }


		[Test()]
        public void RotateInPlaceTest()
        {
            var testcases = new List<TestCase>
            {
                new TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 },3,new int[] { 5, 6, 7, 1, 2, 3, 4 }),
                new TestCase(new int[] { 1, 2 },0,new int[] { 1,2 }),
                new TestCase(new int[] { 1, 2 },3,new int[] { 2,1 })
            };

            foreach (var testcase in testcases)
            {
                var input = testcase.input;
                var rotate = testcase.rotate;
                var expected = testcase.expected;
                Problem189.RotateInplace(input, rotate);
                CollectionAssert.AreEqual(expected, input);
            }
        }

        private class TestCase
        {
            public int[] input;
            public int rotate;
            public int[] expected;

            public TestCase(int[] input, int rotate, int[] expected)
            {
                this.input = input;
                this.rotate = rotate;
                this.expected = expected;
            }
        }
    }
}

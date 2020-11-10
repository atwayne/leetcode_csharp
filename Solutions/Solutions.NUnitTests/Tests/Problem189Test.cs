using System;
using System.Collections.Generic;
using NUnit.Framework;
using Solutions.Problems;


namespace Solutions.NUnitTests.Tests
{
    [TestFixture]
    public class Problem189Test
    {
        [Test]
        public void RotateTest()
        {
            var testcases = new List<TestCase> {
                new TestCase (new [] { 1, 2, 3, 4, 5, 6, 7 }, 3, new [] { 5, 6, 7, 1, 2, 3, 4 }),
                new TestCase (new [] { 1, 2 }, 0, new [] { 1, 2 }),
                new TestCase (new [] { 1, 2 }, 3, new [] { 2, 1 })
            };

            foreach (var testcase in testcases)
            {
                var input = testcase.Input;
                var rotate = testcase.Rotate;
                var expected = testcase.Expected;
                Problem189.Rotate(input, rotate);
                CollectionAssert.AreEqual(expected, input);
            }
        }

        [Test]
        public void ReverseTest()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var start = 0;
            var end = input.Length - 1;

            var expected = (int[])input.Clone();
            Array.Reverse(expected);

            Problem189.Reverse(input, start, end);
            CollectionAssert.AreEqual(expected, input);
        }


        [Test]
        public void RotateInPlaceTest()
        {
            var testcases = new List<TestCase> {
                new TestCase (new [] { 1, 2, 3, 4, 5, 6, 7 }, 3, new [] { 5, 6, 7, 1, 2, 3, 4 }),
                new TestCase (new [] { 1, 2 }, 0, new [] { 1, 2 }),
                new TestCase (new [] { 1, 2 }, 3, new [] { 2, 1 })
            };

            foreach (var testcase in testcases)
            {
                var input = testcase.Input;
                var rotate = testcase.Rotate;
                var expected = testcase.Expected;
                Problem189.RotateInplace(input, rotate);
                CollectionAssert.AreEqual(expected, input);
            }
        }

        private class TestCase
        {
            public int[] Input;
            public int Rotate;
            public int[] Expected;

            public TestCase(int[] input, int rotate, int[] expected)
            {
                Input = input;
                Rotate = rotate;
                Expected = expected;
            }
        }
    }
}

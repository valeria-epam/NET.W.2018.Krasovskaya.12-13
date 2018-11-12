using System.Linq;
using NUnit.Framework;

namespace FibonacciTask.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciGeneratorTest()
        {
            var expected = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            Assert.AreEqual(expected, Fibonacci.FibonacciGenerator(0, 1).Take(10));
        }

        [Test]
        public void FibonacciGeneratorTest1()
        {
            var expected = new int[] { 1, 2, 3, 5, 8, 13, 21, 34 };
            Assert.AreEqual(expected, Fibonacci.FibonacciGenerator(1, 2).Take(8));
        }

        [Test]
        public void FibonacciGeneratorTest2()
        {
            var expected = new int[] { 0, 0 };
            Assert.AreEqual(expected, Fibonacci.FibonacciGenerator(0, 0).Take(8));
        }

        [Test]
        public void FibonacciGeneratorTest3()
        {
            var expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            Assert.AreEqual(expected, Fibonacci.FibonacciGenerator().Take(9));
        }
    }
}

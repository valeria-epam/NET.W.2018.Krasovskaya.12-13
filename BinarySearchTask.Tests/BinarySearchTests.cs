using System;
using NUnit.Framework;

namespace BinarySearchTask.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [TestCase(5, ExpectedResult = -1)]
        [TestCase(8, ExpectedResult = 5)]
        [TestCase(17, ExpectedResult = -1)]
        public int SearchTest(int item)
        {
            int[] array = { 1, 2, 3, 4, 6, 8, 9, 15, 16 };
            return array.Search(item);
        }

        [TestCase("bread", ExpectedResult = 1)]
        [TestCase("8", ExpectedResult = -1)]
        [TestCase("put", ExpectedResult = 3)]
        public int SearchTest(string item)
        {
            string[] array = { "a", "bread", "cream", "put" };
            return array.Search(item);
        }

        [Test]
        public void SearchTest1()
        {
            int[] array = null;
            Assert.Throws<ArgumentNullException>(() => array.Search(5));
        }

        [Test]
        public void SearchTest2()
        {
            string[] array = { "a", "bread", "cream", "put" };
            Assert.Throws<ArgumentNullException>(() => array.Search(null));
        }
    }
}
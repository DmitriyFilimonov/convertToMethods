using System;
using System.Collections.Generic;
using System.Text;
using methods;
using NUnit.Framework;

namespace methods.Tests
{
    public class ArraysTests
    {
        
        [TestCase(new int[] { 3, 2, -3}, 2)]
        [TestCase(new int[] { -3, 2, -2 }, 0)]
        [TestCase(new int[] { 0, -2, 3 }, 1)]
        public void GetIndexOfMinimalTest(int[] a, int expected)
        {
            int actual = Arrays.GetIndexOfMinimal(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, 0)]
        [TestCase(new int[] { -3, 2, -2 }, 1)]
        [TestCase(new int[] { 0, -2, 3 }, 2)]
        public void GetIndexOfMaximalTest(int[] a, int expected)
        {
            int actual = Arrays.GetIndexOfMaximal(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, -3)]
        [TestCase(new int[] { -3, 2, -2 }, -3)]
        [TestCase(new int[] { 0, -2, 3 }, -2)]
        public void GetMinimalElement(int[] a, int expected)
        {
            int actual = Arrays.GetMinimalElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, 3)]
        [TestCase(new int[] { -3, 2, -2 }, 2)]
        [TestCase(new int[] { 0, -2, 3 }, 3)]
        public void GetMaximalElementTest(int[] a, int expected)
        {
            int actual = Arrays.GetMaximalElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, 2)]
        [TestCase(new int[] { -3, 2, -2 }, 1)]
        [TestCase(new int[] { 0, -2, 3 }, 1)]
        public void GetQuantityOfOddElementsTest(int[] a, int expected )
        {
            int actual = Arrays.GetQuantityOfOddElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, new int[] { -3, 2, 3 })]
        [TestCase(new int[] { -3, 2, -2 }, new int[] { -2, 2, -3 })]
        [TestCase(new int[] { 0, -2, 3 }, new int[] { 3, -2, 0 })]
        public void ReverseTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.Reverse(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, 2)]
        [TestCase(new int[] { -3, 2, -2 }, 2)]
        [TestCase(new int[] { 0, -2, 3 }, -2)]
        public void GetSumOfElementsWithOddIndexesTest(int[] a, int expected )
        {
            int actual = Arrays.GetSumOfElementsWithOddIndexes(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, -3 }, new int[] { -3, 2, 3 })]
        [TestCase(new int[] { -3, 2, -2 }, new int[] { -2, 2, -3 })]
        [TestCase(new int[] { 0, -2, 3, 1 }, new int[] { 3, 1, 0, -2 })]
        public void SwapHalvesTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.SwapHalves(a);
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(new int[] { -3, 2, -2 }, new int[] { -3, -2, 2 })]
        [TestCase(new int[] { 0, -2, 3, 1 }, new int[] { -2, 0, 1, 3 })]
        [TestCase(new int[] { 3, 1, -3 }, new int[] { -3, 1, 3 })]
        public void DoAscendingSorTest(int[] a, int[] expected)
        {
            int[] actual = Arrays.DoAscendingSort(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -3, 2, -2 }, new int[] { 2, -2, -3 })]
        [TestCase(new int[] { 0, -2, 3, 1 }, new int[] { 3, 1, 0, -2 })]
        [TestCase(new int[] { 3, 1, -3 }, new int[] { 3, 1, -3 })]
        public void DoDescendingSortTest (int[] a, int[] expected)
        {
            int[] actual = Arrays.DoDescendingSort(a);
            Assert.AreEqual(expected, actual);
        }
    }
}

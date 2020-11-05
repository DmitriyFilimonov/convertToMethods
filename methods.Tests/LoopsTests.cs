using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace methods.Tests
{
    public class LoopsTests
    {
        
        [TestCase(0, 2, 0)]
        [TestCase(0, 0, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(2, -2, 0.25)]
        public void PowerTest(int a, int b, double expected)
        {
            double actual = Loops.Power(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(150, new int[] { 150, 300, 450, 600, 750, 900 })]
        public void GetAllDividedByTest(int a, int[] expected)
        {
            int[] actual = Loops.GetAllDividedBy(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetAllDividedByTestNegative(int a)
        {
            try
            {
                Loops.GetAllDividedBy(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(5, 2)]
        [TestCase(10, 3)]
        [TestCase(26, 5)]
        public void GetQuantityOfSqrsTest(int a, int expected)
        {
            int actual = Loops.GetQuantityOfSqrs(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(4, 2)]
        [TestCase(5, 1)]
        [TestCase(6, 3)]
        [TestCase(51, 17)]
        public void GetHighestDividerForTest(int input, double expected)
        {
            double actual = Loops.GetHighestDividerFor(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 7, 7)]
        [TestCase(2, 7, 7)]
        [TestCase(2, 15, 21)]
        public void GetSumOfDividedBySevenBetweenTest(int a, int b, int expected)
        {
            int actual = Loops.GetSumOfDividedBySevenBetween(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(6, 8)]
        public void GetFibonacciNumberFromOneTest(int number, int expected)
        {
            int actual = Loops.GetFibonacciNumberFromOne(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 150, 50)]
        [TestCase(99, 150, 3)]
        [TestCase(66, 150, 6)]
        [TestCase(4, 99, 1)]
        public void GetMaximalDividerByEuclidTest(int a, int b, int expected)
        {
            int actual = Loops.GetMaximalDividerByEuclid(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(125, 5)]
        [TestCase(343, 7)]
        public void GetCubeRootByBisectionForTest(int a, double expected)
        {
            double actual = Loops.GetCubeRootByBisectionFor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 1)]
        [TestCase(125, 2)]
        [TestCase(3437, 3)]
        public void GetQuantityOfOddDigitsTest(int a, int expected)
        {
            int actual = Loops.GetQuantityOfOddDigits(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(5475, 5745)]
        public void ReflectTest(int a, double expected)
        {
            double actual = Loops.Reflect(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 1)]
        [TestCase(8, 4)]
        [TestCase(13, 5)]
        public void DoIndescribableMathTest(int a, int expected)
        {
            int actual = Loops.DoIndescribableMath(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, 0, true)]
        [TestCase(123, 456, false)]
        [TestCase(123, 345, true)]
        public void FindIdenticalDigitsTest(int a, int b, bool expected)
        {
            bool actual = Loops.FindIdenticalDigits(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}

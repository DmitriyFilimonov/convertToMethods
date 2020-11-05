using System;
using System.Collections.Generic;
using methods;
using System.Text;
using NUnit.Framework;

namespace methods.Tests
{
    public class ConditionsTests
    {
        [TestCase(2, 1, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, -1)]
        public void DoSomeMathTest(double a, double b, double expected)
        {
            double actual = Conditions.DoSomeMath(a, b);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(2, 1, 1)]
        [TestCase(-2, 2, 2)]
        [TestCase(-2, -3, 3)]
        [TestCase(2, -3, 4)]
        public void GetQuarterOfPointTest(double x, double y, int expected)
        {
            int actual = Conditions.GetQuarterOfPoint(x, y);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(0, 5)]
        [TestCase(5, 0)]
        public void GetQuarterOfPointTestNegative(double x, double y)
        {
            try
            {
                Conditions.GetQuarterOfPoint(x, y);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 7, 5, new double[] { 2, 5, 7 })]
        [TestCase(9, 7, 5, new double[] { 5, 7, 9 })]
        [TestCase(-1, 0, 0, new double[] { -1, 0, 0 })]
        public void SortByValueTest(int a, int b, int c, double[] expected)
        {
            double[] actual = Conditions.SortByValue(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase (2, -5, 3, new double[] { 1.5, 1 })]
        [TestCase (-4, 1, 3, new double[] { -0.75, 1 })]
        [TestCase(-10, 1, 0, new double[] { 0, 0.1 })]
        public void GetSqrEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Conditions.SolveSqrEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 2)]
        [TestCase(2, 5, 72)]
        public void GetSqrEquationTestNegative(double a, double b, double c)
        {
            try
            {
                Conditions.SolveSqrEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}

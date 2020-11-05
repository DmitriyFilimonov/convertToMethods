using NUnit.Framework;
using methods;
using System.Numerics;

namespace methods.Tests
{
    public class VariablesTests
    {
        [TestCase(3, 2, new int[] { 1, 1 })]
        [TestCase(4, 2, new int[] { 2, 0 })]
        [TestCase(1, 2, new int[] { 0, 1 })]
        [TestCase(-1, 2, new int[] { 0, -1 })]
        public void GetPartitionAndModuloTest(int a, int b, int[] expected)
        {

            int[] actual = Variables.GetPartitionAndModulo(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3, 2, -1)]
        [TestCase(1, -3, 2, 5)]
        [TestCase(2, 3, 2, -0.5)]
        public void SolveLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, -3, 2)]
        [TestCase(0, -3, 500)]
        [TestCase(0, 800, 2)]
        public void SolveLinearEquationTestNegative(double a, double b, double c)
        {
            try
            {
                Variables.SolveLinearEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        
        [TestCase(3.95, 8.25, 3.95, 2, "X=4")]
        [TestCase(0, 8.26, 1, 8.26, "Y=8,3")]
        [TestCase(1, 1, 2, 2, "Y=X")]
        [TestCase(20, 300, 1.1, -2, "Y=16X-19,6")]
        public void GetLinearEquatiuonTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = Variables.GetLinearEquatiuon(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5000, 5000, 5000, 5000)]
        public void GetLinearEquatiuonTestTestNegative(double x1, double y1, double x2, double y2)
        {
            try
            {
                Variables.GetLinearEquatiuon(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    
            
    
    }
}
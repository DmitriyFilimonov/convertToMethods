using System;
using System.Collections.Generic;
using System.Text;
using methods;
using NUnit.Framework;

namespace methods.Tests
{
    public class Arrays2DTests
    {

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 0, 2 })]
        [TestCase(3, new int[] { 0, 2 })]
        public void GetIndexOfMaximalTest(int inputArrayNumb, int[] expected)
        {
            int[,] actualArgument = GetInputArrayMock(inputArrayNumb);
            int[] actual = Arrays2D.GetIndexOfMaximal(actualArgument);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 2, 2 })]
        [TestCase(3, new int[] { 2, 1 })]
        public void GetIndexOfMinimalTest(int inputArrayNumb, int[] expected)
        {
            int[,] actualArgument = GetInputArrayMock(inputArrayNumb);
            int[] actual = Arrays2D.GetIndexOfMinimal(actualArgument);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 0)]
        [TestCase(3, 1)]
        public void GetMinimalTest(int inputArrayNumb, int expected)
        {
            int[,] actualArgument = GetInputArrayMock(inputArrayNumb);
            int actual = Arrays2D.GetMinimal(actualArgument);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 9)]
        [TestCase(3, 9)]
        public void GetMaximalTest(int inputArrayNumb, int expected)
        {
            int[,] actualArgument = GetInputArrayMock(inputArrayNumb);
            int actual = Arrays2D.GetMaximal(actualArgument);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void GetNumberOfPeaksTest(int inputArrayNumb, int expected)
        {
            int[,] actualArgument = GetInputArrayMock(inputArrayNumb);
            int actual = Arrays2D.GetNumberOfPeaks(actualArgument);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void TransposeTest(int inputArrayNumber, int ExpectedArrayNumber)
        {
            int[,] actualArgument = GetInputArrayMock(inputArrayNumber);
            int[,] actual = Arrays2D.Transpose(actualArgument);
            int[,] expected = GetExpectedArrayMock(ExpectedArrayNumber);
            Assert.AreEqual(expected, actual);

        }

        int[,] GetInputArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,2,3},
                        {4,5,6},
                        {7,8,9}
                    };
                case 2:
                    return new int[,]
                    {
                        {4,2,9},
                        {4,2,8},
                        {5,1,0}
                    };
                case 3:
                    return new int[,]
                    {
                        {4,2,9},
                        {4,2,8},
                        {5,1,9}
                    };
                default:
                    throw new Exception();
            }
        }

        int[,] GetExpectedArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,4,7},
                        {2,5,8},
                        {3,6,9}
                    };
                case 2:
                    return new int[,]
                    {
                        {4,4,5},
                        {2,2,1},
                        {9,8,0}
                    };
                case 3:
                    return new int[,]
                    {
                        {4,4,5},
                        {2,2,1},
                        {9,8,9}
                    };
                default:
                    throw new Exception();
            }
        }
    }
}

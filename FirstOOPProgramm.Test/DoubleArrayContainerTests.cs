using NUnit.Framework;
using System;

namespace FirstOOPPropgramm.Test
{
    public class DoubleArrayContainerTests
    {
        [TestCase(Enums.TwoDimensionalArraay.first, 1)]
        [TestCase(Enums.TwoDimensionalArraay.second, -54)]
        [TestCase(Enums.TwoDimensionalArraay.oneOnly, 1)]
        public void FindMinTest(Enums.TwoDimensionalArraay type, int expected)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            int actual = DoubleArrayContainer.FindMin(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(Enums.TwoDimensionalArraay.empty)]
        public void FindMin_WhenLengthArrIsEqualZero_ShouldThrowException(Enums.TwoDimensionalArraay type)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => DoubleArrayContainer.FindMin(arr));
        }

        [TestCase(Enums.TwoDimensionalArraay.first, 5)]
        [TestCase(Enums.TwoDimensionalArraay.second, 254)]
        [TestCase(Enums.TwoDimensionalArraay.oneOnly, 1)]
        public void FindMaxTest(Enums.TwoDimensionalArraay type, int expected)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            int actual = DoubleArrayContainer.FindMax(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(Enums.TwoDimensionalArraay.empty)]
        public void FindMax_WhenLengthArrIsEqualZero_ShouldThrowException(Enums.TwoDimensionalArraay type)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => DoubleArrayContainer.FindMax(arr));
        }

        [TestCase(Enums.TwoDimensionalArraay.first, new int[] {0,0})]
        [TestCase(Enums.TwoDimensionalArraay.second, 254)]
        [TestCase(Enums.TwoDimensionalArraay.oneOnly, 1)]
        public void FindIndexOfMinTest(Enums.TwoDimensionalArraay type, int expected)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            int[] actual = DoubleArrayContainer.FindIndexOfMin(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(Enums.TwoDimensionalArraay.empty)]
        public void FindIndexOfMin_WhenLengthArrIsEqualZero_ShouldThrowException(Enums.TwoDimensionalArraay type)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => DoubleArrayContainer.FindIndexOfMin(arr));
        }

        [TestCase(Enums.TwoDimensionalArraay.first, 5)]
        [TestCase(Enums.TwoDimensionalArraay.second, 254)]
        [TestCase(Enums.TwoDimensionalArraay.oneOnly, 1)]
        public void FindIndexOfMaxTest(Enums.TwoDimensionalArraay type, int expected)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            int[] actual = DoubleArrayContainer.FindIndexOfMax(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(Enums.TwoDimensionalArraay.empty)]
        public void FindIndexOfMax_WhenLengthArrIsEqualZero_ShouldThrowException(Enums.TwoDimensionalArraay type)
        {
            int[,] arr = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => DoubleArrayContainer.FindIndexOfMax(arr));
        }
    }
}
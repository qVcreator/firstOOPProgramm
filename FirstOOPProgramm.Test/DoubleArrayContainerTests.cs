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
    }
}
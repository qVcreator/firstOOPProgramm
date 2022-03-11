using NUnit.Framework;
using System;

namespace FirstOOPPropgramm.Test
{
    public class Homework1Tests
    {
        #region Task2
        [TestCase(5, 7, 37)]
        [TestCase(-5 ,5, 0)]
        [TestCase(0, 5, 5)]
        [TestCase(5, 0, -5)]
        [TestCase(-10, 5, -5.0/3)]
        public void GetSolutionTest(double a, double b, double expected)
        {
            double actual = Homework1.GetSolution(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(-5, -5)]
        [TestCase(0, 0)]
        public void GetSolutionTest_WhenAIsEqualB_ShouldThrowExeption(int a, int b)
        {
            Assert.Throws<Exception>(() => Homework1.GetSolution(a, b));
        }
        #endregion


    }
}
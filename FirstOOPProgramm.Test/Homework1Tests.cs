using NUnit.Framework;
using System;

namespace FirstOOPPropgramm.Test
{
    public class Homework1Tests
    {
        [TestCase(5, 7, 37)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 5, 5)]
        [TestCase(5, 0, -5)]
        [TestCase(-10, 5, -5.0 / 3)]
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

        [TestCase(1, 2, 3, 1)]
        [TestCase(3, 4, 1, -1)]
        [TestCase(5, 2, -3, -1)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(-1, -1, -1, 0)]
        [TestCase(-1, -2, -3, 1)]
        [TestCase(-1, -3, -5, 2)]

        public void GetSolveOfLinearEquationTest(int a, int b, int c, int expected)
        {
            double actual = Homework1.GetSolveOfLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 5)]
        [TestCase(0, -2, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 0, 0)]
        public void GetSolveOfLinearEquation_WhenAIsEqualZero_ShouldThrowExeption(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Homework1.GetSolveOfLinearEquation(a, b, c));
        }

        [TestCase(1, 2, 2, 1, "y = -1x + 3")]
        [TestCase(-1, -2, -2, -1, "y = -1x + -3")]
        [TestCase(-1, 2, -2, 1, "y = 1x + 3")]
        [TestCase(1, -2, 2, -1, "y = 1x + -3")]
        [TestCase(5, 5, 4, 4, "y = 1x")]
        [TestCase(-5, -5, -4, -4, "y = 1x")]
        public void GetEquationOfStraightLineTest(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Homework1.GetEquationOfStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 0, 3)]
        [TestCase(-5, -2, -5, 4)]
        [TestCase(1, 0, 1, 2)]
        public void GetEquationOfStraightLine_WhenX1IsEqualX2_ShouldThrowExeption(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<Exception>(() => Homework1.GetEquationOfStraightLine(x1, y1, x2, y2));
        }

        [TestCase(2, 0, 3, 0)]
        [TestCase(-2, -5, 4, -5)]
        [TestCase(0, 1, 2, 1)]
        public void GetEquationOfStraightLine_WhenY1IsEqualY2_ShouldThrowExeption(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<Exception>(() => Homework1.GetEquationOfStraightLine(x1, y1, x2, y2));

        }

        [TestCase(6, 3, 2)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(3, 2, 1)]
        public void GetResultOfDivisonTest(int a, int b, int expected)
        {
            double actual = Homework1.GetResultOfDivison(a, b);
            Assert.AreEqual(expected, actual);
        }

        public void GetResultOfDivisonTest_WhenBIsEqualZero_ShouldThrowExeption(int a, int b, int expected)
        {
            Assert.Throws<Exception>(() => Homework1.GetResultOfDivison(a, b));

        }

        [TestCase(6, 3, 0)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(5, 2, 1)] 
        public void GetRemainderOfDivisonTest(int a, int b, int expected)
        {
            double actual = Homework1.GetRemainderOfDivison(a, b);
            Assert.AreEqual(expected, actual);
        }

        public void GetRemainderOfDivisonTest_WhenBIsEqualZero_ShouldThrowExeption(int a, int b, int expected)
        {
            Assert.Throws<Exception>(() => Homework1.GetRemainderOfDivison(a, b));

        }

        [TestCase("abc", "fff", "fff", "abc")]
        [TestCase("", "fff", "fff", "")]
        [TestCase("abc", "", "", "abc")]
        [TestCase("", "", "", "")]
        public void SwapStrings(string a, string b, string expectedA, string expectedB)
        {
            Homework1.SwapStrings(ref a, ref b);
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }
    }
}
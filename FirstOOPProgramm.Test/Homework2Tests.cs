using NUnit.Framework;
using System;

namespace FirstOOPPropgramm.Test
{
    public class Homework2Tests
    {
        [TestCase(3, 2, 5)]
        [TestCase(-2, -3, -5)]
        [TestCase(-2, 0, -2)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, -2, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 3, -1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 0, -3)]
        public void DoMathIfBoolTest(int a, int b, int expected)
        {
            int actual = Homework2.DoMathIfBool(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, "I")]
        [TestCase(3, 1, "I")]
        [TestCase(-1, 2, "II")]
        [TestCase(-3, 1, "II")]
        [TestCase(-1, -2, "III")]
        [TestCase(-3, -1, "III")]
        [TestCase(1, -2, "IV")]
        [TestCase(3, -2, "IV")]
        public void GetWhichQuarterTest(int x, int y, string expected)
        {
            string actual = Homework2.GetWhichQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5)]
        [TestCase(0, -5)]
        [TestCase(-5, 0)]
        [TestCase(5, 0)]
        public void GetWhichQuarter_WhenXOrYIsEqualZero_ShouldThrowExeption(int x, int y)
        {
            Assert.Throws<Exception>(() => Homework2.GetWhichQuarter(x, y));
        }

        [TestCase(12, "Двеннадцать")]
        [TestCase(-12, "Минус Двеннадцать")]
        [TestCase(25, "Двадцать пять")]
        [TestCase(-25, "Минсу Двадцать пять")]
        [TestCase(99, "Девяносто девять")]
        [TestCase(10, "Десять")]
        public void StringifyNumTest(int num, string expected)
        {
            string actual = Homework2.StringifyNum(num);
        }
        [TestCase(101)]
        [TestCase(-100)]
        [TestCase(9)]
        [TestCase(-9)]
        public void StringifyNum_WhenNumIsNotInRange_ShouldThrowExeption(int num)
        {
            Assert.Throws<Exception>(() => Homework2.StringifyNum(num));
        }

        [TestCase(2, 3, 1, new int[]{1,2,3})]
        [TestCase(2,-3,1, new int[] {-3,1,2})]
        [TestCase(-2,-3,-1, new int[] { -3, -2, -1 })]
        [TestCase(0,0,-1, new int[] { -1, 0, 0 })]
        [TestCase(0,0,1, new int[] { 0, 0, 1 })]
        public void GetFromLessToBiggestTest(int a, int b, int c, int[] expected)
        {
            int[] actual = Homework2.GetFromLessToBiggest(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,7,3, new double[] {-0.5, -3})]
        [TestCase(-2,-7,-3, new double[] {-3, -0.5 })]
        [TestCase(2,7,3, new double[] {-0.5, -3})]
        [TestCase(7,0,2 , new double[2] {0,0})]    
        [TestCase(1,2,1 , new double[] {-1, -1})]    
        public void GetResultOfQuadraticEquationTest(int a, int b, int c, double[] expected) 
        { 
            double[] actual = Homework2.GetResultOfQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);  
        }

        [TestCase(0,5,3)]
        public void GetQuadraticEquation_WhenAIEqualZero_ShouldThrowException(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Homework2.GetResultOfQuadraticEquation(a,b,c));
        }
    }
}
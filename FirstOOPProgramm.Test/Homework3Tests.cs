using NUnit.Framework;
using System;

namespace FirstOOPPropgramm.Test
{
    public class Homework3Tests
    {
        [TestCase(0,0,1)]
        [TestCase(2,0,1)]
        [TestCase(-2,0,1)]
        [TestCase(2,2,4)]
        [TestCase(-2,2,4)]
        [TestCase(0,2,0)]
        public void AscensionToTheDegreeTest(int a, int b, int expected)
        {
            int actual = Homework3.AscensionToTheDegree(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,-2)]
        [TestCase(0,-2)]
        [TestCase(-2,-2)]
        public void AscensionToTheDegree_WhenBIsLessThanZero_ShouldThrowException(int a, int b)
        {
            Assert.Throws<Exception>(() => Homework3.AscensionToTheDegree(a, b));
        }

        [TestCase(64,7)]
        [TestCase(-64,7)]
        [TestCase(50, 7)]
        [TestCase(0, 0)]
        [TestCase(2, 1)]
        public void FindLessThanSqureOfNumTest(int a, int expected)
        {
            int actual = Homework3.FindLessThanSqureOfNum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(64,32)]
        [TestCase(50,25)]
        [TestCase(9,3)]
        [TestCase(2,1)]
        [TestCase(-9, 3)]
        [TestCase(0, 1)]
        public void FindTheBiggestDeviderTest(int a, int expected)
        {
            int actual = Homework3.FindTheBiggestDevider(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(-1)]
        public void FindTheBiggestDevider_WhenDeviderIsEqualZero_ShouldThrowException(int a)
        {
            Assert.Throws<Exception>(() => Homework3.FindTheBiggestDevider(a));
        }

        [TestCase(0,10,7)]
        [TestCase(-7,7,0)]
        [TestCase(-7,0,-7)]
        [TestCase(-21,14,-21)]
        public void GetSummInRangeOfNumbersWhichDevidesBySevenTest(int a, int b, int expected)
        {
            int actual = Homework3.GetSummInRangeOfNumbersWhichDevidesBySeven(a, b);
            Assert.AreEqual(expected,actual);
        }

        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(5,5)]
        public void GetNumberOfFibonacciSeriesTest(int num, int expected)
        {
            int actual = Homework3.GetNumberOfFibonacciSeries(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetNumberOfFibonacciSeriesTest_WhenNumIsLessThanOne_ShouldThrowException(int num)
        {
            Assert.Throws<Exception>(() => Homework3.GetNumberOfFibonacciSeries(num));
        }

        [TestCase(13,5,1)]
        [TestCase(36,18,18)]
        [TestCase(-36,18,18)]
        public void GetСommonDivisorOfTwoNumbersByEuclidsAlgoritmTest(int num1, int num2, int expected)
        {
            int actual = Homework3.GetСommonDivisorOfTwoNumbersByEuclidsAlgoritm(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8,2)]
        [TestCase(27,3)]
        [TestCase(64,4)]
        public void GetNumByHalfDevisionMethodTest(int num, int expected)
        {
            int actual = Homework3.GetNumByHalfDevisionMethod(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123,2)]
        [TestCase(7777,4)]
        [TestCase(78887,2)]
        [TestCase(20,0)]
        [TestCase(222,0)]
        [TestCase(-222,0)]
        [TestCase(-221,1)]
        public void FindQuantityOddNumbersTest(int num, int expected)
        {
            int actual = Homework3.FindQuantityOddNumbers(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123,321)]
        [TestCase(100,001)]
        [TestCase(110,011)]
        public void GetReverseNumTest(int num, int expected)
        {
            int actual = Homework3.GetReverseNum(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(110, 20, true)]
        [TestCase(111, 20, false)]
        [TestCase(110, 0, true)]
        public void IsNumbersHaveSameDigitTest(int num1, int num2, bool expected)
        {
            bool actual = Homework3.IsNumbersHaveSameDigit(num1, num2);
            Assert.AreEqual(expected,actual);
        }

        //public void GetArrayFromOneToOneThousandOfNumbersWhichDevidesOnChoosenNumTest(int num, int[] expected)
        //{
        //    int[] actual = Homework3.GetArrayFromOneToOneThousandOfNumbersWhichDevidesOnChoosenNum(num);
        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(10, new int[] {2,4,6,8,})]
        [TestCase(20, new int[] {2,4,6,8,12,14,16,18,20})]
        public void GetNumbersInRangeFromOneToChoosenNumWhereSumOfEvenMoreThanSumOfOddTest(int num, int[] expected)
        {
            int[] actual = Homework3.GetNumbersInRangeFromOneToChoosenNumWhereSumOfEvenMoreThanSumOfOdd(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void GetNumbersInRangeFromOneToChoosenNumWhereSumOfEvenMoreThanSumOfOdd_WhenNumIsLessThanOne_ShouldThrowException(int num)
        {
            Assert.Throws<Exception>(() => Homework3.GetNumbersInRangeFromOneToChoosenNumWhereSumOfEvenMoreThanSumOfOdd(num));
        }
    }
}
using NUnit.Framework;
using System;

namespace FirstOOPPropgramm.Test
{
    public class ArrayContainerTests
    {

        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { 56, 33, 24, 0 }, 0)]
        [TestCase(new int[] { -2, 33, -60, 123 }, -60)]
        [TestCase(new int[] { 1, 1, 1 }, 1)]
        public void FindMinTest(int[] arr, int expected)
        {
            int actual = ArrayContainer.FindMin(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMin_WhenLengthArrIsEqualZero_ShouldThrowException(int[] arr)
        {
            Assert.Throws<Exception>(() => ArrayContainer.FindMin(arr));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 56, 33, 24, 0 }, 56)]
        [TestCase(new int[] { -2, 33, -60, 123 }, 123)]
        [TestCase(new int[] { 1, 1, 1 }, 1)]
        public void FindMaxTest(int[] arr, int expected)
        {
            int actual = ArrayContainer.FindMax(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMax_WhenLengthArrIsEqualZero_ShouldThrowException(int[] arr)
        {
            Assert.Throws<Exception>(() => ArrayContainer.FindMax(arr));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0)]
        [TestCase(new int[] { 56, 33, 24, 0 }, 3)]
        [TestCase(new int[] { -2, 33, -60, 123 }, 2)]
        [TestCase(new int[] { 1, 1, 1 }, 0)]
        public void FindIndexOfMinTest(int[] arr, int expected)
        {
            int actual = ArrayContainer.FindIndexOfMin(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexOfMin_WhenLengthArrIsEqualZero_ShouldThrowException(int[] arr)
        {
            Assert.Throws<Exception>(() => ArrayContainer.FindIndexOfMin(arr));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(new int[] { 56, 33, 24, 0 }, 0)]
        [TestCase(new int[] { -2, 33, -60, 123 }, 3)]
        [TestCase(new int[] { 1, 1, 1 }, 0)]
        public void FindIndexOfMax(int[] arr, int expected)
        {
            int actual = ArrayContainer.FindIndexOfMax(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexOfMax_WhenLengthArrIsEqualZero_ShouldThrowException(int[] arr)
        {
            Assert.Throws<Exception>(() => ArrayContainer.FindIndexOfMax(arr));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 6)]
        [TestCase(new int[] { 56, 33, 24, 0 }, 33)]
        [TestCase(new int[] { -2, -23, -60, 123 }, 100)]
        [TestCase(new int[] { 1, -1, 1, -1 }, -2)]
        public void CountSumWhereIndexIsOddTest(int[] arr, int expected)
        {
            int actual = ArrayContainer.CountSumWhereIndexIsOdd(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void CountSumWhereIndexIsOdd_WhenLengthArrIsEqualZero_ShouldThrowException(int[] arr)
        {
            Assert.Throws<Exception>(() => ArrayContainer.CountSumWhereIndexIsOdd(arr));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 56, 33, 24, 0 }, new int[] { 0, 24, 33, 56 })]
        [TestCase(new int[] { -2, -23, -60, 123 }, new int[] { 123, -60, -23, -2 })]
        [TestCase(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseTest(int[] arr, int[] expected)
        {
            int[] actual = ArrayContainer.Reverse(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[] { 56, 33, 24, 0 }, 1)]
        [TestCase(new int[] { -2, -23, -60, 123 }, 2)]
        [TestCase(new int[] { 0,0,0,0 }, 0)]
        public void CountOddNumbersTest(int[] arr, int expected)
        {
            int actual = ArrayContainer.CountOddNumbers(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 56, 33, 24, 0 }, new int[] { 24, 0, 56, 33 })]
        [TestCase(new int[] { -2, -23, 4, -60, 123 }, new int[] { -60, 123, 4, -2, -23 })]
        [TestCase(new int[] { 0, 1, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ChangeHalfsTest(int[] arr, int[] expected)
        {
            int[] actual = ArrayContainer.ChangeHalfs(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 56, 33, 24, 0 }, new int[] { 0, 24, 33, 56 })]
        [TestCase(new int[] { -2, -23, -60, 123 }, new int[] { -60, -23, -2, 123 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0,0,0,0 })]
        [TestCase(new int[] { 4,3,2,1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        public void BubbleSortTest(int[] arr, int[] expected)
        {
            int[] actual = ArrayContainer.BubbleSort(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 56, 33, 24, 0 }, new int[] { 0, 24, 33, 56 })]
        [TestCase(new int[] { -2, -23, -60, 123 }, new int[] { -60, -23, -2, 123 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SelectionSortTest(int[] arr, int[] expected)
        {
            int[] actual = ArrayContainer.SelectionSort(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 56, 33, 24, 0 }, new int[] { 0, 24, 33, 56 })]
        [TestCase(new int[] { -2, -23, -60, 123 }, new int[] { -60, -23, -2, 123 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        public void InsertionSortTest(int[] arr, int[] expected)
        {
            int[] actual = ArrayContainer.InsertionSort(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 56, 33, 24, 0 }, new int[] {56,33,24,0})]
        [TestCase(new int[] { -2, -23, -60, 123 }, new int[] { 123,-2,-23,-60 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void CountSortTesst(int[] arr, int[] expected)
        {
            int[] actual = ArrayContainer.CountSort(arr);
            Assert.AreEqual(expected, actual);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class ArrayContainer
    {
        public static int FindMin(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int FindMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int FindIndexOfMin(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int FindIndexOfMax(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int CountSumWhereIndexIsOdd(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int sum = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static int[] Reverse(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[] tmpArr = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                tmpArr[j] = arr[i];
                j++;
            }
            return tmpArr;
        }

        public static int CountOddNumbers(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ChangeHalfs(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[] tmpArr = new int[arr.Length];

            if (arr.Length % 2 != 0)
            {
                int j = 0;
                for (int i = (arr.Length / 2) + 1; i < arr.Length; i++)
                {
                    tmpArr[j] = arr[i];
                    j++;
                }
                tmpArr[arr.Length / 2] = arr[arr.Length / 2];
                j = 0;
                for (int i = (tmpArr.Length / 2) + 1; i < tmpArr.Length; i++)
                {
                    tmpArr[i] = arr[j];
                    j++;
                }
            }
            else
            {
                int j = 0;
                for (int i = (arr.Length / 2); i < arr.Length; i++)
                {
                    tmpArr[j] = arr[i];
                    j++;
                }
                j = 0;
                for (int i = (tmpArr.Length / 2); i < tmpArr.Length; i++)
                {
                    tmpArr[i] = arr[j];
                    j++;
                }
            }

            return tmpArr;

        }
        public static int[] BubbleSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }
            int[] tmpArr = CopyArray(arr);

            for (int i = 0; i < tmpArr.Length - 1; i++)
            {
                for (int j = tmpArr.Length - 1; j > 0; j--)
                {
                    if (tmpArr[j] < tmpArr[j - 1])
                    {
                        Homework1.SwapNums(ref tmpArr[j], ref tmpArr[j - 1]);
                    }
                }
            }

            return tmpArr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }
            int[] tmpArr = CopyArray(arr);

            for (int i = 0; i < tmpArr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < tmpArr.Length; j++)
                {
                    if (tmpArr[j] < tmpArr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Homework1.SwapNums(ref tmpArr[i], ref tmpArr[minIndex]);
            }

            return tmpArr;
        }
        public static int[] InsertionSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }
            int[] tmpArr = CopyArray(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                int movedNum = tmpArr[i];
                while ((j > 0) && (movedNum < tmpArr[j - 1]))
                {
                    Homework1.SwapNums(ref tmpArr[j], ref tmpArr[j - 1]);
                    j--;
                }
            }
            return tmpArr;
        }

        public static int[] CountSort(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }
            int[] tmpArr = new int[arr.Length];



            for (int i = 0; i < arr.Length; i++)
            {
                int count = arr.Length;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        count--;

                    }
                }
                tmpArr[count - 1] = arr[i];
            }

            return tmpArr;
        }

        public static int[] CopyArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            Array.Copy(arr, newArr, arr.Length);
            return newArr;
        }

        public static int[] CreateRandom(int quantityCells)
        {
            if (quantityCells < 0)
            {
                throw new Exception("quantityCells have to be more than zero");
            }

            int[] array = new int[quantityCells];
            Random r = new Random();
            for (int i = 0; i < quantityCells; i++)
            {
                array[i] = r.Next(-100, 101);
            }
            return array;
        }
    }
}

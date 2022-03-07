using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class Arrays
    {
        public static int[] CreatArray(int quantityCells)
        {
            int[] array = new int[quantityCells];
            Random r = new Random();
            for (int i = 0; i < quantityCells; i++)
            {
                array[i] = r.Next(-100, 101);
            }
            return array;
        }

        public static int FindMinOfArray(int[] arr)
        {
            if (arr == null)
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
        public static int FindMaxOfArray(int[] arr)
        {
            if (arr == null)
            {
                throw new Exception("arr can't be null");
            }
            int max = arr[0];
            for (int i=1; i<arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int FindIndexOfMinArraysNumber(int[] arr)
        {
            if(arr == null)
            {
                throw new Exception("arr can't be null");
            }

            int min = arr[0];
            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int FindIndexOfMaxArraysNumber(int[] arr)
        {
            if (arr == null)
            {
                throw new Exception("arr can't be null");
            }

            int min = arr[0];
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int CountSumOfArrayWhereIndexIsOdd(int[] arr)
        {
            if (arr == null)
            {
                throw new Exception("arr can't be null");
            }

            int sum = 0;
            for (int i = 1; i < arr.Length; i+=2)
            {
                sum +=arr[i];
            }
            return sum;
        }

        public static int[] ReverseArray(int[] arr)
        {
            if (arr == null)
            {
                throw new Exception("arr can't be null");
            }

            int[] tmpArr = new int[arr.Length];
            int j = 0;
            
            for (int i = arr.Length-1; i >= 0; i--)
            {
                tmpArr[j]=arr[i];
                j++;
            }
            return tmpArr;
        }

        public static int CountOddNumbersInArray(int[] arr)
        {
            if (arr == null)
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
    }
}

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
    }
}

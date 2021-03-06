using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    public class DoubleArrayContainer
    {
        public static int FindMin(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int min = arr[0,0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] < min)
                    {
                        min = arr[i,j];
                    }
                }
            }

            return min;
        }

        public static int FindMax(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }

        public static int[] FindIndexOfMin(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[] min = new int[2] {0,0};

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[min[0],min[1]])
                    {
                        min[0] = i;
                        min[1] = j;
                    }
                }
            }

            return min;
        }

        public static int[] FindIndexOfMax(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[] max = new int[2] {0,0};

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[max[0],max[1]])
                    {
                        max[0] = i;
                        max[1] = j;   
                    }
                }
            }

            return max;
        }

        public static int FindQuantityOfElementsWhichMoreThanNeighbours(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int quantity = 0;

            int[,] newArr = Copy(arr);

            for (int i = 0; i < newArr.GetLength(0); i++)
            {
                for (int j = 0; j < newArr.GetLength(1); j++)
                {
                    if ((i == 0 || arr[i, j] > arr[i - 1, j])
                        && (j == 0 || arr[i, j] > arr[i, j - 1])
                        && (i == arr.GetLength(0) - 1 || arr[i, j] > arr[i + 1, j])
                        && (j == arr.GetLength(1) - 1 || arr[i, j] > arr[i, j + 1]))
                    {
                        quantity++;
                    }
                }
            }

            return quantity;
        }

        public static int[,] Swap(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[,] newArr = Copy(arr);

            for (int i = 0; i < newArr.GetLength(1); i++)
            {
                for (int j=i; j < newArr.GetLength(0); j++)
                {
                    Homework1.SwapNums(ref newArr[i, j], ref newArr[j,i]);
                }
            }

            return newArr;
        }

        static int[,] Copy(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
            Array.Copy(arr, newArr, arr.Length);
            return newArr;
        }

        static int[,] EncircleByZero(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            int[,] newArr = new int[arr.GetLength(0)+2,arr.GetLength(1)+2];
            for (int i=0; i<newArr.GetLength(0)-1; i++)
            {
                for(int j=0; j<newArr.GetLength(1)-1; j++)
                {
                    if (i < arr.GetLength(0) && j < arr.GetLength(1))
                    {
                        newArr[i + 1, j + 1] = arr[i, j];
                    }
                }
            }
            return newArr;
        }
        public static int[,] CreateRandom (int lenString=4, int lenColumn=4)
        {
            if ((lenString<=0) || (lenColumn <= 0))
            {
                throw new Exception("Length can't be less than zero");
            }
            Random r = new Random();

            int[,] arr = new int[lenString, lenColumn];

            for (int i=0; i<lenString; i++)
            {
                for (int j=0; j<lenColumn; j++)
                {
                    arr[i, j] = r.Next(0, 10);
                }
            }

            return arr;
        }
        
        public static void Show(int[,] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("arr can't be null");
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

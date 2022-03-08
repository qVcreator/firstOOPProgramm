using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class Homework3
    {
        public static int AscensionToTheDegree(int a, int b)
        {
            if (b < 0)
            {
                throw new Exception("<b> can't be less than zero");
            }
            int res = 1;
            if (b == 0)
            {
                res = 1;
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    res *= a;
                }
            }

            return res;
        }

        public static int FindLessThanSqureOfNum(int a)
        {
            int check = 1;
            while (check * check < a)
            {
                check++;
            }
            return check;
        }
        public static int FindTheBiggestDevider(int a)
        {
            int devider = a - 1;
            if (devider == 0)
            {
                throw new Exception("devider can't be zero");
            }
            while (a % devider != 0)
            {
                devider--;
            }
            return devider;
        }
        public static int GetSummInRangeOfNumbersWhichDevidesBySeven(int a, int b)
        {
            int summ = 0;

            if (b > a)
            {
                Homework1.SwapNums(ref a,ref b);
            }
            while (b <= a)
            {
                if (b % 7 == 0)
                {
                    summ += b;
                }
                b++;
            }
            return summ;
        }
        public static int GetNumberOfFibonacciSeries(int num)
        {
            if (num <= 0)
            {
                throw new Exception("Num have to be more than zero");
            }
            int firstFibonacciNum = 1;
            int secondFibonacciNum = 1;
            int actualFibonacciNum = 1;

            int counter = 2;

            while (counter < num)
            {
                actualFibonacciNum = firstFibonacciNum + secondFibonacciNum;
                firstFibonacciNum = secondFibonacciNum;
                secondFibonacciNum = actualFibonacciNum;

                counter++;
            }
            return actualFibonacciNum;
        }
        public static int GetСommonDivisorOfTwoNumbersByEuclidsAlgoritm(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
            }
            return num1;
        }
        public static int GetNumByHalfDevisionMethod(int num)
        {
            int res = 0;
            int leftNum = 0;
            int rightNum = num;

            do
            {
                res = (leftNum + rightNum) / 2;
                if (Math.Pow(res, 3) < num)
                {
                    leftNum = res;
                }
                else
                {
                    rightNum = res;
                }
            } while (Math.Pow(res, 3) != num);

            return res;
        }
        public static int FindQuantityOddNumbers(int num)
        {
            int сounter = 0;

            while (num != 0)
            {
                if (!(((num % 10) % 2) == 0))
                {
                    сounter += 1;
                }
                num /= 10;
            }

            return сounter;
        }
        public static int GetReverseNum(int num)
        {
            int res = 0;

            while (num != 0)
            {
                res *= 10;
                res += num % 10;
                num /= 10;
            }

            return res;
        }
        public static bool IsNumbersHaveSameDigit(int num1, int num2)
        {
            bool res = false;

            if (num2 > num1)
            {
                Homework1.SwapNums(ref num1, ref num2);

            }

            while (num1 != 0)
            {
                int temp1 = num1 % 10;
                do
                {
                    int temp2 = num2 % 10;
                    if (temp1 == temp2)
                    {
                        res = true;
                    }
                    num2 /= 10;
                } while (num2 != 0);
                num1 /= 10;
            }

            return res;
        }
        public static int[] GetArrayFromOneToOneThousandOfNumbersWhichDevidesOnChoosenNum(int num)
        {
            if (num < 1 || num > 1000)
            {
                throw new Exception("Number is not in range");
            }
            int count = 0;
            for (int i = num; i < 1000; i += num)
            {
                count++;
            }
            int index = 0;
            int[] arr = new int[count];
            for (int i = num; i < 1000; i += num)
            {
                arr[index] = i;
                index++;
            }
            return arr;
        }
        public static void WriteAllElementsInIntArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        
        static int CountItemsForCreatingArr(int num)
        {
            int count = 0;
            int tmp1 = 1;
            while (tmp1 <= num)
            {
                int even = 0;
                int odd = 0;
                int tmp2 = tmp1;
                while (tmp2 != 0)
                {
                    if (tmp2 % 2 == 0)
                    {
                        even += tmp2 % 10;
                    }
                    else
                    {
                        odd += tmp2 % 10;
                    }
                    tmp2 /= 10;
                }
                if (even > odd)
                {
                    count++;
                }
                tmp1++;
            }
            return count;
        }
        public static int[] GetNumbersInRangeFromOneToChoosenNumWhereSumOfEvenMoreThanSumOfOdd(int num)
        {
            if (num < 1)
            {
                throw new Exception("num > 1");
            }

            int arrLenght = CountItemsForCreatingArr(num);
            int[] arr = new int[arrLenght];
            int tmp1 = 1;
            int indexArr = 0;

            while (tmp1 <= num)
            {
                int even = 0;
                int odd = 0;
                int tmp2 = tmp1;
                while (tmp2 != 0)
                {
                    if (tmp2 % 2 == 0)
                    {
                        even += tmp2 % 10;
                    }
                    else
                    {
                        odd += tmp2 % 10;
                    }
                    tmp2 /= 10;
                }
                if (even > odd)
                {
                    arr[indexArr] = tmp1;
                    indexArr++;
                }
                tmp1++;
            }

            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class UserInterface
    {
        public static string ChooseTask()
        {
            Console.WriteLine("Choose homework and task");
            Console.WriteLine("Example: to reach first task of second homework type {number of homework}.{number of task} (2.1)");
            Console.Write("Type here: ");
            string task = Console.ReadLine();
            if (task == "")
            {
                task = "repeat";
                Console.Beep();
            }
            return task;
        }
    }
    static class Homework1
    {
        public static int GetSolution(int a, int b)
        {
            int res = (5 * a + b * b) / (b - a);
            return res;
        }

        public static int GetSolveOfLinearEquation(int a, int b, int c)
        {
            int res = (c - b) / a;
            return res;
        }

        public static string GetEquationOfStraightLine(int x1, int y1,int x2,int y2)
        {
            double tmp1 = (double)(y1 - y2) / (x2 - x1);
            double tmp2 = (double)((y2 - y1) * x1) / (x2 - x1);
            tmp1 *= -1;
            tmp2 += -1;

            string res = "";

            if (tmp2 == 0 && tmp1 == 0)
            {
                res = "Y = 0";
            }
            else if (tmp2 == 0)
            {
                res = $"Y = {tmp1}X";
            }
            else if (tmp1 == 0)
            {
                res = $"Y = {tmp2}";
            }
            else
            {
                res = $"Y = {tmp1}x + {tmp2}";
            }

            return res;
        }
    }

    static class Homework2
    {
        public static int IfBoolDoMath(int a, int b)
        {
            int res = 0;

            if (a > b)
            {
                res = a + b;
            }
            else if (a == b)
            {
                res = a * b;
            }
            else if (a < b)
            {
                res = a - b;
            }

            return res;
        }
        public static string WhichQuarter(int x, int y)
        {
            string res = "";

            if (x > 0 && y > 0)
            {
                res = "Точка в 1-ой четверти";
            }
            else if (x < 0 && y > 0)
            {
                res = "Точка в 2-ой четверти";
            }
            else if (x < 0 && y < 0)
            {
                res = "Точка в 3-ой четверти";
            }
            else if (x > 0 && y < 0)
            {
                res = "Точка в 4-ой четверти";
            }
            return res;
        }
        public static string StringifyNum(int num)
        {
            string isMinus = "";
            string firstWord = "";
            string secondWord = "";
            string res = "";

            if (num < 0)
            {
                num *= -1;
                isMinus = "Минус ";
            }

            if (num < 20)
            {
                switch (num)
                {
                    case 10: firstWord = "Десять"; break;
                    case 11: firstWord = "Одиннадцать"; break;
                    case 12: firstWord = "Двенадцать"; break;
                    case 13: firstWord = "Тринадцать"; break;
                    case 14: firstWord = "Четырнадцать"; break;
                    case 15: firstWord = "Пятнадцать"; break;
                    case 16: firstWord = "Шестнадцать"; break;
                    case 17: firstWord = "Семьнадцать"; break;
                    case 18: firstWord = "Восемьнадцать"; break;
                    case 19: firstWord = "Девятнадцать"; break;
                }
                res = $"{isMinus}{firstWord}";
            }
            else
            {
                switch (num - (num % 10))
                {
                    case 20: firstWord = "Двадцать"; break;
                    case 30: firstWord = "Тридцать"; break;
                    case 40: firstWord = "Сорок"; break;
                    case 50: firstWord = "Пятьдесят"; break;
                    case 60: firstWord = "Шестьдесят"; break;
                    case 70: firstWord = "Семьдесят"; break;
                    case 80: firstWord = "Восемьдесят"; break;
                    case 90: firstWord = "Девяносто"; break;
                    default: firstWord = "Ops! Something went wrong."; break;
                }
                switch (num % 10)
                {
                    case 0: secondWord = ""; break;
                    case 1: secondWord = "один"; break;
                    case 2: secondWord = "два"; break;
                    case 3: secondWord = "три"; break;
                    case 4: secondWord = "четыре"; break;
                    case 5: secondWord = "пять"; break;
                    case 6: secondWord = "шесть"; break;
                    case 7: secondWord = "семь"; break;
                    case 8: secondWord = "восемь"; break;
                    case 9: secondWord = "девять"; break;
                    default: secondWord = ""; break;
                }
                res = $"{isMinus}{firstWord} {secondWord}";
            
            }
            return res;
        }
    }
    static class Homework3
    {
        public static int AscensionToTheDegree(int a, int b)
        {
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
            while (check*check < a)
            {
                check++;
            }
            return check;
        }
        public static int FindTheBiggestDevider(int a)
        {
            int devider = a - 1;
            while (a%devider != 0)
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
                int change = b;
                b = a;
                a = change;
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
            int firstFibonacciNum = 1;
            int secondFibonacciNum= 1; 
            int actualFibonacciNum =  1;
            
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
    }
}

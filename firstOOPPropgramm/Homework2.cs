using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    public static class Homework2
    {
        public static int DoMathIfBool(int a, int b)
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
        public static string GetWhichQuarter(int x, int y)
        {
            string res = "";

            if (x == 0 || y == 0)
            {
                throw new Exception("It's Impossible to define quarter because x or y are equals zero");
            }
            else if (x > 0 && y > 0)
            {
                res = "I";
            }
            else if (x < 0 && y > 0)
            {
                res = "II";
            }
            else if (x < 0 && y < 0)
            {
                res = "III";
            }
            else if (x > 0 && y < 0)
            {
                res = "IV";
            }
            return res;
        }
        public static string StringifyNum(int num)
        {
            string isMinus = "";
            string firstWord = "";
            string secondWord = "";
            string res = "";

            if ((num >= -9 && num <= 9) || (num < -99 || num > 99))
            {
                throw new Exception("Number is not in raange");
            }

            if (num < 0)
            {
                num *= -1;
                isMinus = "Минус ";
            }
            if (num < 20)
            {
                switch (num)
                {
                    case 10:
                        firstWord = "Десять";
                        break;
                    case 11:
                        firstWord = "Одиннадцать";
                        break;
                    case 12:
                        firstWord = "Двенадцать";
                        break;
                    case 13:
                        firstWord = "Тринадцать";
                        break;
                    case 14:
                        firstWord = "Четырнадцать";
                        break;
                    case 15:
                        firstWord = "Пятнадцать";
                        break;
                    case 16:
                        firstWord = "Шестнадцать";
                        break;
                    case 17:
                        firstWord = "Семьнадцать";
                        break;
                    case 18:
                        firstWord = "Восемьнадцать";
                        break;
                    case 19:
                        firstWord = "Девятнадцать";
                        break;
                }
                res = $"{isMinus}{firstWord}";
            }
            else
            {
                switch (num - (num % 10))
                {
                    case 20:
                        firstWord = "Двадцать";
                        break;
                    case 30:
                        firstWord = "Тридцать";
                        break;
                    case 40:
                        firstWord = "Сорок";
                        break;
                    case 50:
                        firstWord = "Пятьдесят";
                        break;
                    case 60: 
                        firstWord = "Шестьдесят";
                        break;
                    case 70:
                        firstWord = "Семьдесят";
                        break;
                    case 80:
                        firstWord = "Восемьдесят";
                        break;
                    case 90:
                        firstWord = "Девяносто";
                        break;
                }
                switch (num % 10)
                {
                    case 0:
                        secondWord = "";
                        break;
                    case 1:
                        secondWord = "один";
                        break;
                    case 2:
                        secondWord = "два";
                        break;
                    case 3:
                        secondWord = "три";
                        break;
                    case 4:
                        secondWord = "четыре";
                        break;
                    case 5:
                        secondWord = "пять";
                        break;
                    case 6:
                        secondWord = "шесть";
                        break;
                    case 7:
                        secondWord = "семь";
                        break;
                    case 8:
                        secondWord = "восемь";
                        break;
                    case 9:
                        secondWord = "девять";
                        break;
                }
                res = $"{isMinus}{firstWord} {secondWord}";

            }
            return res;
        }
        public static int[] GetFromLessToBiggest(int a, int b, int c)
        {
            int[] outputArr = new int[3];
            if ((a >= b && a >= c) && (b >= c))
            {
                PullInToArray(c, b, a, outputArr);
            }
            else if ((a >= b && a >= c) && (c >= b))
            {
                PullInToArray(b, c, a, outputArr);
            }
            else if ((b >= a && b >= c) && (a >= c))
            {
                PullInToArray(c, a, b, outputArr);
            }
            else if ((b >= a && b >= c) && (c >= a))
            {
                PullInToArray(a, c, b, outputArr);
            }
            else if ((c >= a && c >= b) && (a >= b))
            {
                PullInToArray(b, a, c, outputArr);
            }
            else if ((c >= a && c >= b) && (b >= a))
            {
                PullInToArray(a, b, c, outputArr);
            }
            return outputArr;
        }

        public static double[] GetResultOfQuadraticEquation(int a, int b, int c)
        {
            double dis = FindDiscriminant(a, b, c);
            double[] res = new double[2];
            if (dis > 0)
            {
                res[0] = FindFirstResultOfQuadraticEquationIfDiscriminantIsMoreThanZero(a, b, dis);
                res[1] = FindSecondResultOfQuadraticEquationIfDiscriminantIsMoreThanZero(a, b, dis);
            }
            else if (dis == 0)
            {
                res[0] = FindResultOfQuadraticEquationIfDiscriminantIsEqualZero(a,b);
                res[1] = res[0];
            }
            return res;
        }
        static double FindFirstResultOfQuadraticEquationIfDiscriminantIsMoreThanZero(int a, int b, double dis)
        {
            if (a == 0)
            {
                throw new Exception("<a> can't be equals zero");
            }
            else
            {
                return ((-1 * b) + Math.Sqrt(dis)) / (2 * a);
            }
        }
        static double FindSecondResultOfQuadraticEquationIfDiscriminantIsMoreThanZero(int a, int b, double dis)
        {
            if (a == 0)
            {
                throw new Exception("<a> can't be equals zero");
            }
            else
            {
                return ((-1 * b) - Math.Sqrt(dis)) / (2 * a);
            }
        }
        static double FindResultOfQuadraticEquationIfDiscriminantIsEqualZero(int a, int b)
        {
            if (a == 0)
            {
                throw new Exception("<a> can't be zero");
            }
            else
            {
                return (-1 * b) / (2 * a);
            }
        }

        static double FindDiscriminant(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        static void PullInToArray(int less, int  mid, int biggest, int[] arr)
        {
            arr[0] = less;
            arr[1] = mid;
            arr[2] = biggest;
        }
    }
}

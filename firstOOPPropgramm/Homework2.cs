using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class Homework2
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

            if ((num > -9 && num < 9) || (num < -99 && num > 99))
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
                    default:
                        firstWord = "Ops! Something went wrong.";
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
                    default:
                        secondWord = "";
                        break;
                }
                res = $"{isMinus}{firstWord} {secondWord}";

            }
            return res;
        }
        public static void GetFromLessToBiggest(int a, int b, int c, out int o1, out int o2, out int o3)
        {
            o1 = 0;
            o2 = 0;
            o3 = 0;
            if ((a >= b && a >= c) && (b >= c))
            {
                o1 = c;
                o2 = b;
                o3 = a;
            }
            else if ((a >= b && a >= c) && (c >= b))
            {
                o1 = b;
                o2 = c;
                o3 = a;
            }
            else if ((b >= a && b >= c) && (a >= c))
            {
                o1 = c;
                o2 = a;
                o3 = b;
            }
            else if ((b >= a && b >= c) && (c >= a))
            {
                o1 = a;
                o2 = c;
                o3 = b;
            }
            else if ((c >= a && c >= b) && (a >= b))
            {
                o1 = b;
                o2 = a;
                o3 = c;
            }
            else if ((c >= a && c >= b) && (b >= a))
            {
                o1 = a;
                o2 = b;
                o3 = c;
            }
        }

        public static double FindFirstResultOfQuadraticEquationIfDiscriminantIsMoreThanZero(int a, int b, double dis)
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
        public static double FindSecondResultOfQuadraticEquationIfDiscriminantIsMoreThanZero(int a, int b, double dis)
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
        public static double FindResultOfQuadraticEquationIfDiscriminantIsEqualZero(int a, int b)
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

        public static double FindDiscriminant(int a, int b, int c)
        {
            if ((b * b - 4 * a * c) < 0)
            {
                throw new Exception("Discriminant can't be zero");
            }
            else
            {
                return b * b - 4 * a * c;
            }
        }
    }
}

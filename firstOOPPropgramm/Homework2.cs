using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    public static class Homework1
    {
        public static double GetSolution(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("<a> can't be equal <b>");
            }
            else
            {
                double res = (5 * a + b * b) / (b - a);
                return res;
            }
        }

        public static int GetSolveOfLinearEquation(int a, int b, int c)
        {
            if (a == 0 || b ==0 || c == 0)
            {
                throw new Exception("arguments can't be equal 0");
            }
            else
            {
                int res = (c - b) / a;
                return res;
            }
            
        }

        public static string GetEquationOfStraightLine(int x1, int y1, int x2, int y2)
        {
            if (x2 == x1)
            {
                throw new Exception("<x1> can't be equal <x2>");
            }
            else if (y1 == y2)
            {
                throw new Exception("<y1> can't be equal <y2>");
            }
            else
            {
                double tmp1 = ((double)(y1 - y2) / (x2 - x1))*-1;
                double tmp2 = ((double)((x1*y2) - (x2*y1))/(x2-x1))*-1;

                string res = "";

                
                if (tmp2 == 0)
                {
                    res = $"y = {tmp1}x";
                }
                else
                {
                    res = $"y = {tmp1}x + {tmp2}";
                }

                return res;
            }
        }
        public static int GetResultOfDivison(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b haven't to be zero");
            }
            else
            {
                return a / b;
            }
        }
        public static int GetRemainderOfDivison(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b haven't to be zero");
            }
            else
            {
                return a % b;
            }
        }
        public static void SwapStrings(ref string a, ref string b)
        {
            string swap = a;
            a = b;
            b = swap;
        }
        public static void SwapNums(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
    }
}

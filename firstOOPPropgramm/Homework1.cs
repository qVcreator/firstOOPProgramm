﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
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

        public static string GetEquationOfStraightLine(int x1, int y1, int x2, int y2)
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
    }
}

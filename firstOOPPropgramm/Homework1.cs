﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class Homework1
    {
        public static string ChooseTask()
        {
            Console.WriteLine("Choose homework and task");
            Console.WriteLine("Example: to reach first task of first homework type 1.1");
            Console.Write("Type here: ");
            string task = Console.ReadLine();
            if (task == "")
            {
                task = "repeat";
            }
            return task;
        }
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
    }
}

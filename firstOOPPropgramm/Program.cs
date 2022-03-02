﻿using FirstOOPPropgramm;

string actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
bool isKeepWork = true;

while (isKeepWork == true)
{
    if (actualTask == "0")
    {
        isKeepWork = false;
    }
    else if (actualTask == "1.2")
    {
        Console.Write("Введите число а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resHomework1_2 = FirstOOPPropgramm.Homework1.GetSolution(a, b);

        Console.WriteLine($"Solution is {resHomework1_2}");

        actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
    }
    else if (actualTask == "1.4")
    {
        Console.Write("Введите число а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int resHomework1_4 = FirstOOPPropgramm.Homework1.GetSolveOfLinearEquation(a, b, c);

        Console.WriteLine($"Solution is {resHomework1_4}");

        actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
    }
    else if (actualTask == "1.5")
    {
        Console.Write("Введите число X1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число Y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число X2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число Y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        string resHomework1_5 = FirstOOPPropgramm.Homework1.GetEquationOfStraightLine(x1, y1, x2, y2);

        Console.WriteLine($"Answer is {resHomework1_5}");

        actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
    }
    else if (actualTask == "repeat")
    {
        actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
    }
    else if (actualTask == "clear")
    {
        Console.Clear();
        actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
    }
}


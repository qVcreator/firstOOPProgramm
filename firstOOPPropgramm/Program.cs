using FirstOOPPropgramm;

string actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
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

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
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

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
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

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "2.1")
    {
        Console.Write("Введите число а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resHomework2_1 = FirstOOPPropgramm.Homework2.IfBoolDoMath(a, b);

        Console.WriteLine($"The result is {resHomework2_1}");

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "2.2")
    {
        Console.Write("Введите число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        string resHomework2_2 = FirstOOPPropgramm.Homework2.WhichQuarter(x, y);

        Console.WriteLine(resHomework2_2);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "2.5")
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string stringifiedNum = FirstOOPPropgramm.Homework2.StringifyNum(num);

        Console.WriteLine(stringifiedNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.1")
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int numInDegree = FirstOOPPropgramm.Homework3.AscensionToTheDegree(a, b);

        Console.WriteLine(numInDegree);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.3")
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int counterOfLessNum = FirstOOPPropgramm.Homework3.FindLessThanSqureOfNum(a);

        Console.WriteLine(counterOfLessNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "repeat")
    {
        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "clear")
    {
        Console.Clear();
        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
}


using FirstOOPPropgramm;

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


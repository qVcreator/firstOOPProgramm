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

        int resHomework1 = FirstOOPPropgramm.Homework1.GetSolution(a, b);

        Console.WriteLine($"Solution is {resHomework1}");

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


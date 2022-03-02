using FirstOOPPropgramm;

string actualTask = FirstOOPPropgramm.Homework1.ChooseTask();
bool isKeepWork = true;

while (isKeepWork == true)
{
    if (actualTask == "0")
    {
        isKeepWork = false;
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


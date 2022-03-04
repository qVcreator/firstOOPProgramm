using FirstOOPPropgramm;

string actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
bool isKeepWork = true;

while (isKeepWork == true)
{
    if (actualTask == "0")
    {
        isKeepWork = false;
    }
    else if (actualTask == "1.1")
    {
        Console.WriteLine("Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.");
        Console.Write("Введите число а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        if (FirstOOPPropgramm.UserInterface.IsZero(b) == true)
        {
            Console.WriteLine($"\nb haven't to be zero, please try again");

            actualTask = "1.1";
        }
        else
        {
            int resOfDivision = FirstOOPPropgramm.Homework1.GetResultOfDivison(a, b);
            int remOfDivision = FirstOOPPropgramm.Homework1.GetRemainderOfDivison(a, b);

            Console.WriteLine($"Result of division is {resOfDivision}");
            Console.WriteLine($"Remainder of division is {remOfDivision}");

            actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
        }
    }
    else if (actualTask == "1.2")   
    {
        Console.WriteLine("Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*a+b^2)/(b-a)");
        Console.Write("Введите число а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resHomework1_2 = FirstOOPPropgramm.Homework1.GetSolution(a, b);
            
        Console.WriteLine($"Solution is {resHomework1_2}");

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "1.3")
    {
        Console.WriteLine("Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте содержимое переменных A и B местами.");
        Console.Write("Введите 1-ую строку: ");
        string a = Console.ReadLine();
        Console.Write("Введите 2-ую строку: ");
        string  b = Console.ReadLine();

        Console.WriteLine($"Before: a is <{a}> and b is <{b}>");
        FirstOOPPropgramm.Homework1.SwapStrings(ref a, ref b);
        Console.WriteLine($"After: a is <{a}> and b is <{b}>");
    }
    else if (actualTask == "1.4")
    {
        Console.WriteLine("Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.");
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
        Console.WriteLine("Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.");
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
        Console.WriteLine("Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.");
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
        Console.WriteLine("Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).");
        Console.Write("Введите число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        string resHomework2_2 = FirstOOPPropgramm.Homework2.WhichQuarter(x, y);

        Console.WriteLine(resHomework2_2);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "2.3")
    {
        Console.WriteLine("Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.");
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число c: ");
        int c = Convert.ToInt32(Console.ReadLine());      

        FirstOOPPropgramm.Homework2.GetFromLessToBiggest(a, b, c,out int firstNum, out int secondNum, out int thirdNum);
        string fromLessToBiggest = $"{firstNum} {secondNum} {thirdNum}";

        Console.WriteLine(fromLessToBiggest);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "2.4")
    {
        Console.WriteLine("Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX^2+BX+C=0.");
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        string res = "";

        double dis = FirstOOPPropgramm.Homework2.FindDiscriminant(a, b, c);
        if (dis > 0 && a != 0)
        {
            res = $"x1 = {FirstOOPPropgramm.Homework2.FindFirstResultOfQuadraticEquationIfDiscriminantIsMoreThanZero}\nx2 = {FirstOOPPropgramm.Homework2.FindSecondResultOfQuadraticEquationIfDiscriminantIsMoreThanZero}";
        }
        else if (dis == 0 && a != 0)
        {
            res = $"x1,2 = {FirstOOPPropgramm.Homework2.FindResultOfQuadraticEquationIfDiscriminantIsEqualZero}";
        }
        else if (a == 0)
        {
            Console.WriteLine("a=0 try again...");
            actualTask = "2.4";
            
        }
        else if (dis < 0)
        {
            Console.WriteLine("Equation have no any result");
            actualTask = "2.4";
            
        }
    }
    else if (actualTask == "2.5")
    {
        Console.WriteLine("Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.");
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string stringifiedNum = FirstOOPPropgramm.Homework2.StringifyNum(num);

        Console.WriteLine(stringifiedNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.1")
    {
        Console.WriteLine("Пользователь вводит 2 числа (A и B). Возвести число A в степень B.");
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
        Console.WriteLine("Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.");
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int counterOfLessNum = FirstOOPPropgramm.Homework3.FindLessThanSqureOfNum(a);

        Console.WriteLine(counterOfLessNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.4")
    {
        Console.WriteLine("Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.");
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int biggestDevider = FirstOOPPropgramm.Homework3.FindTheBiggestDevider(a);

        Console.WriteLine(biggestDevider);  

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.5")
    {
        Console.WriteLine("Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).");
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int summOfNumsWhichDevidesBySeven = FirstOOPPropgramm.Homework3.GetSummInRangeOfNumbersWhichDevidesBySeven(a, b);

        Console.WriteLine(summOfNumsWhichDevidesBySeven);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.6")
    {
        Console.WriteLine("Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.");
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int fibonacciNum = FirstOOPPropgramm.Homework3.GetNumberOfFibonacciSeries(num);

        Console.WriteLine(fibonacciNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.7")
    {
        Console.WriteLine("Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.");
        Console.Write("Введите 1-ое число: ");
        int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Введите 2-ое число: ");
        int num2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int res = FirstOOPPropgramm.Homework3.GetСommonDivisorOfTwoNumbersByEuclidsAlgoritm(num1, num2);

        Console.WriteLine(res);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.8")
    {
        Console.WriteLine("Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.");
        Console.Write("Введите число: ");
        int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int resNum = FirstOOPPropgramm.Homework3.GetNumByHalfDevisionMethod(num);

        Console.WriteLine(resNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.9")
    {
        Console.WriteLine("Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.");
        Console.Write("Введите число: ");
        int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int quantityOdd = FirstOOPPropgramm.Homework3.FindQuantityOddNumbers(num);

        Console.WriteLine(quantityOdd);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.10")
    {
        Console.WriteLine("Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.");
        Console.Write("Введите число: ");
        int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        int MirrorNum = FirstOOPPropgramm.Homework3.GetReverseNum(num);

        Console.WriteLine(MirrorNum);

        actualTask = FirstOOPPropgramm.UserInterface.ChooseTask();
    }
    else if (actualTask == "3.12")
    {
        Console.WriteLine("Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.");
        Console.Write("Введите 1-ое число: ");
        int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Введите 2-ое число: ");
        int num2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        bool isSame = FirstOOPPropgramm.Homework3.IsNumbersHaveSameDigit(num1, num2);

        string res = "";

        if (isSame == true)
        {
            res = "ДА";
        }
        else
        {
            res = "НЕТ";
        }

        Console.WriteLine(res);

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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class UserInterface
    {
        public static string ChooseTask()
        {
            Console.WriteLine();
            Console.WriteLine("Choose homework and task");
            Console.WriteLine("Example: to reach first task of second homework type {number of homework}.{number of task} (2.1)");
            Console.Write("Type here: ");
            string task = Console.ReadLine();
            Console.WriteLine();
            if (task == "")
            {
                task = "repeat";
                Console.Beep();
            }
            return task;
        }

        public static bool IsZero(int a)
        {
            bool res = false;
            if (a == 0)
            {
                res = true;
            }
            return res;
        }
    }
}

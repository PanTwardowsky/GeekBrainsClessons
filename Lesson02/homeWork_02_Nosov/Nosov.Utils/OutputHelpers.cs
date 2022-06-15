using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nosov.Utils
{
    public class OutputHelpers
    {
        public static void PrintInfo(int HomeworkNumber, string fio)
        {
            Console.WriteLine($"Домашняя работа. Урок {HomeworkNumber}");
            Console.WriteLine($"Студент: {fio}");
            Console.WriteLine($"=================================");
        }


    }
}

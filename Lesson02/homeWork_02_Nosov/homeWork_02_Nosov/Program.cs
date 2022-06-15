using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nosov.Utils;




// Nosov Roman Gennad'evich Lesson02

namespace homeWork_02_Nosov
{
    internal class Program
    {

        #region Задание 1

        //Написать метод, возвращающий минимальное из трёх чисел.


        static void Task01()
        {
            Console.WriteLine("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int minNumber;
            int helpNumber;

            helpNumber = firstNumber < secondNumber ? firstNumber : secondNumber;
            minNumber = helpNumber < thirdNumber ? helpNumber : thirdNumber;

            Console.WriteLine("Минимальное число {0}", minNumber);
            Console.ReadKey();
        }

        #endregion

        #region Задание 2

        //Написать метод подсчета количества цифр числа.

        static void Task02()
        {
            Console.WriteLine("Введите любое целое число: ");
            int mainNumber = int.Parse(Console.ReadLine());

            int count = 0;

            while (mainNumber != 0)
            {
                mainNumber /= 10;
                count++;

            }

            Console.WriteLine("В вашем числе {0} цифр", count);

            Console.ReadKey();

        }

        #endregion

        #region Задание 3

        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

        static void Task03()
        {

            Console.WriteLine("Введите любое целое число: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;


            while (number != 0)
            {
                if (number > 0 && number % 2 != 0)
                {
                    sum += number;
                }
                Console.WriteLine("Введите еще целое число: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Сумма чисел равна {0}", sum);
            Console.ReadKey();
        }

        #endregion

        #region Задание 4


        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.

        static bool Task04()
        {
            string login = "root";
            string password = "GeekBrains";

            int count = 0;

            do
            {
                Console.WriteLine("Введите логин: \n");
                string checkLogin = Console.ReadLine();

                Console.WriteLine("\nВведите пароль: \n");
                string checkPassword = Console.ReadLine();


                count++;

                if (login == checkLogin && password == checkPassword) //в джаве нельзя так строки сравнивать, но в интернете для C# рекомендуют именно так 
                {
                    Console.WriteLine("\nПривет, друг");
                    return true;
                }

                Console.WriteLine("\nНеверно. Попробуйте еще раз\n");
            }
            while (count != 3);
            Console.WriteLine("\nВы превысили количество попыток");
            Console.ReadKey();
            return false;
        }

        #endregion

        #region Задание 5

        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        public static void Task05()
        {
            Console.WriteLine("Введите ваш рост \n");
            double Height = double.Parse(Console.ReadLine());

            Height = Height / 100;

            Console.WriteLine("\nВведите ваш вес в килограммах \n");
            double Weight = double.Parse(Console.ReadLine());

            double Res = Weight / Math.Pow((Height), 2);

            double bmiMin = 18;
            double bmiMax = 25;

            double mass_opt = 0;
            double resultBMI = 0;

            int bmiSwitch = 0;



            if (Res > bmiMax)
            {
                bmiSwitch = 1;
            }
            else if (Res < bmiMin)
            {
                bmiSwitch = 2;
            }

            switch (bmiSwitch)
            {
                case 1:
                    mass_opt = bmiMax * (Height * Height);
                    resultBMI = Math.Abs(Weight - mass_opt);
                    Console.WriteLine("\nВаш индекс массы тела равен {0:F2}. Вы тяжелы.", Res);
                    Console.WriteLine("Вам надо похудеть на {0:F2} килограмм", resultBMI);
                    Console.ReadKey();
                    break;
                case 2:
                    mass_opt = bmiMin * (Height * Height);
                    resultBMI = Math.Abs(Weight - mass_opt);
                    Console.WriteLine("\nВаш индекс массы тела равен {0:F2}. Вы слишком легкий.", Res);
                    Console.WriteLine("Вам стоит набрать ещё {0:F2} килограмм", resultBMI);
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("\nВаш индекс массы тела равен {0:F2}. Вы в норме.", Res);
                    Console.ReadKey();
                    break;
            }



        }

        #endregion

        #region Задание 7

        //Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).

        //Выглядит не очень красиво, но работу выполняет.

        static void fromAtoB(int start, int end)
        {
            if (start < end)
            {
                start++;
                if (start == end)
                {
                    Console.WriteLine("Ну, вот и всё, ребята!");
                    return;
                }
                Console.WriteLine(start);

                fromAtoB(start, end);
            }



        }

        static void Task07()

        {
            Console.WriteLine("Введите меньшее число \n");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите большее число \n");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nЧисла в промежутке:");
            fromAtoB(a, b);
            Console.ReadKey();
        }



        #endregion

        static void Main(string[] args)
        {

            OutputHelpers.PrintInfo(2, "Носов Роман Геннадьевич");
            Console.ReadKey();

            bool g = true;

            while (g)
            {


                Console.WriteLine("Мои задачи");
                Console.WriteLine("==============================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("7 -> Задача 7");
                Console.WriteLine("0 -> Завершение работы");
                Console.WriteLine("==============================================");
                Console.WriteLine("Введите номер задачи");
                int task = int.Parse(Console.ReadLine());

                switch (task)
                {

                    case 1:
                        Task01();
                        break;

                    case 2:
                        Task02();
                        break;

                    case 3:
                        Task03();
                        break;

                    case 4:
                        Task04();
                        break;

                    case 5:
                        Task05();
                        break;

                    case 7:
                        Task07();
                        break;

                    case 0:
                        g = false;
                        Console.WriteLine("Завершаем работу");
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи. \nПовторите ввод");
                        break;


                }

                Console.ReadKey();




            }



        }
    }
}

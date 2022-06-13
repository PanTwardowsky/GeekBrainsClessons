using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Nosov Roman Gennad'evich

namespace homeWork_01_Nosov
{
    internal class HomeWork_01
    {
        static void Profile()
        {
            string FirstName;
            string LastName;
            int Age;
            int Height;
            double Weight;

            Console.WriteLine("Введите Ваше имя");
            FirstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию");
            LastName = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст");
            string AgeStr = Console.ReadLine();
            Age = int.Parse(AgeStr);

            Console.WriteLine("Введите Ваш рост");
            string HeightStr = Console.ReadLine();
            Height = int.Parse(HeightStr);

            Console.WriteLine("Введите Ваш вес");
            string WeightStr = Console.ReadLine();
            Weight = double.Parse(WeightStr);


            //Вывод данных на экран
            //1 способ

            Console.WriteLine(FirstName + " " + LastName + " " + Age + " " + Height + " " + Weight);

            //2 способ

            Console.WriteLine("{0} {1} {2} {3} {4}", FirstName, LastName, Age, Height, Weight);

            //3 способ

            Console.WriteLine($"{FirstName} {LastName} {Age} {Height} {Weight}");


        }

        static void BMI()
        {
            double Height;
            double Weight;
            double Res;

            Console.WriteLine("Введите Ваш рост в метрах");
            string HeightStr = Console.ReadLine();
            Height = double.Parse(HeightStr);

            Console.WriteLine("Введите Ваш вес в килограммах");
            string WeightStr = Console.ReadLine();
            Weight = double.Parse(WeightStr);

            Res = Weight / (Height * Height);

            Console.WriteLine("Ваш результат {0:F2}", Res);
        }

        static void Coordinates()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double CalcRes;

            Console.WriteLine("Введите координату X первой точки");
            string x1Str = Console.ReadLine();
            x1 = double.Parse(x1Str);

            Console.WriteLine("Введите координату Y первой точки");
            string y1Str = Console.ReadLine();
            y1 = double.Parse(y1Str);

            Console.WriteLine("Введите координату X второй точки");
            string x2Str = Console.ReadLine();
            x2 = double.Parse(x2Str);

            Console.WriteLine("Введите координату Y второй точки");
            string y2Str = Console.ReadLine();
            y2 = double.Parse(y2Str);

            CalcRes = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Ваш результат {0:F2}", CalcRes);

        }


        static void Exchange()
        {
            int Number1;
            int Number2;
            int NumberHelp;

            Console.WriteLine("Введите первое число");
            string Number1Str = Console.ReadLine();
            Number1 = int.Parse(Number1Str);

            Console.WriteLine("Введите второе число");
            string Number2Str = Console.ReadLine();
            Number2 = int.Parse(Number2Str);

            NumberHelp = Number1;
            Number1 = Number2;
            Number2 = NumberHelp;

            Console.WriteLine("Совершаем подмену и получаем {0} и {1}", Number1, Number2);

        }

        static void MyData(string FirstName, string LastName, string HomeCity)
        {
            //Способ найден в сети Интернет. Не вижу тут ничего плохого.
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("{0} {1} {2}", FirstName, LastName, HomeCity);

        }

        static void Main(string[] args)
        {
            //profile();

            //BMI();

            // Coordinates();

            //Exchange();

            //MyData("Роман", "Носов", "Санкт-Петербург");



        }
    }
}

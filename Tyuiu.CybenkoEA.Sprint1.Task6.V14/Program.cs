using Tyuiu.CybenkoEA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.CybenkoEA.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #1                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                *");
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #14                                                   *");
            Console.WriteLine("* Выполнил : Цыбенко Евгений Андреевич | ИИПБ-25-            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение               *");
            Console.WriteLine("* и печатает результат на экране                                *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("Введите текст:");
            string value = Console.ReadLine();
            var checker = new DataService();
            if (checker.CheckLowerCaseRusLetters(value))
            {
                Console.WriteLine("Строка состоит только из строчных русских букв.");
            }
            else
            {
                Console.WriteLine("Строка содержит символы, отличные от строчных русских букв.");
            }
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(ds.CheckLowerCaseRusLetters(value));
            Console.ReadKey();
        }
    }
}
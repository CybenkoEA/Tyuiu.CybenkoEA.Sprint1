using Tyuiu.CybenkoEA.Sprint1.Task4.V18.Lib;
namespace Tyuiu.CybenkoEA.Sprint1.Task4.V18
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Цыбенко Е. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение х: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение у: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(("(Sqrt(3+x))/(x*y)^2 = " + ds.Calculate(x, y)));
            Console.ReadKey();


        }
    }
}







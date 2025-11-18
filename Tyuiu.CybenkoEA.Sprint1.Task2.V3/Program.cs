using Tyuiu.CybenkoEA.Sprint1.Task2.V3.Lib;
namespace Tyuiu.CybenkoEA.Sprint1.Task2.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Цыбенко Е. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: #1.2 Арифметические операторы в C#                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные          *");
            Console.WriteLine("* данные,выполняет указанные расчёты и печатает результат на экране        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x;
            Console.WriteLine("Введите значение x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Часы в минуты = " + ds.ConvertHourToMin(x));
            Console.ReadLine();
        }
    }




}
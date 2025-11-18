using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.CybenkoEA.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public void Calculate()
        {
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double result = CalculateLogic(a, b, c);
            Console.WriteLine($"Результат: {result}");
        }

        public double CalculateLogic(double a, double b, double c)
        {
            return Math.Round((a * b) / (c * c), 3);
        }
    }
}
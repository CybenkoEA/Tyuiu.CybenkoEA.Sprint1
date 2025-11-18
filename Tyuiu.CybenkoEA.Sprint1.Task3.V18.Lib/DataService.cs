using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.CybenkoEA.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public void Calculate()
        {
            Console.WriteLine("Введите длину прямоугольника A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата C:");
            double c = Convert.ToDouble(Console.ReadLine());

            double result = CalculateLogic(a, b, c);
            Console.WriteLine($"Количество квадратов: {result}");
        }

        public double CalculateLogic(double a, double b, double c)
        {
            return Math.Round((a * b) / (c * c), 3);
        }
    }
}
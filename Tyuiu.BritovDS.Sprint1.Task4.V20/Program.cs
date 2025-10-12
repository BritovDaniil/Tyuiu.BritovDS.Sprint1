using System;
using Tyuiu.BritovDS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические выражения. Класс Math                              *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Бритов Д.С.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение выражения:               *");
            Console.WriteLine("* (1 + x) / |x - √(2 + y)|                                                *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x -> ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y -> ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}
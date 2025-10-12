using Tyuiu.BritovDS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Бритов Д.С. | Task5 | Вариант 1";
            Console.WriteLine("**********************************************");
            Console.WriteLine("* Спринт #1                                  *");
            Console.WriteLine("* Тема: Арифметические выражения             *");
            Console.WriteLine("* Задание #5                                 *");
            Console.WriteLine("* Вариант №1                                 *");
            Console.WriteLine("* Выполнил: Бритов Д.С.                      *");
            Console.WriteLine("**********************************************");
            Console.WriteLine("* Условие:                                   *");
            Console.WriteLine("* Найти расстояние между точками (x1, y1)    *");
            Console.WriteLine("* и (x2, y2). Ответ округлить до целого.     *");
            Console.WriteLine("**********************************************");
            Console.WriteLine();

            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine($"Расстояние между точками = {result}");
            Console.WriteLine("**********************************************");
            Console.ReadKey();
        }
    }
}

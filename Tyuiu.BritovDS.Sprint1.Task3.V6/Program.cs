using Tyuiu.BritovDS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task3.V6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические выражения. Класс Math                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Бритов Д.С.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно).                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите расстояние до дачи (км) -> ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите расход бензина (л/100 км) -> ");
            double gasFlow = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цену бензина (руб/л) -> ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double result = ds.TravelCost(distance, gasFlow, gasPrice);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Поездка на дачу и обратно обойдется в {result} руб.");
            Console.WriteLine("***************************************************************************");
        }
    }
}

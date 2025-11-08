using Tyuiu.BritovDS.Sprint1.Task7.V2.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.Title = "Спринт #1 | Выполнил: Бритов Д. С. | ИСПб-25-1";
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                 *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                   *");
            Console.WriteLine("* Задание #7                                                                                *");
            Console.WriteLine("* Вариант #2                                                                                *");
            Console.WriteLine("* Выполнил: Бритов Даниил Сергеевич | ИСПб-25-1                                             *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные                    *");
            Console.WriteLine("* и вычисляет результат по формуле:sin(x)+cos(y)/cos(x)-sin(y)*tg(x*y)                      *");
            Console.WriteLine("*                                                                                           *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                          *");
            Console.WriteLine("*********************************************************************************************");

            double x, y;
            Console.WriteLine("Введите первое значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение y:");
            y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
using Tyuiu.BritovDS.Sprint1.Task6.V13.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Бритов Д.С. | ТИУ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Проверка упорядоченности букв по алфавиту                        *");
            Console.WriteLine("* Вариант 13                                                             *");
            Console.WriteLine("* Выполнил: Бритов Данил Сергеевич | группа ХХХХХХ                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();

            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            bool result = ds.CheckWordsAlphabet(input);

            Console.WriteLine();
            Console.WriteLine("Результат: " + (result ? "Буквы идут по алфавиту" : "Буквы не упорядочены"));
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
        }
    }
}

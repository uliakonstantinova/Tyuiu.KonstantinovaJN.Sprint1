using Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Lib;
using Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Lib.MinutesToHoursLibrary;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнила: Константинова Ю. Н. | ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество минут: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int minutes))
            {
                int hours = TimeConverter.MinutesToHours(minutes);
                Console.WriteLine($"Время в часах: {hours}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число.");
            }

            Console.ReadKey();
        }
    }
}
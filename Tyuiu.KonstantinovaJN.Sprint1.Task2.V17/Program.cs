using Tyuiu.KonstantinovaJN.Sprint1.Task2.V17.Lib;

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

            int x;
            Console.Write("Время в минутах:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Время в часах:" + ds.ConvertMinutesToHours(x));
            Console.ReadLine();
        }
    }
}
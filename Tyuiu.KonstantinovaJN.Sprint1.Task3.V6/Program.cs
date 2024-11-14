using Tyuiu.KonstantinovaJN.Sprint1.Task3.V6.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task3.V6
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            Console.WriteLine("Расстояние до дачи (км):" + distance);
            Console.WriteLine("Расход бензина (литров на 100 км пробега):" + gasFlow);
            Console.WriteLine("Цена литра бензина (руб.):" + gasPrice);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Поездка на дачу и обратно обойдется в:" + ds.TravelCost(distance, gasFlow, gasPrice) + "руб.");
           
            Console.ReadKey();
        }
    }
}
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            double res = time / 60 / 60;
            return (int)res;
        }
    }
}

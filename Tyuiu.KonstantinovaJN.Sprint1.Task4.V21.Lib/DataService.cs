using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task4.V21.Lib
{
    public class DataService : ISprint1Task4V21
    {
        public double Calculate(double x, double y)
        {
            double w = Math.Pow(1 + x, 2);
            double v = w - y;
            double r = v / (x + y);

            return Math.Round(r, 3);
        }
    }
}

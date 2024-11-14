using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KonstantinovaJN.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
            public double TravelCost(double distance, double gasFlow, double gasPrice)
            {
                double totalDistance = distance * 2;

                double fuelNeeded = totalDistance * gasFlow / 100;

                double tripCost = fuelNeeded * gasPrice;


                return Math.Round(tripCost, 2);
            }
    } 
}

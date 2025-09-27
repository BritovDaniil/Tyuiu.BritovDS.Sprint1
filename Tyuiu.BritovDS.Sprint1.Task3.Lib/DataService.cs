using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BritovDS.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            double cost = (gasFlow * (distance * 2) * gasPrice) / 100;
            return Math.Round(cost, 3);
        }
    }
}

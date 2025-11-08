using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BritovDS.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Sin(x) + Math.Cos(y);
            var res1 = Math.Cos(x) - Math.Sin(y);
            var res2 = Math.Tan(x * y);
            var res3 = res / res1;
            var res4 = res3 * res2;
            return Math.Round(res4, 3);
        }
    }
}
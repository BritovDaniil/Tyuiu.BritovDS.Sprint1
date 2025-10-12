namespace Tyuiu.BritovDS.Sprint1.Task5.V1.Lib
{
    public class DataService
    {
        public int Calculate(double x1, double y1, double x2, double y2)
        {
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return Convert.ToInt32(d);
        }
    }
}
using Tyuiu.BritovDS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression(
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;

            double expected = (1 + x) / System.Math.Abs(x - System.Math.Sqrt(2 + y));
            expected = System.Math.Round(expected, 3);

            double result = ds.Calculate(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}
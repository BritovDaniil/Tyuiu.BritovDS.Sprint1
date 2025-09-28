using Tyuiu.BritovDS.Sprint1.Task4.V20.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2, y = 3;
            double wait = Math.Round(3 / Math.Abs(2 - Math.Sqrt(5)), 3);

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
using Tyuiu.BritovDS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;

            double expected = 74.035;
            double result = ds.TravelCost(distance, gasFlow, gasPrice);

            Assert.AreEqual(expected, result);
        }
    }
}

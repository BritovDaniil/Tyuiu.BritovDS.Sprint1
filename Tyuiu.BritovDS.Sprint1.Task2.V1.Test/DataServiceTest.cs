using Tyuiu.BritovDS.Sprint1.Task2.V1.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            double res = ds.ConvertKmToM(x);
            Assert.AreEqual(0.622, res);
        }
    }
}

using Tyuiu.BritovDS.Sprint1.Task1.V4.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6, res);
        }
    }
}

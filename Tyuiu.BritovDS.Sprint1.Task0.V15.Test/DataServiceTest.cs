using Tyuiu.BritovDS.Sprint1.Task0.V15.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
        }
    }
}

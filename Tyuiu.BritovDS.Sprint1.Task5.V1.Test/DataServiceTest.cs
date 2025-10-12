using Tyuiu.BritovDS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDistance()
        {
            DataService ds = new DataService();
            int result = ds.DistanceBetweenDots(1, 2, 4, 6);
            Assert.AreEqual(5, result);
        }
    }
}
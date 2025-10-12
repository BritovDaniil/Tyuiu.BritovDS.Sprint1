using Tyuiu.BritovDS.Sprint1.Task6.V13.Lib;

namespace Tyuiu.BritovDS.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWordsAlphabet()
        {
            DataService ds = new DataService();
            bool result = ds.CheckWordsAlphabet("abc");
            Assert.AreEqual(true, result);
        }
    }
}

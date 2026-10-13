using Tyuiu.ZipunovIM.Sprint1.Task2.V1.Lib;
namespace Tyuiu.ZipunovIM.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            double res = ds.ConvertKmToM(x);
            Assert.AreEqual(9.654, res);
        }
    }
}
using Tyuiu.ZipunovIM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 30;
            Assert.AreEqual(Convert.ToInt32(Math.Floor(Math.Round((x / 30), 3))), ds.AngleToHoursMinutes(x));
        }
    }
}
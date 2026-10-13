using Tyuiu.ZipunovIM.Sprint1.Task7.V1.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculatevalid()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 2;
            double c = 3;
            Assert.AreEqual(ds.Calculate(a, b, c), 0.25);

        }
    }
}
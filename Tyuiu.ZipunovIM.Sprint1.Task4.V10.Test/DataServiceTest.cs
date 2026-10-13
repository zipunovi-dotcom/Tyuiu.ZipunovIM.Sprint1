using Tyuiu.ZipunovIM.Sprint1.Task4.V10.Lib;
namespace Tyuiu.ZipunovIM.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 70;

            var res = ds.Calculate(a);
            Assert.AreEqual(2.727, res);

        }
    }
}
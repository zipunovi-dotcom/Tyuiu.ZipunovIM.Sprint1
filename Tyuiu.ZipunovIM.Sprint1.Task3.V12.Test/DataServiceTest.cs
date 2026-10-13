using Tyuiu.ZipunovIM.Sprint1.Task3.V12.Lib;
namespace Tyuiu.ZipunovIM.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();


            double x = 3;
            double y = 4;
            var res = ds.TriangleArea(x, y);

            Assert.AreEqual(6, res);
        }
    }
}
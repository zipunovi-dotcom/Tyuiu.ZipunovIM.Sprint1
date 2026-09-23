
using Tyuiu.ZipunovIM.Sprint1.Task3.V12_Lib;
namespace Tyuiu.ZipunovIM.Sprint1.Task3.V12.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();


            double a = 3.0;
            double b = 4.0;
            double wait = 6.0;
            double res = ds.Calculate(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}
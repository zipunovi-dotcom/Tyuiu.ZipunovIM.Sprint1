namespace Tyuiu.ZipunovIM.Sprint1.Task2.V1.Test
{
    using Tyuiu.ZipunovIM.Sprint1.Task2.V1.Lib;
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
            int kilometers = 10;
            double wait = 6.215; 

            double res = ds.CalculateMiles(kilometers);

            Assert.AreEqual(wait, res);
        }
    }
}
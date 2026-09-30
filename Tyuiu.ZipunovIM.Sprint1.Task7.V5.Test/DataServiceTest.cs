using System;
using Tyuiu.ZipunovIM.Sprint1.Task7.V5.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task7.V5.Test
{
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double wait = Math.Round(Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2)), 3);

            double res = ds.Calculate(x);

            Assert.That(res, Is.EqualTo(wait));
        }
    }
}
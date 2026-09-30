using NUnit.Framework;
using System;
using Tyuiu.ZipunovIM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task5.V7.Test
{
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

         
            double f = 45.0;
            int wait = 1;

            int res = ds.Calculate(f);

            Assert.That(res, Is.EqualTo(wait));
        }
    }
}
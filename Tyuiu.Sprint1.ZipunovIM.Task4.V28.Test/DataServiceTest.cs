using System;
using Tyuiu.ZipunovIM.Sprint1.Task4.V28.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task4.V28.Test
{
    
    public class DataServiceTest
    {
       
        public void ValidCalculate()
        {
            DataService ds = new DataService();

          
            double x = 0;
            double y = 0;

         
            double wait = Math.Round(Math.Cos(60 * Math.PI / 2) / Math.Exp(0), 3);

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
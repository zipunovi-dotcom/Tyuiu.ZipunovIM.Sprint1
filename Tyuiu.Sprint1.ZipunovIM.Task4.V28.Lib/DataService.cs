using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZipunovIM.Sprint1.Task4.V28.Lib
{
   
    public class DataService
    {
        public double Calculate(double x, double y)
        {
          
            double res = Math.Cos(60 * Math.PI / 2) / Math.Exp(2 * x + y);

          
            return Math.Round(res, 3);
        }
    }
}
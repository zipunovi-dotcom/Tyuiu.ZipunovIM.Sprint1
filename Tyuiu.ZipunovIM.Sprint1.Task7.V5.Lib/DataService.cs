using System;

namespace Tyuiu.ZipunovIM.Sprint1.Task7.V5.Lib
{
    public class DataService
    {
        public double Calculate(double x)
        {
            double numerator = Math.Log(Math.Abs(Math.Cos(x)));
            double denominator = Math.Log(1 + Math.Pow(x, 2));

            double res = numerator / denominator;

            return Math.Round(res, 3);
        }
    }
}
using System;

namespace Tyuiu.ZipunovIM.Sprint1.Task2.V1.Lib
{
    public class DataService
    {
        public double CalculateMiles(int kilometers)
        {
            double miles = kilometers / 1.609;
            return Math.Round(miles, 3);
        }
    }
}
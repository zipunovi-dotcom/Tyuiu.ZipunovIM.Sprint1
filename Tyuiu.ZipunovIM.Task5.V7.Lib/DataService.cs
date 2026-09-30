using System;

namespace Tyuiu.ZipunovIM.Sprint1.Task5.V7.Lib
{
    public class DataService
    {
        public int Calculate(double f)
        {
            
            double hours = f / 30.0;
            return (int)Math.Floor(hours);
        }
    }
}
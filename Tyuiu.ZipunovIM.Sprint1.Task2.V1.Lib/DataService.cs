using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZipunovIM.Sprint1.Task2.V1.Lib
{
  
    public class DataService : ISprint1Task2V1
    {
        public double ConvertKmToM(int value)
        {
            double y = (value * 1.609);
            double res = Math.Round(y, 3);
            return res;
        }
    }
}
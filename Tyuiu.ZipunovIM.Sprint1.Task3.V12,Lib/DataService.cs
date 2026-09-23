namespace Tyuiu.ZipunovIM.Sprint1.Task3.V12_Lib
{
    public class DataService
    {

        public double Calculate(double a, double b)
        {
            // Формула площади прямоугольного треугольника: (a * b) / 2
            // Округляем результат до 3 знаков после запятой
            return Math.Round((a * b) / 2.0, 3);
        }
    }
}
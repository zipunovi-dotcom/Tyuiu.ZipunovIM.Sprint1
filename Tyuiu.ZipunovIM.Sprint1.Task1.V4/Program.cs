// See https://aka.ms/new-console-template for more information
using Tyuiu.ZipunovIM.Sprint1.Task1.V4.Lib;
// ЗАДАНИЕ 
// Написать программу которая запрашивает у пользователей исходные данные 
// Вычисляет результат по формуле  (x + y) / x * y;
namespace Tyuiu.ZipunovIM.Sprint1.Task1.V4;

    class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | ИИпб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Зипунов Игорь Михайлович | ИИпб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (x+y)/x*y и печатает его на экране.       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        double res = ds.Calculate(x, y);

        Console.WriteLine(res);
        Console.ReadLine();
    }
}

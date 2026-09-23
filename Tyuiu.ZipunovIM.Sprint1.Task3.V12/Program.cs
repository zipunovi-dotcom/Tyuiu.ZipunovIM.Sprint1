// See https://aka.ms/new-console-template for more information
using Tyuiu.ZipunovIM.Sprint1.Task3.V12_Lib;
namespace Tyuiu.ZipunovIM.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | Вариант #12 ИИпБ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание 3                                                               *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Зипунов И. М.  ИИпБ                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника   *");
            Console.WriteLine("* по длинам двух катетов. Ответ округлить до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину первого катета (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второго катета (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(a, b);

           
            Console.WriteLine("Площадь прямоугольного треугольника = " + res.ToString("F3"));

            Console.ReadKey();
        }
    }
}
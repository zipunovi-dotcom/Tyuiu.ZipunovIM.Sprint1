using System;
using Tyuiu.ZipunovIM.Sprint1.Task2.V1.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | Группа: ИИпб";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые операторы в C#                                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Зипунов И. М. | ИИпб                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известно расстояние в километрах. Вычислить расстояние в милях.         *");
            Console.WriteLine("* Округлить до 3 знаков после запятой.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите расстояние в километрах (целое число): ");
            int kilometers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

           
            double res = ds.CalculateMiles(kilometers);

            Console.WriteLine($"Расстояние в милях: {res}");
            Console.ReadKey();
        }
    }
}
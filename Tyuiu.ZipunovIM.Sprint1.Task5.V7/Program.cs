using System;
using Tyuiu.ZipunovIM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | Вариант 7 ИИПб";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #1                                                               *");
            Console.WriteLine("* Тема: Базовые алгоритмы и типы данных C#                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Зипунов И. М.     ИИПб                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h - полное количество часов прошедших от начала суток до     *");
            Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась *");
            Console.WriteLine("* на f градусов (0 < f < 360, f - вещественное число).                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите угол f (вещественное число от 0 до 360): ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(f);
            Console.WriteLine($"Полных часов прошло (h) = {result}");

            Console.ReadKey();
        }
    }
}
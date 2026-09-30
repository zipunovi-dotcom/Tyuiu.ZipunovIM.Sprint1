using System;
using Tyuiu.ZipunovIM.Sprint1.Task7.V5.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | Вариант 5 ИИПб 26-1                    ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #1                                                               *");
            Console.WriteLine("* Тема: Расчеты математических выражений в C#                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Зипунов И. М.      ИИПб 26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("* Формула: z = ln|cos x| / ln(1 + x^2)                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x);
            Console.WriteLine($"Результат выражения z = {result}");

            Console.ReadKey();
        }
    }
}
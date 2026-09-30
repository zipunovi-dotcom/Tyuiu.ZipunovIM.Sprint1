using System;
using Tyuiu.ZipunovIM.Sprint1.Task6.V8.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | Вариант 8 ИИПб";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Зипунов И. М.   ИИПб                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,   *");
            Console.WriteLine("* перенеся их первую букву в конец.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите строку текста: ");
            string text = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.MoveFirstLetterToEnd(text);
            Console.WriteLine($"Преобразованный текст: {result}");

            Console.ReadKey();
        }
    }
}
namespace Tyuiu.ZipunovIM.Sprint1.Task6.V8;

using Tyuiu.ZipunovIM.Sprint1.Task6.V8.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | ИИПб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #8                                                             *");
        Console.WriteLine("* Выполнил: Зипунов Игорь Максимович | ИИПб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#,которая переносит первую букву в конец*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите строку: ");
        string str = Console.ReadLine();
        Console.WriteLine("Перевёрнутое слово: " + ds.MoveLetterToEnd(str));
    }
}
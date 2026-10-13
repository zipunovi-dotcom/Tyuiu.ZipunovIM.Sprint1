using Tyuiu.ZipunovIM.Sprint1.Task7.V1.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | ИИПб-26-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Выполнил: Зипунов Игорь Максимович | ИИПб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, запросив данные у пользователя,            *");
            Console.WriteLine("* вычисляет результат по формуле:                                         *");
            Console.WriteLine("*       b + sqrt(b^2 + 4ac)                                               *");
            Console.WriteLine("* z =   -------------------  - a^3 * c + b^-2                             *");
            Console.WriteLine("*               2a                                                        *");
            Console.WriteLine("***************************************************************************");
            double a, b, c;
            Console.WriteLine("Введите а: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Z = {0}", ds.Calculate(a, b, c));
            Console.WriteLine(Math.E);
        }
    }
}
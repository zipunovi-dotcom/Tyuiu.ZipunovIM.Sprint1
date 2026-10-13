using Tyuiu.ZipunovIM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZipunovIM.Sprint1.Task5.V7

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Зипунов И. М. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование классов и тип Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Зипунов Игорь Максимович | ИИПб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня),*");
            Console.WriteLine("*когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:     x (вещ. число)                                     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 int          *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.AngleToHoursMinutes(x));
        }
    }
}
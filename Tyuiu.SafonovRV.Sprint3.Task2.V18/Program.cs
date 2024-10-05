using Tyuiu.SafonovRV.Sprint3.Task2.V18.Lib;

namespace Tyuiu.SafonovRV.Sprint3.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #3                                                            *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                        *");
            Console.WriteLine("* Задание #2                                                           *");
            Console.WriteLine("* Вариант #18                                                          *");
            Console.WriteLine("* Выполнил Сафонов Руслан Васильевич | АСОиУБ-24-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле, при X=1                                *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("* Формула                                                              *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

            int x = 1;
            int startValue = 1;
            int stopValue = 14;

            double result = dataService.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine($"Произведение ряда для X={x}, от {startValue} до {stopValue} равно: {result}");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}
        
    


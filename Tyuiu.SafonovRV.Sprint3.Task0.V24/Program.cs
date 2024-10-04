﻿using Tyuiu.SafonovRV.Sprint3.Task0.V24.Lib; 

namespace Tyuiu.SafonovRV.Sprint3.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #3                                                            *");
            Console.WriteLine("* Тема: Операторы составного присваивания                              *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #24                                                          *");
            Console.WriteLine("* Выполнил Сафонов Руслан Васильевич | АСОиУБ-24-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле, при X=5                                *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("* Формула                                                              *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

            int x = 5;
            int startValue = 1;
            int stopValue = 7;

            double result = dataService.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine($"Произведение ряда для X={x}, от {startValue} до {stopValue} равно: {result}");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}

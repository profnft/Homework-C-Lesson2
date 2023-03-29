// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

namespace WeekendChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
            string input = Console.ReadLine();
            int dayOfWeek;

            if (int.TryParse(input, out dayOfWeek) && dayOfWeek >= 1 && dayOfWeek <= 7)
            {
                if (dayOfWeek == 6 || dayOfWeek == 7)
                {
                    Console.WriteLine("Да, сегодня выходной");
                }
                else
                {
                    Console.WriteLine("Нет, сегодня еще работаем");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение. Пожалуйста, введите цифру от 1 до 7.");
            }
        }
    }
}

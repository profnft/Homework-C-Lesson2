// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

namespace SecondDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string input = Console.ReadLine(); 
            int number;

            if (int.TryParse(input, out number) && input.Length == 3)
            {
                int secondDigit = (int)Char.GetNumericValue(input[1]);
                Console.WriteLine("Вторая цифра числа: " + secondDigit);
            }
            else
            {
                Console.WriteLine("Введено некорректное число. Пожалуйста, введите трехзначное число.");
            }
        }
    }
}

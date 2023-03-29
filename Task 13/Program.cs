// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                if (input.Length >= 3)
                {
                    int thirdDigit = (int)Char.GetNumericValue(input[2]);
                    Console.WriteLine("Третья цифра числа: " + thirdDigit);
                }
                else
                {
                    Console.WriteLine("Третьей цифры нет");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное число");
            }
        }
    }
}

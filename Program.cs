// Боровикова Ирина, ДЗ5, задача 1

// Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов,
// содержащая только буквы латинского алфавита или цифры,
// при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) **с использованием регулярных выражений.

using System;
using System.Text.RegularExpressions;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Решение без регулярок

            Console.WriteLine("Введите логин: ");
            string inquiry = Console.ReadLine();

            bool correct = true;

            if (inquiry.Length < 2 || inquiry.Length > 20)
            {
                correct = false;
            }
            else if (Char.IsDigit(inquiry[0]))
            {
                correct = false;
            }
            else
            {
                for (int i = 0; i < inquiry.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(inquiry[i]))
                    {
                        correct = false;
                        break;
                    }
                }
            }

            if (correct == true)
            {
                Console.WriteLine("Логин корректен");
            }
            else
            {
                Console.WriteLine("Логин некорректен");
            }

            // Решение с регулярками

            Regex nicelog = new Regex("^[A-Za-z]{1}[A-Za-z0-9]{1,19}$");

            if (nicelog.Match(inquiry).Success)
            {
                Console.WriteLine("Логин корректен");
            }
            else
            {
                Console.WriteLine("Логин некорректен");
            }
        }
    }
}

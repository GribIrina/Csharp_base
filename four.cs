using System;

namespace HW1four
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ1, задача 4
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.

            Console.WriteLine("Введите переменную a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine($"Переменные: a = {a}, b = {b}");
        }
    }
}

using System;

namespace HW2one
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 1
            // Написать метод, возвращающий минимальное из трёх чисел.

            static int Gimmedata(string inquiry)
            {
                Console.WriteLine(inquiry);
                return int.Parse(Console.ReadLine());
            }

            int first = Gimmedata("Введите первое число");
            int second = Gimmedata("Введите второе число");
            int third = Gimmedata("Введите третье число");

            int res = first < second ? first : second;
            res = res < third ? res : third;

            Console.WriteLine($"Наименьшим числом является {res}");
        }
    }
}

using System;

namespace HW2two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 2
            // Написать метод подсчета количества цифр числа.

            static int NumCount(int number)
            {
                int count = 0;

                while (number != 0)
                {
                    number /= 10;
                    count++;
                }

                return count;
            }

            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Количество цифр в числе: {NumCount(num)}");




            

        }
    }
}

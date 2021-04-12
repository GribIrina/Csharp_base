using System;

namespace HW2three
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 3
            // С клавиатуры вводятся числа, пока не будет введен 0.
            // Подсчитать сумму всех нечетных положительных чисел.

            int res = 0;

            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                
                if (num % 2 != 0 && num >0)
                    {
                        res += num;
                    }

                num = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Сумма нечетных положительных чисел = {res}");

        }
    }
}

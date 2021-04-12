using System;

namespace HW2seven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 7
            //a) Разработать рекурсивный метод,
            //который выводит на экран числа от a до b(a<b).
            //б) *Разработать рекурсивный метод,
            //который считает сумму чисел от a до b.

            Console.WriteLine("Введите число а: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b: ");

            int b = Convert.ToInt32(Console.ReadLine());

            #region Задача а

            static void Recursion(int a, int b)
            {
                Console.WriteLine(a);
                a++;

                if (a <= b)
                {
                    Recursion(a, b);
                }

            }

            Recursion(a, b);

            #endregion

            #region Задача б

            static void Sum(int a, int b)
            {
                int summ = 0;

                static void RecSum(int a, int b, int summ)
                {
                    summ += a;
                    a++;

                    if (a <= b)
                    {
                        RecSum(a, b, summ);
                    }
                    else
                    {
                        Console.WriteLine($"Сумма равна {summ}");
                    }

                }

                RecSum(a, b, summ);
            }

            Sum(a, b);

            #endregion
        }
    }
}

using System;

namespace HW2six
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 6
            // *Написать программу подсчета количества «хороших» чисел
            // в диапазоне от 1 до 1 000 000 000.
            // «Хорошим» называется число, которое делится на сумму своих цифр.
            // Реализовать подсчёт времени выполнения программы,
            // используя структуру DateTime.

            DateTime StartTime = DateTime.Now;

            int count = 0;
            int num = 1;

            while (num <= 1000000000)
            {
                int i = num;

                int sum = 0;
                while (i != 0)
                {
                    sum += i % 10;
                    i /= 10;
                }

                if (sum != 0 && num % sum == 0)
                {
                    count++;
                }

                num++;
            }

            Console.WriteLine($"Количество 'хороших' цифр равно {count}");

            TimeSpan ts = DateTime.Now.Subtract(StartTime);
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime, "RunTime");
        }
    }
}

using System;

namespace HW2five
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 5
            //а) Написать программу, которая запрашивает массу и рост человека,
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
            //набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать
            //для нормализации веса.

            //от 18,5 до 24,9

            Console.WriteLine("Введите массу тела: ");

            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост: ");

            double h = Convert.ToDouble(Console.ReadLine());

            double i = m / (h * h);

            if (i < 18.5)
            {
                double dif = Math.Round((18.5 - i) * (h * h), 1);
                Console.WriteLine($"Вам необходимо набрать {dif} кг");
            }
            else
            {
                if (i > 24.9)
                {
                    double dif = Math.Round((i - 24.9) * (h * h), 1);
                    Console.WriteLine($"Вам необходимо похудеть на {dif} кг");
                }
                else
                {
                    Console.WriteLine($"Ваш ИМТ равен {Math.Round(i, 1)}. " +
                        "Все окей!");
                }
            }

        }
    }
}

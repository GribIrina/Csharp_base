using System;

namespace HW1two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ1, задача 2
            // Ввести вес и рост человека. Рассчитать и вывести индекс массы тела
            // (ИМТ) по формуле I=m/(h*h);
            // где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Введите массу тела: ");

            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост: ");

            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ваш ИМТ: {Math.Round(m / (h * h), 1)}");
        }
    }
}

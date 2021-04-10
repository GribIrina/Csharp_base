using System;

namespace HW1three
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая подсчитывает расстояние
            // между точками с координатами x1, y1 и x2,y2 по формуле
            // r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            // Вывести результат, используя спецификатор формата .2f
            // (с двумя знаками после запятой);
            // б) *Выполнить предыдущее задание, оформив вычисления расстояния
            // между точками в виде метода.

            Console.WriteLine("Введите по очереди значения x1 и y1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите по очереди значения x2 и y2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            #region Вариант без звездочки

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками равно: " + "{0:f2}", r);

            #endregion

            #region Вариант со звездочкой

            static double Distance(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }

            Console.WriteLine("Расстояние между точками равно: "
                + "{0:f2}", Distance(x1, y1, x2, y2));

            #endregion

        }
    }
}

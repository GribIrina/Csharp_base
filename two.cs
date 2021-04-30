// Боровикова Ирина, ДЗ6, задача 2
//
// Модифицировать программу нахождения минимума функции так, чтобы можно было
// передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор,
// для какой функции и на каком отрезке находить минимум.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
// Пусть она возвращает минимум через параметр
// (с использованием модификатора out). 


using System;
using System.Collections.Generic;
using System.IO;

namespace DoubleBinary
{
    public delegate double Fun(double x);

    class Program
    {
        public static void SaveFunc(string fileName, double a, double b,
            double h, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
                FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open,
                FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] func = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                func[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return func;
        }

        static double Degree2(double x)
        {
            return x * x;
        }

        static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static double Sin(double x)
        {
            return Math.Sin(x);
        }

        static double Cos(double x)
        {
            return Math.Cos(x);
        }

        static void GetInterval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0]);
            end = double.Parse(interval[1]);
        }

        static void Results(double start, double end, double step,
            double[] val)
        {
            Console.WriteLine("------- X ------- Y -----");
            int i = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start,
                    val[i]);
                start += step;
                i++;
            }
            Console.WriteLine("--------------------------");
        }

        static void Main(string[] args)
        {
            List<Fun> functions = new List<Fun> { new Fun(Degree2),
                new Fun(Sqrt), new Fun(Sin), new Fun(Cos)};
            Console.WriteLine("Выберите функцию для нахождения" +
                " локального минимума:");
            Console.WriteLine("1) f(x)=x^2");
            Console.WriteLine("2) f(x)=x^1/2");
            Console.WriteLine("3) f(x)=Sin(x)");
            Console.WriteLine("4) f(x)=Cos(x)");

            int usetchoice;
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Некорректный ввод");
                else
                {
                    usetchoice = x;
                    break;
                }

            Console.WriteLine("Задайте интервал поиска (x1 x2):");

            double start;
            double end;

            GetInterval(out start, out end);

            Console.WriteLine("Введите размер разбиения:");
            double step = double.Parse(Console.ReadLine());

            SaveFunc("data.bin", start, end, step, functions[usetchoice - 1]);
            double min = double.MaxValue;

            Console.WriteLine("Значения функции: ");
            Results(start, end, step, Load("data.bin", out min));

            Console.WriteLine("Локальный минимум функции:" +
                " {0:0.00}", min);
            Console.ReadKey();
        }
    }
}

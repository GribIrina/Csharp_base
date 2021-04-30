// Боровикова Ирина, ДЗ6, задача 1
//
// Изменить программу вывода таблицы функции так, чтобы можно было передавать
// функции типа double (double, double).
// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

using System;

public delegate double Fun(double x, double y);

class Program
{

    public static void Table(Fun F, double x, double y, double b)
    {
        Console.WriteLine("------- X ------- Y ------- Z -------");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |",
                x, y, F(x, y));
            x += 1;
        }
        Console.WriteLine("-------------------------------------");
    }

    public static double MyFunc(double x, double y)
    {
        return x * x * y;
    }

    public static double Sin(double x, double y)
    {
        return y * Math.Sin(x);
    }

    static void Main()
    {
        Console.WriteLine("Таблица функции MyFunc y*x^2:");
        Table(MyFunc, -1, -2, 2);

        Console.WriteLine("Таблица функции y*Sin(x):");
        Table(new Fun(MyFunc), -5, -2, 2);

        Console.ReadKey();
    }
}

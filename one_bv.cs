using System;

namespace two
// Боровикова Ирина, ДЗ 3, задача 1, пункт б, в
// б) Дописать класс Complex,
// добавив методы вычитания и произведения чисел.
// Проверить работу класса.
// в) Добавить диалог с использованием
// switch демонстрирующий работу класса.

{
    public class Complex
    {
        int im;
        int re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(int im, int re)
        {
            this.im = im;
            this.re = re;
        }

        public Complex Plus(Complex x)
        {
            Complex x1 = new();
            x1.im = x.im + im;
            x1.re = x.re + re;
            return x1;
        }

        public Complex Sub(Complex x)
        {
            Complex x1 = new();
            x1.im = im - x.im;
            x1.re = re - x.re;
            return x1;
        }

        public Complex Multi(Complex x)
        {
            Complex x1 = new();
            x1.im = re * x.im + im * x.re;
            x1.re = re * x.re - im * x.im;
            return x1;
        }

        public string ToStringCl()
        {
            if (im < 0)
            {
                return re + "-" + -im + "i";
            }
            else if (re == 0 && im == 0)
            {
                return Convert.ToString(0);
            }
            else
            {
                return re + "+" + im + "i";
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите действительную," +
                " а затем мнимую часть 1го числа");
            int im1 = Convert.ToInt32(Console.ReadLine());
            int re1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительную," +
    " а затем мнимую часть 2го числа");
            int im2 = Convert.ToInt32(Console.ReadLine());
            int re2 = Convert.ToInt32(Console.ReadLine());

            Complex complex1 = new(im1, re1);
            Complex complex2 = new(im2, re2);

            Console.WriteLine("Введите знак операции");
            char znak = Convert.ToChar(Console.ReadLine());
            switch (znak)
            {
                case '+':
                    Console.WriteLine($"Результат: " +
                        $"{complex1.Plus(complex2).ToStringCl()}");
                    break;
                case '-':
                    Console.WriteLine($"Результат: " +
    $"{complex2.Sub(complex1).ToStringCl()}");
                    break;
                case '*':
                    Console.WriteLine($"Результат: " +
    $"{complex2.Multi(complex1).ToStringCl()}");
                    break;
                default:
                    Console.WriteLine("Знак не распознан!");
                    break;
            }
        }
    }
}

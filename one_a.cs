using System;

// Боровикова Ирина, ДЗ 3, задача 1, пункт а
// а) Дописать структуру Complex, добавив метод
// вычитания комплексных чисел. Продемонстрировать работу структуры.

namespace one

{
    struct Complex
{
    public double im;
    public double re;

    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }

    public Complex Sub(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

        public string ToStringStr()
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

            Complex complex1;
            complex1.im = im1;
            complex1.re = re1;
            Complex complex2;
            complex2.im = im2;
            complex2.re = re2;

            Console.WriteLine("Введите знак операции");
            char znak = Convert.ToChar(Console.ReadLine());
            switch (znak)
            {
                case '+':
                    Console.WriteLine($"Результат: " +
                        $"{complex1.Plus(complex2).ToStringStr()}");
                    break;
                case '-':
                    Console.WriteLine($"Результат: " +
    $"{complex1.Sub(complex2).ToStringStr()}");
                    break;
                case '*':
                    Console.WriteLine($"Результат: " +
    $"{complex2.Multi(complex1).ToStringStr()}");
                    break;
                default:
                    Console.WriteLine("Знак не распознан!");
                    break;
            }


        }
    }
}

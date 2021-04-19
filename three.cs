using System;

namespace four

// Боровикова Ирина, ДЗ3, задание 3
// *Описать класс дробей — рациональных чисел,
// являющихся отношением двух целых чисел. Предусмотреть методы сложения,
// вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
// * Добавить свойства типа int для доступа к числителю и знаменателю;
// * Добавить свойство типа double только на чтение,
// чтобы получить десятичную дробь числа;
// ** Добавить проверку, чтобы знаменатель не равнялся 0.
// Выбрасывать исключение
// ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.
    
// Упрощение дробей добавлено в ToString

{
    public class Rational
    {
        int num;
        int den;

        public Rational()
        {
            num = 0;
            den = 1;
        }

        public Rational(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public int Numerator
        {
            get { return num; }
            set
            {
                num = value;
            }
        }

        public int Denominator
        {
            get { return den; }
            set
            {
                if (value == 0) throw new
                        ArgumentException("Знаменатель не может быть равен 0");
                else
                    den = value;
            }
        }

        public Rational Plus(Rational x)
        {
            Rational x1 = new();
            if (den == x.den)
            {
                x1.num = x.num + num;
                x1.den = den;
            }
            else
            {
                x1.num = x.num * den + num * x.den;
                x1.den = x.den * den;
            }
            return x1;
        }

        public Rational Sub(Rational x)
        {
            Rational x1 = new();
            if (den == x.den)
            {
                x1.num = num - x.num;
                x1.den = den;
            }
            else
            {
                x1.num = num * x.den - x.num * den;
                x1.den = x.den * den;
            }
            return x1;
        }

        public Rational Multi(Rational x)
        {
            Rational x1 = new();
            x1.num = num * x.num;
            x1.den = den * x.den;

            return x1;
        }

        public Rational Dev(Rational x)
        {
            Rational x1 = new();
            x1.num = num * x.den;
            x1.den = den * x.num;

            return x1;
        }

        public int GCD(int num, int den)
        {
            while (den != 0)
            {
                var t = den;
                den = num % den;
                num = t;
            }
            return num;
        }

        public string ToString()
        {
            int gcd = GCD(num, den);
            num /= gcd;
            den /= gcd;
            return "(" + num + "/" + den + ")";
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите числитель," +
                " а затем знаменатель часть 1го числа");
                int im1 = Convert.ToInt32(Console.ReadLine());
                int re1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите числитель," +
        " а затем знаменатель часть 2го числа");
                int im2 = Convert.ToInt32(Console.ReadLine());
                int re2 = Convert.ToInt32(Console.ReadLine());

                Rational rat1 = new(im1, re1);
                Rational rat2 = new(im2, re2);

                Console.WriteLine("Введите знак операции");
                char znak = Convert.ToChar(Console.ReadLine());
                switch (znak)
                {
                    case '+':
                        Console.WriteLine($"Результат: " +
                            $"{rat1.Plus(rat2).ToString()}");
                        break;
                    case '-':
                        Console.WriteLine($"Результат: " +
        $"{rat2.Sub(rat1).ToString()}");
                        break;
                    case '*':
                        Console.WriteLine($"Результат: " +
        $"{rat2.Multi(rat1).ToString()}");
                        break;
                    case '/':
                        Console.WriteLine($"Результат: " +
        $"{rat2.Dev(rat1).ToString()}");
                        break;
                    default:
                        Console.WriteLine("Знак не распознан!");
                        break;
                }
            }
        }
    }
}

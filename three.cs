// Боровикова Ирина, ДЗ5, задача 3

// *Для двух строк написать метод, определяющий, является ли одна строка
// перестановкой другой.
// Например:
// badc являются перестановкой abcd.

using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Convert.ToString(Console.ReadLine());
            string s2 = Convert.ToString(Console.ReadLine());

            string answer = "Да";

            if (s1.Length != s2.Length)
            {
                answer = "Нет";
            }
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[s2.Length - i - 1])
                    {
                        answer = "Нет";
                        break;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}

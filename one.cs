//  Боровикова Ирина, ДЗ1, задача 1

//  Написать программу «Анкета». Последовательно задаются вопросы
//  (имя, фамилия, возраст, рост, вес).
//  В результате вся информация выводится в одну строчку:
//  а) используя склеивание;
//  б) используя форматированный вывод;
//  в) используя вывод со знаком $.

using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введите свой рост: ");
            string height = Console.ReadLine();
            Console.WriteLine("Введите свой вес: ");
            string weight = Console.ReadLine();
            
            Console.WriteLine(name + ", " + surname + ", " + age + ", " + height
                + ", " + weight);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", name, surname, age,
                height, weight);
            Console.WriteLine($"{name}, {surname}, {age}, {height}, {weight}");

        }
    }
}

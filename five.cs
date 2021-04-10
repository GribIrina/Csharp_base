using System;

namespace HW1five
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ1, задача 5
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) *Сделать задание, только вывод организовать в центре экрана.
            // в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            string name = "Ирина Боровикова";
            string city = "Москва";

            static string Message(string name, string city)
            {
                string message = $"Меня зовут {name}, я из города {city}";
                return message;
            }

            static void Centre(string message)
            {
                Console.SetCursorPosition(
                    ((Console.WindowWidth / 2) - (message.Length / 2)),
                    Console.WindowHeight / 2);

            }

            Centre(Message(name, city));
            Console.WriteLine(Message(name, city));
            

        }
    }
}

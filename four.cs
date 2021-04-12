using System;

namespace HW2four
{
    class Program
    {
        static void Main(string[] args)
        {
            // Боровикова Ирина, ДЗ2, задача 4
            // Комментарий: так и не поняла, зачем здесь именно do while

            // Реализовать метод проверки логина и пароля.
            // На вход метода подается логин и пароль.
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел
            // (Логин: root, Password: GeekBrains).
            // Используя метод проверки логина и пароля, написать программу:
            // пользователь вводит логин и пароль, программа пропускает
            // его дальше или не пропускает.
            // С помощью цикла do while ограничить ввод пароля тремя попытками.

            static void CheckPass()
            {
                Console.WriteLine(
                    "Для доступа к платформе введите логин и пароль");

                string login = "root";
                string password = "GeekBrains";

                int i = 3;

                do
                    {
                    string log = Console.ReadLine();
                    string pass = Console.ReadLine();

                    if (log == login && pass == password)
                    {
                        Console.WriteLine("Добро пожаловать!");
                        break;
                    }
                    else
                    {
                        i--;
                        Console.WriteLine("Логин или пароль неверные;" +
                            $" попыток осталось: {i}");
                    }
                    } while (i > 0);
            }

            CheckPass();

        }
    }
}

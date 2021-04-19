using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {

            // Боровикова Ирина, ДЗ 3, задача 2
            // а)  С клавиатуры вводятся числа, пока не будет введён 0
            // (каждое число в новой строке).
            // Требуется подсчитать сумму всех нечётных положительных чисел.
            // Сами числа и сумму вывести на экран, используя tryParse.

            Console.WriteLine("Данная программа считает сумму" +
                " положительных нечетных чисел;" +
                " чтобы ввод был завершен, напечатайте 0");

            int res = 0;

            string inpt = Console.ReadLine();

            int num;

            bool result = int.TryParse(inpt, out num);

            while (true)
            {
                if (!result)
                {
                    Console.WriteLine("Введено нечисловое значение или" +
                        " значение в некорректном формате; повторите попытку");
                    break;
                }
                else if (num % 2 != 0 && num > 0)
                {
                    res += num;
                }
                else if (num == 0)
                {
                    break;
                }

                inpt = Console.ReadLine();

                result = int.TryParse(inpt, out num);

            }

            Console.WriteLine($"Сумма нечетных положительных чисел = {res}");
        }
    }
}

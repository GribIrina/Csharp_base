// Класс для задачи 2

using System;
using System.Text;

namespace two
{
    public class Message
    {
        string text;
        char[] div = new char[] { ' ', ',', '.', '!', '?', '-', '\n', '\t' };

        public Message(string text)
        {
            this.text = text;
        }

        public void NoMoreThenN(int n)
        {
            string[] elems = text.Split(div);
            foreach (string elem in elems)
            {
                if (elem.Length < n && elem != "")
                {
                    Console.Write($"{elem} ");
                }
            }
            Console.WriteLine();
        }
        public void BadSymbol(char s)
        {
            string[] elems = text.Split(div);
            foreach (string elem in elems)
            {
                if (!elem.EndsWith(s))
                {
                    Console.Write($"{elem} ");
                }
            }
            Console.WriteLine();
        }

        public int Longest()
        {
            string[] elems = text.Split(div);
            int len = elems[0].Length;
            string max = elems[0];

            foreach(string elem in elems)
            {
                if (elem.Length > len)
                {
                    len = elem.Length;
                    max = elem;
                }
            }

            Console.WriteLine($"Самое длинное слово: {max}");
            return len;
        }

        public string FromLongest()
        {
            int len = Longest();
            string[] elems = text.Split(div);
            StringBuilder result = new StringBuilder();

            foreach (string elem in elems)
            {
                if (elem.Length == len)
                {
                    result.Append($"{elem} ");
                }
            }

            return result.ToString();
        }

        public void Print()
        {
            Console.WriteLine(text);
        }
    }
}

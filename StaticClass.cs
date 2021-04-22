using System;
using System.IO;
using System.Linq;

namespace two
{
    public class StaticClass
    {
        int[] mass;

        public StaticClass(int[] s)
        {
            mass = new int[s.Length];
            Array.Copy(s, mass, s.Length);

        }

        public StaticClass()
        {
            mass = new int[20];
            Random r = new Random();
            for (int i = 0; i < 20; i++)
                mass[i] = r.Next(-10000, 10000);
        }

        public StaticClass(string filename)
        {
            if (File.Exists(filename))
            {
                string[] s = File.ReadAllLines(filename);
                mass = new int[s.Length];

                for (int i = 0; i < s.Length; i++)
                    mass[i] = int.Parse(s[i]);
            }
            else Console.WriteLine("Ошибка при считывании файла");
        }

        public int Solution4one()
        {
            int count = 0;

            for (int i = 0; i < 20; i += 2)
            {
                if ((mass[i] % 3 == 0 && mass[i++] % 3 != 0)
                    || (mass[i++] % 3 == 0 && mass[i] % 3 != 0))
                {
                    count++;
                }
            }
            return count;
        }

    }
}

// Класс для третьей задачи

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

        public StaticClass(int n, int start, int step)
        {
            mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = start;
                start += step;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = mass[0];
                int maxcount = 0;
                for (int i = 1; i < mass.Length; i++) {
                    if (mass[i] > max)
                    {
                        max = mass[i];
                        maxcount = 1;
                    }
                    else if (mass[i] == max)
                    {
                        maxcount += 1;
                    }
                }
                return maxcount;
            }
        }


        public int Solution4one()
        {
            int count = 0;

            for (int i = 0; i < 20; i ++)
            {
                if ((mass[i] % 3 == 0 && mass[i++] % 3 != 0)
                    || (mass[i++] % 3 == 0 && mass[i] % 3 != 0))
                {
                    count++;
                }
            }
            return count;
        }

        public int Sum()
        {
            int summa = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                summa += mass[i];
            }

            return summa;
        }

        public int[] Inverse()
        {
            int[] s = new int[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                s[i] = -mass[i];
            }

            return s;
        }

        public void Multi(int n)
        {
            for (int i = 0; i < mass.Length; i++)
            {
               mass[i] *= n;
            }
        }

        public void Print()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
        }


    }
    
}

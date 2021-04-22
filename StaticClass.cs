using System;
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

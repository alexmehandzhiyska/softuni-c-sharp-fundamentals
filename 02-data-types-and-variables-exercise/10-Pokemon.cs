using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int originalPower = n;
            int targetsPoked = 0;

            while (n >= m)
            {
                n -= m;
                targetsPoked++;

                if (n == originalPower / 2)
                {
                    if (y != 0)
                    {
                        n /= y;
                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(targetsPoked);
        }
    }
}
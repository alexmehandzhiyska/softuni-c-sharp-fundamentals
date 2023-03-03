using System;

namespace ConvertMetersToKilometers
{
    class Prorgam
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            double km = (double) m / 1000;

            Console.WriteLine($"{km:f2}");
        }
    }
}
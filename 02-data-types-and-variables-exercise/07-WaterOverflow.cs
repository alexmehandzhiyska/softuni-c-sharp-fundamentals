using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int volumeFilled = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (volumeFilled + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                volumeFilled += liters;
            }

            Console.WriteLine(volumeFilled);
        }
    }
}
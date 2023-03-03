using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int spiceExtracted = 0;
            int day = 0;

            while (yield >= 100)
            {
                spiceExtracted += yield;
                spiceExtracted -= 26;
                yield -= 10;
                day++;
            }

            if (spiceExtracted >= 26)
            {
                spiceExtracted -= 26;
            }

            Console.WriteLine(day);
            Console.WriteLine(spiceExtracted);
        }
    }
}
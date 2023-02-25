using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int totalMins = hours * 60 + mins + 30;

            int newHours = totalMins / 60;
            int newMins = totalMins % 60;

            if (newHours == 24)
            {
                newHours = 0;
            }

            if (newMins < 10)
            {
                Console.WriteLine($"{newHours}:0{newMins}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMins}");
            }

        }
    }
}
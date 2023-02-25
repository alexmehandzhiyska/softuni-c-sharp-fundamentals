using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (month >= 1 && month <= 12)
            {
                Console.WriteLine(months[month - 1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
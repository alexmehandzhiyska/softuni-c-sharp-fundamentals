using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;

            if (type == "Business" && people >= 100)
            {
                people -= 10;
            }

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        price = people * 8.45;
                    }
                    else if (type == "Business")
                    {
                        price = people * 10.90;
                    }
                    else
                    {
                        price = people * 15;
                    }
                    break;

                case "Saturday":
                    if (type == "Students")
                    {
                        price = people * 9.80;
                    }
                    else if (type == "Business")
                    {
                        price = people * 15.60;
                    }
                    else
                    {
                        price = people * 20;
                    }
                    break;

                case "Sunday":
                    if (type == "Students")
                    {
                        price = people * 10.46;
                    }
                    else if (type == "Business")
                    {
                        price = people * 16;
                    }
                    else
                    {
                        price = people * 22.50;
                    }
                    break;
            }

            if (type == "Students" && people >= 30)
            {
                price *= 0.85;
            }
            else if (type == "Regular" && (people >= 10 && people <= 20)) {
                price *= 0.95;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
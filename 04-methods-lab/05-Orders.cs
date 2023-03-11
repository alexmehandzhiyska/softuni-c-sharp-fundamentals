using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = CalcPrice(product, quantity);
            Console.WriteLine($"{price:f2}");
        }

        private static double CalcPrice(string product, int quantity)
        {
            if (product == "coffee")
            {
                return quantity * 1.50;
            }
            else if (product == "water")
            {
                return quantity * 1;
            }
            else if (product == "coke")
            {
                return quantity * 1.40;
            }
            else
            {
                return quantity * 2;
            }
        }
    }
}
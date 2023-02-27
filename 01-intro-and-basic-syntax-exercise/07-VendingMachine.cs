using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]? validCoins = { 0.1, 0.2, 0.5, 1, 2 };

            string input = Console.ReadLine();
            double sum = 0.0;

            while (input != "Start")
            {
                double coin = double.Parse(input);
                bool isValidCoin = Array.Exists(validCoins, el => el == coin);

                if (isValidCoin)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string stock = input;
                double price = 0.0;

                if (stock == "Nuts")
                {
                    price = 2.0;
                }
                else if (stock == "Water")
                {
                    price = 0.7;
                }
                else if (stock == "Crisps")
                {
                    price = 1.5;
                }
                else if (stock == "Soda")
                {
                    price = 0.8;
                }
                else if (stock == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    input = Console.ReadLine();
                    continue;
                }

                if (sum >= price)
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {stock.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
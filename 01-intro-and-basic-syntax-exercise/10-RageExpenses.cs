using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double pricePerHeadset = double.Parse(Console.ReadLine());
            double pricePerMouse = double.Parse(Console.ReadLine());
            double pricePerKeyboard = double.Parse(Console.ReadLine());
            double pricePerDisplay = double.Parse(Console.ReadLine());

            double rageExpenses = (gamesLost / 2) * pricePerHeadset + (gamesLost / 3) * pricePerMouse + (gamesLost / 6) * pricePerKeyboard + (gamesLost / 12) * pricePerDisplay;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
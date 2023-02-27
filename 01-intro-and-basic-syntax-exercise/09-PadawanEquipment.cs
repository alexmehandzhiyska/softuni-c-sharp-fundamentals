using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double pricePerSaber = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());

            double sabersPrice = pricePerSaber * Math.Ceiling((1.1 * studentsCount));
            double robesPrice = pricePerRobe * studentsCount;

            int freeBelts = studentsCount / 6;
            double beltsPrice = pricePerBelt * (studentsCount - freeBelts);

            double moneyNeeded = sabersPrice + robesPrice + beltsPrice;

            if (moneyAvailable >= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(moneyNeeded - moneyAvailable):f2}lv more.");
            }
        }
    }
}
using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleInWagons = new int[n];
            int totalPeople = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                peopleInWagons[i] = people;
                totalPeople += people;
            }

            Console.WriteLine(string.Join(" ", peopleInWagons));
            Console.WriteLine(totalPeople);
        }
    }
}
using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valsType = Console.ReadLine();
            
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();

            if (valsType == "int")
            {
                Console.WriteLine(GetMax(int.Parse(val1), int.Parse(val2)));
            }
            else if (valsType == "char")
            {
                Console.WriteLine(GetMax(char.Parse(val1), char.Parse(val2)));
            }
            else
            {
                Console.WriteLine(GetMax(val1, val2));
            }
        }

        private static int GetMax(int val1, int val2)
        {
            return Math.Max(val1, val2);
        }

        private static char GetMax(char val1, char val2)
        {
            int result = val1.CompareTo(val2);

            if (result > 0)
                return val1;

            return val2;
        }

        private static string GetMax(string val1, string val2)
        {
            int result = val1.CompareTo(val2);

            if (result > 0)
                return val1;

            return val2;
        }
    }
}
using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numAsStr = num.ToString();
            int factorialsSum = 0;

            for (int i = 0; i < numAsStr.Length; i++)
            {
                double curDigit = Char.GetNumericValue(numAsStr[i]);
                double factorial = curDigit;

                if (curDigit == 0)
                {
                    factorialsSum += 1;
                    continue;
                }

                for (double factor = curDigit - 1; factor > 1; factor--)
                {
                    factorial *= factor;
                }

                factorialsSum += (int)factorial;
            }

            if (factorialsSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
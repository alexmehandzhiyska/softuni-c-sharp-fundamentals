using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            string numAsStr = num.ToString();

            int evenSum = GetSumOfEvenDigits(numAsStr);
            int oddSum = GetSumOfOddDigits(numAsStr);

            int multiple = GetMultipleOfEvenAndOdds(evenSum, oddSum); ;
            Console.WriteLine(multiple);
        }

        private static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
        
        private static int GetSumOfEvenDigits(string numAsStr)
        {
            int sum = 0;

            for (int i = 0; i < numAsStr.Length; i++)
            {
                int curDigit = (int)Char.GetNumericValue(numAsStr[i]);

                if (curDigit % 2 == 0)
                {
                    sum += curDigit;
                }
            }

            return sum;
        }

        private static int GetSumOfOddDigits(string numAsStr)
        {
            int sum = 0;

            for (int i = 0; i < numAsStr.Length; i++)
            {
                int curDigit = (int)Char.GetNumericValue(numAsStr[i]);

                if (curDigit % 2 != 0)
                {
                    sum += curDigit;
                }
            }

            return sum;
        }
    }
}
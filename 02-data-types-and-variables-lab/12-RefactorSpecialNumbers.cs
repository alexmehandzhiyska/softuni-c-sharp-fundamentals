using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int ch = 1; ch <= n; ch++)
            {
                int curNum = ch;
                int sumDigits = 0;

                while (curNum > 0)
                {
                    sumDigits += curNum % 10;
                    curNum = curNum / 10;
                }

                bool isSpecial = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}", ch, isSpecial);
            }
        }
    }
}
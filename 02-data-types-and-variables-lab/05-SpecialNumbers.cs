using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] aregs)
        {
            int n = int.Parse(Console.ReadLine());

            for (int curNum = 1; curNum <= n; curNum++)
            {
                string curNumAsStr = curNum.ToString();
                int sumDigits = 0;

                for (int i = 0; i < curNumAsStr.Length; i++)
                {
                    double digit = Char.GetNumericValue(curNumAsStr[i]);
                    sumDigits += (int)digit;
                }

                bool isSpecial = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;
                Console.WriteLine($"{curNum} -> {isSpecial}");
            }
        }
    }
}
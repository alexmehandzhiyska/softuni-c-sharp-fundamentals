using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    addNums(num1, num2);
                    break;

                case "subtract":
                    subtractNums(num1, num2);
                    break;

                case "multiply":
                    multiplyNums(num1, num2);
                    break;

                case "divide":
                    divideNums(num1, num2);
                    break;
            }
        }

        private static void addNums(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        private static void subtractNums(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void multiplyNums(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void divideNums(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            double result = Calculate(num1, operation, num2);
            Console.WriteLine(result);
        }

        private static double Calculate(int num1, string operation, int num2)
        {
            double result = 0.0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}
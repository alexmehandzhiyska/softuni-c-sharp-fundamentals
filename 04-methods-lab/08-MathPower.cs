using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = CalcPower(baseNum, power);
            Console.WriteLine(result);
        }

        private static double CalcPower(double baseNum, double power)
        {
            return Math.Pow(baseNum, power);
        } 
    }
}
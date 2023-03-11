using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());  
            double area = CalcRectArea(length, width);
            Console.WriteLine(area);
        }

        private static double CalcRectArea(double length, double width)
        {
            return length * width;
        }
    }
}
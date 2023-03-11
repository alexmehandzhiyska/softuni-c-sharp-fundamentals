using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            string[] commonEls = new string[] {};

            for (int i = 0; i < arr2.Length; i++)
            {
                string curEl = arr2[i];

                if (arr1.Contains(curEl))
                {
                    commonEls = commonEls.Append(curEl).ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", commonEls));
        }
    }
}
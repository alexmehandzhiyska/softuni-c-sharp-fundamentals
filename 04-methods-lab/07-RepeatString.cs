using System;
using System.Linq;

namespace RepeatString
{
    class Program {
        static void Main(string[] args) { 
            string str = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());
            
            Console.WriteLine(RepeatStr(str, repetitions));
        }

        private static string RepeatStr(string str, int repetitions)
        {
            return string.Concat(Enumerable.Repeat(str, repetitions));
        }
    }
}
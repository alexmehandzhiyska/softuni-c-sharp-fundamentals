using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndeces = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            int[] field = new int[fieldSize];

            foreach (int index in initialIndeces)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            while (input != "end")
            {
                string[] els = input.Split(" ");

                int ladybugIdx = int.Parse(els[0]);
                string direction = els[1];
                int flyLen = int.Parse(els[2]);

                if ((ladybugIdx < 0 || ladybugIdx >= fieldSize) || field[ladybugIdx] != 1 || flyLen == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (direction == "left")
                {
                    int newIdx = ladybugIdx - flyLen;

                    if (newIdx < 0)
                    {
                        field[ladybugIdx] = 0;
                        input = Console.ReadLine();
                        continue;
                    }

                    while (field[newIdx] == 1)
                    {
                        newIdx -= flyLen;

                        if (newIdx < 0)
                            break;
                    }

                    if (newIdx >= 0)
                    {
                        field[newIdx] = 1;
                    }

                    field[ladybugIdx] = 0;
                }
                else
                {
                    int newIdx = ladybugIdx + flyLen;

                    if (newIdx >= fieldSize)
                    {
                        field[ladybugIdx] = 0;
                        input = Console.ReadLine();
                        continue;
                    }
                        
                    while (field[newIdx] == 1)
                    {
                        newIdx += flyLen;

                        if (newIdx >= fieldSize)
                            break;
                    }

                    if (newIdx < fieldSize)
                    {
                        field[newIdx] = 1;
                    }

                    field[ladybugIdx] = 0;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
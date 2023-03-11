using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] curSeq = new int[] { };
            int[] maxSeq = new int[] { };

            for (int i = 0; i < nums.Length; i++)
            {
                int curNum = nums[i];

                if (curSeq.Length == 0)
                {
                    curSeq = curSeq.Append(curNum).ToArray();
                }
                else
                {
                    if (curSeq[0] == curNum)
                    {
                        curSeq = curSeq.Append(curNum).ToArray();
                        continue;
                    }

                    if (curSeq.Length > maxSeq.Length)
                        maxSeq = curSeq;

                    curSeq = new int[] { curNum };
                }
            }

            if (curSeq.Length > maxSeq.Length)
                maxSeq = curSeq;

            Console.WriteLine(string.Join(" ", maxSeq));
        }
    }
}
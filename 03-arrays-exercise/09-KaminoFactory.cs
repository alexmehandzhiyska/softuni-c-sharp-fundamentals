using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLen = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int bestDnaLength = 0;
            int bestDnaStart = 0;
            int bestDnaSum = 0;
            int bestDnaIndex = 1;
            int[] bestDnaSeq = new int[dnaLen];

            int curDnaCount = 0;

            while (input != "Clone them!")
            {
                curDnaCount++;

                int[] curSeq = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int curSeqSum = 0;

                int longest1Subseq = 0;
                int longest1SubseqStart = 0;

                int cur1Subseq = 0;
                int cur1SubseqStart = 0;

                for (int i = 0; i < curSeq.Length; i++)
                {
                    int curNum = curSeq[i];

                    if (curNum == 1) {
                        curSeqSum++;
                        cur1Subseq++;
                    }

                    if (cur1Subseq > longest1Subseq)
                    {
                        longest1Subseq = cur1Subseq;
                        longest1SubseqStart = i - cur1Subseq + 1;
                    }

                    cur1Subseq = curNum == 0 ? 0 : cur1Subseq;
                }

                if (longest1Subseq > bestDnaLength)
                {
                    bestDnaLength = longest1Subseq;
                    bestDnaSeq = curSeq;
                    bestDnaStart = longest1SubseqStart;
                    bestDnaSum = curSeqSum;
                    bestDnaIndex = curDnaCount;
                }
                else if (longest1Subseq == bestDnaLength)
                {
                    if (longest1SubseqStart < bestDnaStart || (longest1SubseqStart == bestDnaStart && curSeqSum > bestDnaSum))
                    {
                        bestDnaSeq = curSeq;
                        bestDnaStart = longest1SubseqStart;
                        bestDnaSum = curSeqSum;
                        bestDnaIndex = curDnaCount;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDnaIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(" ", bestDnaSeq));
        }
    }
}
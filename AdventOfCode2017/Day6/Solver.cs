using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day6
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            return SolveCore(input).Steps;
        }

        public int SolvePart2(string input)
        {
            return SolveCore(input).LoopSize;
        }

        private (int Steps, int LoopSize) SolveCore(string input)
        {
            var memoryBanks = input.Split("\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var traversedStates = new List<int[]> { this.CopyMemoryBanks(memoryBanks) };

            int steps = 0;
            while (steps < int.MaxValue)
            {
                var maxBlock = memoryBanks.Max();
                int largestMemBankIdx = memoryBanks.FindIndex(b => b == memoryBanks.Max());

                var remainingBlocksToDistribute = maxBlock;

                memoryBanks[largestMemBankIdx] = 0;
                var currentIdx = largestMemBankIdx;

                while (remainingBlocksToDistribute > 0)
                {
                    memoryBanks[++currentIdx % memoryBanks.Count]++;

                    remainingBlocksToDistribute--;
                }

                var memoryBanksCopy = this.CopyMemoryBanks(memoryBanks);

                steps++;

                for (int i = 0; i < traversedStates.Count; i++)
                {
                    if (StructuralComparisons.StructuralEqualityComparer.Equals(traversedStates[i], memoryBanksCopy))
                    {
                        return (steps, steps - i);
                    }
                }

                traversedStates.Add(memoryBanksCopy);
            }

            throw new InvalidOperationException("Unable to find result");
        }

        private int[] CopyMemoryBanks(List<int> memoryBanks)
        {
            return memoryBanks.ToArray();
        }
    }
}

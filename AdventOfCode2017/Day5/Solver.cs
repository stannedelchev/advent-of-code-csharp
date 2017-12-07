using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day5
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            return this.SolveCore(input, prevIp => ++prevIp);
        }

        private int SolveCore(string input, Func<int, int> changePreviousIpFunction)
        {
            var instructions = input
                            .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int previousInstructionPointer = 0;
            int instructionPointer = previousInstructionPointer;
            int steps = 0;

            try
            {
                while (steps >= 0)
                {
                    instructionPointer += instructions[instructionPointer];
                    instructions[previousInstructionPointer] = changePreviousIpFunction(instructions[previousInstructionPointer]);
                    previousInstructionPointer = instructionPointer;
                    steps++;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                return steps;
            }

            return -1;
        }

        public int SolvePart2(string input)
        {
            return this.SolveCore(input, prevIp =>
            {
                if (prevIp >= 3)
                {
                    return prevIp - 1;
                }

                return prevIp + 1;
            });
        }
    }
}

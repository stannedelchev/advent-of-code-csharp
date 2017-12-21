using System;
using System.Linq;

namespace AdventOfCode2017.Day8
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            var registers = SolveCore(input);
            return registers.CurrentMax;
        }

        public int SolvePart2(string input)
        {
            var registers = SolveCore(input);
            return registers.LifetimeMax;
        }

        private static RegistersCollection SolveCore(string input)
        {
            var lines = input.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var registers = new RegistersCollection();

            var instructionParser = new InstructionParser(registers);
            var instructions = lines.Select(instructionParser.Parse).ToList();

            instructions.ForEach(i => i.Execute());

            return registers;
        }
    }
}
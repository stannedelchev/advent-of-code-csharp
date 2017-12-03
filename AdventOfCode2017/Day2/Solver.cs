using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.Day2
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            var result = this.CalculateChecksum(input, ints => ints.Max() - ints.Min());
            return result;
        }

        public int SolvePart2(string input)
        {
            var result = this.CalculateChecksum(input, EvenlyDivisibleChecksum);
            return result;
        }

        private int CalculateChecksum(string input, Func<IEnumerable<int>, int> rowChecksumFunc)
        {
            var result = input.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Split(" \t".ToCharArray())
                .Select(int.Parse))
                .Select(rowChecksumFunc)
                .Sum();
            return result;
        }

        private int EvenlyDivisibleChecksum(IEnumerable<int> args)
        {
            var ints = args.ToArray();
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    var largerNumber = Math.Max(ints[i], ints[j]);
                    var smallerNumber = Math.Min(ints[i], ints[j]);
                    if (largerNumber % smallerNumber == 0 && largerNumber != smallerNumber)
                    {
                        return largerNumber / smallerNumber;
                    }
                }
            }

            return 0;
        }
    }
}

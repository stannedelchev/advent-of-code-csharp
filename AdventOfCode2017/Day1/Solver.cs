using System;
using System.Linq;

namespace AdventOfCode2017.Day1
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            int result = 0;

            // Input is a circular list, so just add the first character to the end and loop through the entire input
            input += input.First();

            for (int i = 0; i < input.Length - 1; i++)
            {
                // TODO: Clean up duplicated code
                var current = input[i];
                var next = input[i + 1];

                if (current == next)
                {
                    var currentAsString = current.ToString();
                    result += int.Parse(currentAsString);
                }
            }

            return result;
        }

        public int SolvePart2(string input)
        {
            var result = 0;
            var originalInputLength = input.Length;

            if (originalInputLength % 2 != 0)
            {
                throw new ArgumentException("List length should be even");
            }

            // Simulate the circular list again
            input += input;

            for (int i = 0; i < originalInputLength; i++)
            {
                // TODO: Clean up duplicated code
                var current = input[i];
                var next = input[i + originalInputLength / 2];

                if (current == next)
                {
                    var currentAsString = current.ToString();
                    result += int.Parse(currentAsString);
                }
            }

            return result;
        }
    }
}
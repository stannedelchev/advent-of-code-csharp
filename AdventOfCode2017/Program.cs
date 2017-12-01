using System.IO;

namespace AdventOfCode2017
{
    static class Program
    {
        static void Main(string[] args)
        {
            var day1Part1Solution = new Day1.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day1_input.txt"));
            var day1Part2Solution = new Day1.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day1_input.txt"));

            System.Console.WriteLine($"Day 1.1 : {day1Part1Solution}");
            System.Console.WriteLine($"Day 1.2 : {day1Part2Solution}");
        }
    }
}

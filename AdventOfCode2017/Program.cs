using System.IO;

namespace AdventOfCode2017
{
    static class Program
    {
        static void Main(string[] args)
        {
            var day1Part1Solution = new Day1.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day1_input.txt"));
            var day1Part2Solution = new Day1.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day1_input.txt"));
            var day2Part1Solution = new Day2.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day2_input.txt"));
            var day2Part2Solution = new Day2.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day2_input.txt"));

            System.Console.WriteLine($"Day 1.1 : {day1Part1Solution}");
            System.Console.WriteLine($"Day 1.2 : {day1Part2Solution}");
            System.Console.WriteLine($"Day 2.1 : {day2Part1Solution}");
            System.Console.WriteLine($"Day 2.2 : {day2Part2Solution}");
        }
    }
}

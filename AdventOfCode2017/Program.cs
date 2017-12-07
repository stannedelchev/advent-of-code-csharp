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
            var day3Part1Solution = new Day3.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day3_input.txt"));
            var day3Part2Solution = new Day3.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day3_input.txt"));
            var day4Part1Solution = new Day4.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day4_input.txt"));
            var day4Part2Solution = new Day4.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day4_input.txt"));
            var day5Part1Solution = new Day5.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day5_input.txt"));
            var day5Part2Solution = new Day5.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day5_input.txt"));

            System.Console.WriteLine($"Day 1.1 : {day1Part1Solution}");
            System.Console.WriteLine($"Day 1.2 : {day1Part2Solution}");
            System.Console.WriteLine($"Day 2.1 : {day2Part1Solution}");
            System.Console.WriteLine($"Day 2.2 : {day2Part2Solution}");
            System.Console.WriteLine($"Day 3.1 : {day3Part1Solution}");
            System.Console.WriteLine($"Day 3.2 : {day3Part2Solution}");
            System.Console.WriteLine($"Day 4.1 : {day4Part1Solution}");
            System.Console.WriteLine($"Day 4.2 : {day4Part2Solution}");
            System.Console.WriteLine($"Day 5.1 : {day4Part1Solution}");
            System.Console.WriteLine($"Day 5.2 : {day4Part2Solution}");
        }
    }
}

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
            var day6Part1Solution = new Day6.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day6_input.txt"));
            var day6Part2Solution = new Day6.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day6_input.txt"));
            var day7Part1Solution = new Day7.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day7_input.txt"));
            var day7Part2Solution = new Day7.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day7_input.txt"));
            var day8Part1Solution = new Day8.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day8_input.txt"));
            var day8Part2Solution = new Day8.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day8_input.txt"));
            var day9Part1Solution = new Day9.Solver().SolvePart1(File.ReadAllText(@"Inputs\Day9_input.txt"));
            var day9Part2Solution = new Day9.Solver().SolvePart2(File.ReadAllText(@"Inputs\Day9_input.txt"));

            System.Console.WriteLine($"Day 1.1 : {day1Part1Solution}");
            System.Console.WriteLine($"Day 1.2 : {day1Part2Solution}");
            System.Console.WriteLine($"Day 2.1 : {day2Part1Solution}");
            System.Console.WriteLine($"Day 2.2 : {day2Part2Solution}");
            System.Console.WriteLine($"Day 3.1 : {day3Part1Solution}");
            System.Console.WriteLine($"Day 3.2 : {day3Part2Solution}");
            System.Console.WriteLine($"Day 4.1 : {day4Part1Solution}");
            System.Console.WriteLine($"Day 4.2 : {day4Part2Solution}");
            System.Console.WriteLine($"Day 5.1 : {day5Part1Solution}");
            System.Console.WriteLine($"Day 5.2 : {day5Part2Solution}");
            System.Console.WriteLine($"Day 6.1 : {day6Part1Solution}");
            System.Console.WriteLine($"Day 6.2 : {day6Part2Solution}");
            System.Console.WriteLine($"Day 7.1 : {day7Part1Solution}");
            System.Console.WriteLine($"Day 7.2 : {day7Part2Solution}");
            System.Console.WriteLine($"Day 8.1 : {day8Part1Solution}");
            System.Console.WriteLine($"Day 8.2 : {day8Part2Solution}");
            System.Console.WriteLine($"Day 9.1 : {day9Part1Solution}");
            System.Console.WriteLine($"Day 9.2 : {day9Part2Solution}");
        }
    }
}

using System;
using System.IO;

namespace AdventOfCode2017.Day11
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            var moves = input.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var traverser = new HexTraverser(moves);
            traverser.TraverseAll();

            return traverser.CurrentPositionDistance;
        }

        public int SolvePart2(string input)
        {
            var moves = input.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var traverser = new HexTraverser(moves);
            traverser.TraverseAll();

            return traverser.FurthestDistance;
        }
    }
}
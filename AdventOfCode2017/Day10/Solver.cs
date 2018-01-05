using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Day10
{
    public class Solver
    {
        private readonly int sparseHashElements;

        public Solver()
        {
            this.sparseHashElements = SparseHash.DefaultElements;
        }

        internal Solver(int hashElements)
        {
            this.sparseHashElements = hashElements;
        }

        public int SolvePart1(string input)
        {
            var lengths = input.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var hash = new SparseHash(this.sparseHashElements);
            hash.Calculate(1, lengths);

            return hash[0] * hash[1];
        }

        public string SolvePart2(string input)
        {
            var lengths = input.Select(Convert.ToInt32).Concat(new[] { 17, 31, 73, 47, 23 }).ToList();


            var sparseHash = new SparseHash(this.sparseHashElements);
            sparseHash.Calculate(64, lengths);

            var denseHash = new DenseHash(sparseHash);
            var result = denseHash.Calculate();
            return result;
        }
    }
}
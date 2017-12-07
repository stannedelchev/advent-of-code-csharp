using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day4
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            var result = this.SolveCore(input, StringComparer.CurrentCulture);

            return result;
        }

        public int SolvePart2(string input)
        {
            var result = this.SolveCore(input, new AnagramComparer());
            return result;
        }

        private int SolveCore(string input, IEqualityComparer<string> comparer)
        {
            var result = input
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Split(" ".ToCharArray()))
                .Select(wordsInLine => wordsInLine.Distinct(comparer).Count() == wordsInLine.Length)
                .Count(passphrase => passphrase == true);

            return result;
        }

        private class AnagramComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                var orderedX = new string(x.OrderBy(c => c).ToArray());
                var orderedY = new string(x.OrderBy(c => c).ToArray());
                return orderedX == orderedY;
            }

            public int GetHashCode(string obj)
            {
                return new string(obj.OrderBy(c => c).ToArray()).GetHashCode();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day3
{
    public class Solver
    {
        private int currentItem = 0;

        public int SolvePart1(string input)
        {
            var square = int.Parse(input);
            var spiral = new SpiralMemoryStorage(1024 + 1, this.ContinuousFill);
            var result = spiral.GetDistanceFromCenter(square);
            return result;
        }

        private int ContinuousFill(int row, int column)
        {
            currentItem++;
            return currentItem;
        }

        public int SolvePart2(string input)
        {
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.Day11
{
    public class HexTraverser
    {
        private readonly IEnumerable<string> moves;

        public HexTraverser(IEnumerable<string> moves)
        {
            this.moves = moves;
        }

        public (int x, int y, int z) CurrentPosition { get; private set; }
        public int CurrentPositionDistance { get; private set; }
        public int FurthestDistance { get; private set; }

        public void TraverseAll()
        {
            (int x, int y, int z) currentPosition = (0, 0, 0);
            this.FurthestDistance = 0;

            foreach (var move in this.moves)
            {
                //   \ n  /
                // nw +--+ ne
                //   /    \
                // -+      +-
                //   \    /
                // sw +--+ se
                //   / s  \

                switch (move)
                {
                    case "n":
                        currentPosition.y++;
                        currentPosition.z--;
                        break;
                    case "ne":
                        currentPosition.x++;
                        currentPosition.z--;
                        break;
                    case "se":
                        currentPosition.x++;
                        currentPosition.y--;
                        break;
                    case "s":
                        currentPosition.z++;
                        currentPosition.y--;
                        break;
                    case "sw":
                        currentPosition.z++;
                        currentPosition.x--;
                        break;
                    case "nw":
                        currentPosition.y++;
                        currentPosition.x--;
                        break;
                }

                this.CurrentPosition = currentPosition;
                this.CurrentPositionDistance = CalculateDistanceFromStart(ref currentPosition);

                if (this.CurrentPositionDistance > this.FurthestDistance)
                {
                    this.FurthestDistance = this.CurrentPositionDistance;
                }
            }
        }

        private int CalculateDistanceFromStart(ref (int x, int y, int z) currentPosition)
        {
            return new[] { Math.Abs(currentPosition.x), Math.Abs(currentPosition.y), Math.Abs(currentPosition.z) }.Max();
        }
    }
}
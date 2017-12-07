using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day3
{
    public class SpiralMemoryStorage
    {
        private readonly int[,] store;
        private readonly Func<int, int, int> itemCalculationFunction;

        public SpiralMemoryStorage(int size, Func<int, int, int> itemCalculationFunc)
        {
            this.store = new int[size, size];
            this.itemCalculationFunction = itemCalculationFunc;
            this.FillStore(ref this.store, 0, 0, this.Width);
        }

        private void FillStore(ref int[,] store, int topLeftRow, int topLeftColumn, int storeWidth)
        {
            if (storeWidth <= 0)
            {
                return;
            }

            if (storeWidth == 1)
            {
                store[topLeftRow, topLeftColumn] = 1;
                return;
            }

            // Fill the edge of the spiral, starting from bottom right square and moving clockwise

            var maxSquareValue = storeWidth * storeWidth;
            var squareValue = maxSquareValue;

            // move left from bottom-right to bottom-left 
            for (int column = topLeftColumn + storeWidth - 1; column >= topLeftColumn; column--)
            {
                store[topLeftRow + storeWidth - 1, column] = squareValue;
                squareValue--;
            }

            // move up from bottom-left to top-left, skipping bottom-left
            for (int row = topLeftRow + storeWidth - 2; row >= topLeftRow; row--)
            {
                store[row, topLeftColumn] = squareValue;
                squareValue--;
            }

            // move right from top-left to top-right, skipping top-left
            for (int column = topLeftColumn + 1; column < topLeftColumn + storeWidth; column++)
            {
                store[topLeftRow, column] = squareValue;
                squareValue--;
            }

            // move down from top-right to bottom-right, skipping top-right and bottom-right
            for (int row = topLeftRow + 1; row < topLeftRow + storeWidth - 1; row++)
            {
                store[row, topLeftColumn + storeWidth - 1] = squareValue;
                squareValue--;
            }

            // recursively fill the inner part of the spiral
            this.FillStore(ref store, topLeftRow + 1, topLeftColumn + 1, storeWidth - 2);
        }
        

        public int GetDistanceFromCenter(int value)
        {
            var width = this.Width;
            for (int row = 0; row < width; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    if (store[row, column] == value)
                    {
                        var xMoves = Math.Abs(this.Width / 2 - row);
                        var yMoves = Math.Abs(this.Width / 2 - column);
                        return xMoves + yMoves;
                    }
                }
            }

            return -1;
        }

        public int this[int row, int column]
        {
            get { return this.store[row, column]; }
            set { this.store[row, column] = value; }
        }

        public int Width { get => this.store.GetLength(0); }

        private string DumpStore()
        {
            var result = "";
            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    result += $"{store[i, j],5}";
                }

                result += Environment.NewLine;
            }

            return result;
        }
    }
}
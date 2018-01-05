using MoreLinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day10
{
    public class SparseHash : IEnumerable<int>
    {
        public const int DefaultElements = 256;
        private readonly CircularArray<int> store;

        public SparseHash()
            : this(SparseHash.DefaultElements)
        {

        }

        public SparseHash(int elements)
        {
            this.store = new CircularArray<int>(Enumerable.Range(0, elements));
        }

        public CircularArray<int> Calculate(int rounds, IEnumerable<int> lengths)
        {
            int currentPosition = 0;
            int skipSize = 0;

            for (int i = 0; i < rounds; i++)
            {
                foreach (var length in lengths)
                {
                    store.Reverse(currentPosition, length);

                    currentPosition += length + skipSize;
                    skipSize++;
                }
            }

            return this.store;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this.store.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.store.GetEnumerator();
        }

        public int this[int index]
        {
            get => this.store[index];
        }
    }
}
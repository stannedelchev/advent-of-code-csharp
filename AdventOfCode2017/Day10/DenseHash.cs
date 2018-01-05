using MoreLinq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day10
{

    public class DenseHash
    {
        private readonly IEnumerable<int> store;

        public DenseHash(SparseHash hash)
        {
            this.store = hash;
        }

        public string Calculate()
        {
            var blocks = this.store.Batch(16).Select(block =>
            {
                int xorSum = 0;
                foreach (var item in block)
                {
                    xorSum ^= item;
                }

                return xorSum;
            });

            var result = string.Concat(blocks.Select(i => $"{i:X2}").ToArray()).ToLower();
            return result;
        }
    }
}
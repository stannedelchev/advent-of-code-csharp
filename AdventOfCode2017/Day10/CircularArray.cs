using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Day10
{

    public class CircularArray<T> : IEnumerable<T>
    {
        private T[] store;

        public CircularArray(IEnumerable<T> collection)
        {
            this.store = collection.ToArray();
        }

        public CircularArray(int elements)
        {
            this.store = new T[elements];
        }

        public int Length => this.store.Length;

        public T this[int index]
        {
            get
            {
                return this.store[index % store.Length];
            }
            set
            {
                this.store[index % store.Length] = value;
            }
        }

        public void Reverse(int start, int length)
        {
            for(int i = 0; i < length / 2; i++)
            {
                T tmp = this[start + i];
                this[start + i] = this[start + length - 1 - i];
                this[start + length - 1 - i] = tmp;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return  ((IEnumerable<T>)this.store).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
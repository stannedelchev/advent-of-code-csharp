using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.Day8
{

    public class Register
    {
        public int Value { get; private set; }

        public int MaxValue { get; private set; }

        public void Increase(int value)
        {
            this.Value += value;
            this.CheckMaxValue();
        }

        public void Decrease(int value)
        {
            this.Value -= value;
            this.CheckMaxValue();
        }

        public bool MatchesPredicate(Predicate<int> predicate)
        {
            return predicate(this.Value);
        }

        private void CheckMaxValue()
        {
            if (this.Value > this.MaxValue)
            {
                this.MaxValue = this.Value;
            }
        }
    }
}
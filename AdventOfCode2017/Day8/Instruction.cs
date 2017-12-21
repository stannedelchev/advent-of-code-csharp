using System;

namespace AdventOfCode2017.Day8
{
    public abstract class Instruction
    {
        protected readonly RegistersCollection registers;

        public Instruction(RegistersCollection registers)
        {
            this.registers = registers ?? throw new ArgumentNullException(nameof(registers));
        }

        public string RegisterName { get; set; }

        public string RegisterNameToCheck { get; set; }

        public int Value { get; set; }

        public Predicate<int> Condition { get; set; }

        public void Execute()
        {
            if(this.registers[this.RegisterNameToCheck].MatchesPredicate(this.Condition))
            {
                this.ExecuteCore();
            }
        }

        protected abstract void ExecuteCore();
    }
}
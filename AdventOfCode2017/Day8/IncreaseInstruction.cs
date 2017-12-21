namespace AdventOfCode2017.Day8
{
    public class IncreaseInstruction : Instruction
    {
        public IncreaseInstruction(RegistersCollection registers) : base(registers)
        {

        }

        protected override void ExecuteCore()
        {
            this.registers[this.RegisterName].Increase(this.Value);
        }
    }
}

namespace AdventOfCode2017.Day8
{
    public class DecreaseInstruction : Instruction
    {
        public DecreaseInstruction(RegistersCollection registers) : base(registers)
        {

        }

        protected override void ExecuteCore()
        {
            this.registers[this.RegisterName].Decrease(this.Value);
        }
    }
}

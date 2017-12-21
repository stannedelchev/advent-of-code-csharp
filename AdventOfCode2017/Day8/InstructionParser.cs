using System.Text.RegularExpressions;

namespace AdventOfCode2017.Day8
{
    public class InstructionParser
    {
        private readonly RegistersCollection registers;

        public InstructionParser(RegistersCollection registers)
        {
            this.registers = registers;
        }

        public Instruction Parse(string line)
        {
            var regex = new Regex(@"(?<regName>[a-z]+) (?<op>inc|dec) (?<opVal>-?[0-9]+) (if) (?<checkReg>[a-z]+) (?<cond><|<=|==|!=|>=|>) (?<valToCheck>-?[0-9]+)");
            var match = regex.Match(line);

            var registerName = match.Groups["regName"].Value;
            var operation = match.Groups["op"].Value;
            var operationValue = int.Parse(match.Groups["opVal"].Value);
            var registerToCheck = match.Groups["checkReg"].Value;
            var condition = match.Groups["cond"].Value;
            var valueToCheck = int.Parse(match.Groups["valToCheck"].Value);

            var result = new InstructionFactory(this.registers).Create(registerName, operation, operationValue, registerToCheck, condition, valueToCheck);
            return result;
        }
    }
}
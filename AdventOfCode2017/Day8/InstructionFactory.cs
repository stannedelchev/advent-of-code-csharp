using System;
using System.Collections.Generic;

namespace AdventOfCode2017.Day8
{
    public class InstructionFactory
    {
        private readonly RegistersCollection registers;

        public InstructionFactory(RegistersCollection registers)
        {
            this.registers = registers;
        }

        public Instruction Create(string registerName, string operation, int operationValue, string registerToCheck, string condition, int valueToCheck)
        {
            Instruction result;

            switch (operation)
            {
                case "inc":
                    result = new IncreaseInstruction(this.registers);
                    break;
                case "dec":
                    result = new DecreaseInstruction(this.registers);
                    break;
                default:
                    throw new NotImplementedException(operation);
            }

            result.RegisterName = registerName;
            result.RegisterNameToCheck = registerToCheck;
            result.Value = operationValue;

            var conditionsTable = new Dictionary<string, Predicate<int>>()
            {
                { "<",  v => v < valueToCheck },
                { "<=",  v => v <= valueToCheck },
                { "==",  v => v == valueToCheck },
                { "!=", v => v != valueToCheck },
                { ">", v => v > valueToCheck },
                { ">=", v => v >= valueToCheck }
            };

            result.Condition = conditionsTable[condition];
            return result;
        }
    }
}

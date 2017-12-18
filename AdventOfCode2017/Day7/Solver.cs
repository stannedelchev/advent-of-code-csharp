using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day7
{
    public class Solver
    {
        public string SolvePart1(string input)
        {
            /*
             * Build the graph in two passes.
             * First pass loads all the programs' names and weights in a hash table.
             * Second pass connects the appropriate children to their parents.
             * Third pass finds the root program - one without a parent.
             */

            // First and second passes
            var programs = this.SetupTree(input);

            // Third pass
            var result = this.FindRoot(programs.Values).Name;

            return result;
        }

        public int SolvePart2(string input)
        {
            var programs = this.SetupTree(input);
            var rootProgram = this.FindRoot(programs.Values);
            var unbalancedNode = rootProgram.FindUnbalancedChildProgram();

            return unbalancedNode.Value.ExpectedWeight;
        }

        private Dictionary<string, DiscHoldingProgram> SetupTree(string input)
        {
            // First pass
            var programs = InputParser.Parse(input).ToDictionary(p => p.Name);

            // Second pass
            foreach (var program in programs.Values)
            {
                foreach (var childName in program.ChildrenNames)
                {
                    program.AddChild(programs[childName]);
                }
            }

            return programs;
        }

        private DiscHoldingProgram FindRoot(IEnumerable<DiscHoldingProgram> tree)
        {
            var root = tree.SingleOrDefault(p => p.Parent == null);
            return root;
        }
    }
}
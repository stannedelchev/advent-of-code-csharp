using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AdventOfCode2017.Day7
{
    [DebuggerDisplay("{Name} : {TotalWeight}")]
    internal class DiscHoldingProgram
    {
        private readonly List<DiscHoldingProgram> children = new List<DiscHoldingProgram>();

        public DiscHoldingProgram(string name, int weight, IEnumerable<string> childrenNames)
        {
            this.Weight = weight;
            this.Name = name;
            this.ChildrenNames = childrenNames;
        }

        public int Weight { get; }

        public string Name { get; }

        public IEnumerable<string> ChildrenNames { get; }

        public DiscHoldingProgram Parent { get; private set; }

        public IEnumerable<DiscHoldingProgram> Children => this.children;

        public int TotalWeight => this.Weight + this.ChildrenWeight;

        public int ChildrenWeight => this.children.Sum(c => c.TotalWeight);

        public (DiscHoldingProgram Program, int ExpectedWeight)? FindUnbalancedChildProgram()
        {
            var groups = this.Children.GroupBy(c => c.TotalWeight).OrderBy(c => c.Key).ToList();
            var groupsCount = groups.Count;
            if (groupsCount == 1)
            {
                return null;
            }

            if (groupsCount > 2)
            {
                throw new InvalidOperationException();
            }

            var balancedGroup = groups[0];
            var unbalancedGroup = groups[1];

            var unbalancedChild = unbalancedGroup.First();

            var unbalancedGrandChild = unbalancedChild.FindUnbalancedChildProgram();
            if (unbalancedGrandChild == null)
            {
                int expectedWeight = unbalancedChild.Weight - (unbalancedGroup.Key - balancedGroup.Key);
                return (unbalancedChild, expectedWeight);
            }

            return unbalancedGrandChild;
        }



        public void AddChild(DiscHoldingProgram child)
        {
            this.children.Add(child);
            child.Parent = this;
        }
    }
}
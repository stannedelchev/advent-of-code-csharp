using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2017.Day7
{
    internal static class InputParser
    {
        public static IEnumerable<DiscHoldingProgram> Parse(string input)
        {
            var result = input.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(ParseCore)
                        .ToList();
            return result;
        }

        private static DiscHoldingProgram ParseCore(string line)
        {
            var lineParts = line.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"(?<name>[a-z]+)\s*\((?<weight>\d+)\)\s*(->\s((?<children>[a-z]+),*\s*)*)*");
            var match = regex.Match(line);

            var name = match.Groups["name"].Value;
            int weight = int.Parse(match.Groups["weight"].Value);
            var childrenNames = new List<string>();

            var childrenGroup = match.Groups["children"];
            if (childrenGroup.Success)
            {
                for (int i = 0; i < childrenGroup.Captures.Count; i++)
                {
                    var childName = childrenGroup.Captures[i].Value;
                    childrenNames.Add(childName);
                }
            }

            return new DiscHoldingProgram(name, weight, childrenNames);
        }
    }
}
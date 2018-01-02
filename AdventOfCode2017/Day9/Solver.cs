using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2017.Day9
{
    public class Solver
    {
        public int SolvePart1(string input)
        {
            var (totalScore, _) = this.SolveCore(input);
            return totalScore;
        }


        public int SolvePart2(string input)
        {
            var (_, totalGarbageCount) = this.SolveCore(input);
            return totalGarbageCount;
        }

        private (int totalScore, int garbageCount) SolveCore(string input)
        {
            int totalScore = 0;
            int totalGarbageCount = 0;

            using (var reader = new StringReader(input))
            {
                int baseScore = 0;

                char c;
                while ((c = (char)reader.Read()) != '\uFFFF')
                {
                    switch (c)
                    {
                        case '{':
                            baseScore++;
                            totalScore += baseScore;
                            break;
                        case '}':
                            baseScore--;
                            break;
                        case '<':
                            char garbageChar;
                            do
                            {
                                garbageChar = (char)reader.Read();
                                switch (garbageChar)
                                {
                                    case '!':
                                        reader.Read();
                                        break;
                                    case '>':
                                        break;
                                    default:
                                        totalGarbageCount++;
                                        break;
                                }
                            }
                            while (garbageChar != '>');
                            break;
                        default:
                            break;
                    }
                }
            }

            return (totalScore, totalGarbageCount);
        }
    }
}
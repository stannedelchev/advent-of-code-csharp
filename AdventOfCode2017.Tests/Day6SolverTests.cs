using AdventOfCode2017.Day6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdventOfCode2017.Tests
{
    [TestClass]
    [TestCategory("Day6")]
    public class Day6SolverTests
    {
        private const string exampleInput = "0 2 7 0";
        private const string realInput = "2	8	8	5	4	2	3	1	5	5	1	2	15	13	5	14";

        private Solver solver;

        [TestMethod]
        public void Part1Example1_Passes()
        {
            var result = this.solver.SolvePart1(exampleInput);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Part1_Passes()
        {
            var result = this.solver.SolvePart1(realInput);
            Assert.AreEqual(3156, result);
        }

        [TestMethod]
        public void Part2Example1_Passes()
        {
            var result = this.solver.SolvePart2(exampleInput);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Part2_Passes()
        {
            var result = this.solver.SolvePart2(realInput);
            Assert.AreEqual(1610, result);
        }

        [TestInitialize]
        public void Initialize()
        {
            this.solver = new Day6.Solver();
        }
    }
}

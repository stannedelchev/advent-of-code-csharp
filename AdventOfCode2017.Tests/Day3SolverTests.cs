using AdventOfCode2017.Day3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdventOfCode2017.Tests
{
    [TestClass]
    [TestCategory("Day3")]
    public class Day3SolverTests
    {
        private Solver solver;

        [TestMethod]
        public void Part1Example1_Passes()
        {
            Assert.AreEqual(0, this.solver.SolvePart1("1"));
        }

        [TestMethod]
        public void Part1Example2_Passes()
        {
            Assert.AreEqual(3, this.solver.SolvePart1("12"));
        }

        [TestMethod]
        public void Part1Example3_Passes()
        {
            Assert.AreEqual(2, this.solver.SolvePart1("23"));
        }

        [TestMethod]
        public void Part1Example4_Passes()
        {
            Assert.AreEqual(31, this.solver.SolvePart1("1024"));
        }

        [TestMethod]
        public void Part1_Passes()
        {
            Assert.AreEqual(475, this.solver.SolvePart1("277678"));
        }


        [TestMethod]
        public void Part2_Passes()
        {
            throw new NotImplementedException();
        }

        [TestInitialize]
        public void Initialize()
        {
            this.solver = new Day3.Solver();
        }
    }
}

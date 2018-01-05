using AdventOfCode2017.Day10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdventOfCode2017.Tests
{
    [TestClass]
    [TestCategory("Day10")]
    public class Day10SolverTests
    {
        private Solver testSolver;
        private Solver realSolver;

        [TestMethod]
        public void Part1Example1_Passes()
        {
            var result = this.testSolver.SolvePart1("3,4,1,5");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Part1_Passes()
        {
            var result = this.realSolver.SolvePart1("187,254,0,81,169,219,1,190,19,102,255,56,46,32,2,216");
            Assert.AreEqual(1980, result);
        }

        [TestMethod]
        public void Part2Example1_Passes()
        {
            var result = this.realSolver.SolvePart2("");
            Assert.AreEqual("a2582a3a0e66e6e86e3812dcb672a272", result);
        }

        [TestMethod]
        public void Part2Example2_Passes()
        {
            var result = this.realSolver.SolvePart2("AoC 2017");
            Assert.AreEqual("33efeb34ea91902bb2f59c9920caa6cd", result);
        }

        [TestMethod]
        public void Part2Example3_Passes()
        {
            var result = this.realSolver.SolvePart2("1,2,3");
            Assert.AreEqual("3efbe78a8d82f29979031a4aa0b16a9d", result);
        }

        [TestMethod]
        public void Part2Example4_Passes()
        {
            var result = this.realSolver.SolvePart2("1,2,4");
            Assert.AreEqual("63960835bcdc130f0b66d7ff4f6a5a8e", result);
        }

        [TestMethod]
        public void Part2_Passes()
        {
            var result = this.realSolver.SolvePart2("187,254,0,81,169,219,1,190,19,102,255,56,46,32,2,216");
            Assert.AreEqual("899124dac21012ebc32e2f4d11eaec55", result);
        }

        [TestInitialize]
        public void Initialize()
        {
            this.testSolver = new Day10.Solver(5);
            this.realSolver = new Day10.Solver();
        }
    }
}
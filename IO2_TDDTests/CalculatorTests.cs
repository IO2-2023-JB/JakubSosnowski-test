using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO2_TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO2_TDD.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void Add_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(Calculator.Add(""), 0);
        }

        [TestMethod()]
        public void Add_OneNumber_ReturnsThisNumber()
        {
            Assert.AreEqual(Calculator.Add("1"), 1);
            Assert.AreEqual(Calculator.Add("12"), 12);
            Assert.AreEqual(Calculator.Add("123"), 123);
        }


        [TestMethod()]
        public void Add_TwoNumbersCommaDelimited_ReturnsSum()
        {
            Assert.AreEqual(Calculator.Add("1,1"), 2);
            Assert.AreEqual(Calculator.Add("12,32"), 44);
        }

        [TestMethod()]
        public void Add_TwoNumbersNewLineDelimited_ReturnsSum()
        {
            Assert.AreEqual(Calculator.Add("1\n1"), 2);
            Assert.AreEqual(Calculator.Add("12\n32"), 44);
        }

        [TestMethod()]
        public void Add_ThreeOrMoreNumbersDelimitedEitherWay_ReturnsSum()
        {
            Assert.AreEqual(Calculator.Add("1\n1,2"), 4);
            Assert.AreEqual(Calculator.Add("12\n32,4\n2,10"), 60);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "All numbers should be non-negative.")]
        public void Add_NegativeNumber_ThrowsArgumentException_1()
        {
            Assert.AreEqual(Calculator.Add("-1,2"), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "All numbers should be non-negative.")]
        public void Add_NegativeNumber_ThrowsArgumentException_2()
        {
            Assert.AreEqual(Calculator.Add("1\n3,-2"), null);
        }

        [TestMethod()]
        public void Add_NumberGreaterThan1000_IsIgnored()
        {
            Assert.AreEqual(Calculator.Add("1\n1001,2"), 3);
            Assert.AreEqual(Calculator.Add("1,3001,1000"), 1001);
        }

    }
}
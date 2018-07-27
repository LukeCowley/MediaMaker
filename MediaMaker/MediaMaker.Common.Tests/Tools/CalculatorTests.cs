using MediaMaker.Common.Tools;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaker.Common.Tests.Tools
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void Init()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Calculator_Add_Returns_Correct_Values()
        {
            //assemble
            //act
            var value = _calculator.Add(1, 2);
            //assert
            Assert.IsTrue(value == 3);
        }

        [Test]
        public void Calculator_Subtract_Returns_Correct_Value()
        {
            //assemble
            //act
            var value = _calculator.Subtract(2, 1);

            //assert
            Assert.IsTrue(value == 1);
        }

        [Test]
        public void Calculator_Multiply_Returns_Correct_Value()
        {
            //assemble
            //act
            var value = _calculator.Multiply(2, 2);

            //assert
            Assert.IsTrue(value == 4);
        }

        [Test]
        public void Calculator_Divide_Returns_Correct_Value()
        {
            //assemble
            //act
            var value = _calculator.Divide(1, 2);

            //assert
            Assert.IsTrue(Math.Round(value, 1) == 0.5);
        }
    }
}

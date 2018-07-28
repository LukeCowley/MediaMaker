using MediaMaker.Common.Tools;
using MediaMaker.Common.Tools.Calculations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaker.Common.Tests.Tools
{
    [TestFixture]
    public class BasicCalculationTests
    {
        [Test]
        public void Calculator_Add_Returns_Correct_Values()
        {
            //assemble
            var calc = new BasicCalculation(1);
            //act
            var value = calc
                .Add(2)
                .Calculate();

            //assert
            Assert.IsTrue(value == 3);
        }

        [Test]
        public void Calculator_Subtract_Returns_Correct_Value()
        {
            //assemble
            var calc = new BasicCalculation(2);
            //act
            var value = calc
                .Subtract(1)
                .Calculate();

            //assert
            Assert.IsTrue(value == 1);
        }

        [Test]
        public void Calculator_Multiply_Returns_Correct_Value()
        {
            //assemble
            var calc = new BasicCalculation(2);
            //act
            var value = calc
                .Multiply(2)
                .Calculate();

            //assert
            Assert.IsTrue(value == 4);
        }

        [Test]
        public void Calculator_Divide_Returns_Correct_Value()
        {
            //assemble
            var calc = new BasicCalculation(1);
            
            //act
            var value = calc
                .Divide(2)
                .Calculate();

            //assert
            Assert.IsTrue(Math.Round(value, 1) == 0.5);
        }
    }
}

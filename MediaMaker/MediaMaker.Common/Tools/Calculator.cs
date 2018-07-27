using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMaker.Common.Tools
{
    //TODO: inherit docstring from interface - inheritdoc.io giving issues with dotnet standard lib, should work!
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Adds two values
        /// </summary>
        /// <returns>Sum of the two values provided</returns>
        public long Add(long firstValue, long secondValue)
        {
            return firstValue + secondValue;
        }

        /// <summary>
        /// Subtracts two values
        /// </summary>
        /// <param name="subtrahend">Initial value to be subtracted from</param>
        /// <param name="minuend">Value to subtract</param>
        /// <returns>Difference of the two values</returns>
        public long Subtract(long subtrahend, long minuend)
        {
            return subtrahend - minuend;
        }

        /// <summary>
        /// Multiplies two values
        /// </summary>
        /// <returns>Product of the two inputs</returns>
        public long Multiply(long firstFactor, long secondFactor)
        {
            return firstFactor * secondFactor;
        }

        /// <summary>
        /// Divides two values
        /// </summary>
        /// <param name="numerator">The initial value before division</param>
        /// <param name="denominator">The value to divide by</param>
        /// <returns></returns>
        public double Divide(long numerator, long denominator)
        {
            throw new NotImplementedException();
        }


    }
}

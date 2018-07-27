using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMaker.Common.Tools
{
    public interface ICalculator
    {
        /// <summary>
        /// Adds two values
        /// </summary>
        /// <returns>Sum of the two values provided</returns>
        long Add(long firstValue, long secondValue);

        /// <summary>
        /// Subtracts two values
        /// </summary>
        /// <param name="subtrahend">Initial value to be subtracted from</param>
        /// <param name="minuend">Value to subtract</param>
        /// <returns>Difference of the two values</returns>
        long Subtract(long subtrahend, long minuend);

        /// <summary>
        /// Multiplies two values
        /// </summary>
        /// <returns>Product of the two inputs</returns>
        long Multiply(long firstFactor, long secondFactor);

        /// <summary>
        /// Divides two values
        /// </summary>
        /// <param name="numerator">The initial value before division</param>
        /// <param name="denominator">The value to divide by</param>
        /// <returns></returns>
        double Divide(long numerator, long denominator);
    }
}

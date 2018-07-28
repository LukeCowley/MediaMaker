using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMaker.Common.Tools.Calculations
{
    public interface IBasicCalculation
    {
        BasicCalculation Add(double value);
        BasicCalculation Subtract(double value);
        BasicCalculation Multiply(double value);
        BasicCalculation Divide(double value);
    }
}

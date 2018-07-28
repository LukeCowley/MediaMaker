using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMaker.Common.Tools.Calculations
{
    public class BasicCalculation : ICalculation, IBasicCalculation
    {
        private double _currentValue;
        public BasicCalculation(double initialValue)
        {
            _currentValue = initialValue;
        }

        public double Calculate()
        {
            return _currentValue;
        }

        public BasicCalculation Add(double value)
        {
            _currentValue += value;
            return this;
        }

        public BasicCalculation Subtract(double value)
        {
            _currentValue -= value;
            return this;
        }

        public BasicCalculation Multiply(double value)
        {
            _currentValue *= value;
            return this;
        }

        public BasicCalculation Divide(double value)
        {
            _currentValue /= value;
            return this;
        }
    }
}

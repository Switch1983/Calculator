using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCalc.Models
{
    class Calculator
    {
        private double currentSum;

        public Calculator()
        {
            currentSum = 0;
        }
        public void Reset()
        {
            currentSum = 0;
        }
        public void Set(double value)
        {
            currentSum = value;
        }
        public void Add(double value)
        {
            currentSum += value;
        }
        public void Subtract(double value)
        {
            currentSum -= value;
        }
        public void Divide(double value)
        {
            if (value != 0)
            {
                currentSum /= value;
            }
            else
            {
                currentSum = 0;
                throw new DivideByZeroException();
            }
        }
        public void Multiply(double value)
        {
            currentSum *= value;
        }
        public double SQRT(double value)
        {
            currentSum = Math.Sqrt(value);
            return currentSum;
        }
        public double Inverse(double value)
        {
            return 0 - value;
        }
        public double COS(double value)
        {
            currentSum = Math.Cos(value);
            return currentSum;
        }
        public double TAN(double value)
        {
            currentSum = Math.Tan(value);
            return currentSum;
        }
        public double SIN(double value)
        {
            currentSum = Math.Sin(value);
            return currentSum;
        }

        public double GetResult()
        {
            return currentSum;
        }
    }
}

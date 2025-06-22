using System;
using Wrapper.Interface;

namespace Wrapper
{
    public class AdvanceCalculator : IAdvanceCalculator
    {
        // Implementation of ICalculatorAdvancedFunctions methods
        public double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Square root of a negative number is not allowed.");
            }
            return Math.Sqrt(value);
        }

        public double AbsoluteValue(double value)
        {
            return Math.Abs(value);
        }

        public long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Factorial is not defined for negative numbers.");
            }
            if (n == 0)
            {
                return 1;
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public double Modulo(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Modulo by zero is not allowed.");
            }
            return dividend % divisor;
        }
    }
}

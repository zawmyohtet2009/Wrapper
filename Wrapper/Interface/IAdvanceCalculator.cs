using System;

namespace Wrapper.Interface
{
    public interface IAdvanceCalculator
    {
        /// <summary>
        /// Calculates the power of a base to an exponent.
        /// </summary>
        /// <param name="baseValue">The base number.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of baseValue raised to the power of exponent.</returns>
        double Power(double baseValue, double exponent);

        /// <summary>
        /// Calculates the square root of a number.
        /// </summary>
        /// <param name="value">The number to calculate the square root of.</param>
        /// <returns>The square root of the value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the value is negative.</exception>
        double SquareRoot(double value);

        /// <summary>
        /// Calculates the absolute value of a number.
        /// </summary>
        /// <param name="value">The number.</param>
        /// <returns>The absolute value of the number.</returns>
        double AbsoluteValue(double value);

        /// <summary>
        /// Calculates the factorial of a non-negative integer.
        /// </summary>
        /// <param name="n">The non-negative integer.</param>
        /// <returns>The factorial of n.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if n is negative.</exception>
        long Factorial(int n);

        /// <summary>
        /// Calculates the modulus (remainder) of two numbers.
        /// </summary>
        /// <param name="dividend">The number to be divided.</param>
        /// <param name="divisor">The number by which to divide.</param>
        /// <returns>The remainder of the division.</returns>
        /// <exception cref="DivideByZeroException">Thrown if the divisor is zero.</exception>
        double Modulo(double dividend, double divisor);
    }
}

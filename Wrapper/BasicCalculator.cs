using Common;
using Common.Interface;
using Wrapper.Interface;

namespace Wrapper
{
    /// <summary>
    /// Basic Calculator
    /// </summary>
    public class BasicCalculator : IBasicCalculator
    {
        private readonly ICalculator _commonCalculator;

        public BasicCalculator()
        {
            _commonCalculator = new Calculator();
        }
        
        public int WrapperAdd(int a, int b)
        {
            return _commonCalculator.Add(a, b);
        }

        public int WrapperSubtract(int a, int b)
        {
            return _commonCalculator.Subtract(a, b);
        }

        public int WrapperMultiply(int a, int b)
        {
            return _commonCalculator.Multiply(a, b);
        }

        public int WrapperDivide(int a, int b)
        {
            return _commonCalculator.Divide(a, b);
        }
    }
}

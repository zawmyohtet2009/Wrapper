using Common;
using Common.Interface;
using Wrapper.Interface;

namespace Wrapper
{
    public class BasicCalculator : IBasicCalculator
    {
        private readonly ICalculator commonCalculator;

        public BasicCalculator()
        {
            commonCalculator = new Calculator();
        }
        
        public int WrapperAdd(int a, int b)
        {
            return commonCalculator.Add(a, b);
        }

        public int WrapperSubtract(int a, int b)
        {
            return commonCalculator.Subtract(a, b);
        }

        public int WrapperMultiply(int a, int b)
        {
            return commonCalculator.Multiply(a, b);
        }

        public int WrapperDivide(int a, int b)
        {
            return commonCalculator.Divide(a, b);
        }
    }
}

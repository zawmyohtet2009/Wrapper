﻿namespace Wrapper.Interface
{
    /// <summary>
    /// IBasicCalculator interface
    /// </summary>
    public interface IBasicCalculator
    {
        int WrapperAdd(int a, int b);
        int WrapperSubtract(int a, int b);
        int WrapperMultiply(int a, int b);
        int WrapperDivide(int a, int b);
    }
}

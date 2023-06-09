﻿

namespace Calculators.Math;

public class MultiplyOperation : Operation
{
    public override double Calculate(double[] numbers)
    {
        var result = numbers[0];
        for (var i = 1; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }

    public object Symbol { get;}
}  
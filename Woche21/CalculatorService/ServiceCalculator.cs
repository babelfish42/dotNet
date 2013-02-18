using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    public class ServiceCalculator : ICalculatorService
    {
        public float Adding(CalculatorServiceParameter value)
        {
            return value.Parameter1 + value.Parameter2;
        }

        public float Subtraction(CalculatorServiceParameter value)
        {
            return value.Parameter1 - value.Parameter2;
        }

        public float Multiplication(CalculatorServiceParameter value)
        {
            return value.Parameter1 * value.Parameter2;
        }

        public float Division(CalculatorServiceParameter value)
        {
            return value.Parameter1 / value.Parameter2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        float Adding(CalculatorServiceParameter value);

        [OperationContract]
        float Subtraction(CalculatorServiceParameter value);

        [OperationContract]
        float Multiplication(CalculatorServiceParameter value);

        [OperationContract]
        float Division(CalculatorServiceParameter value);
    }

    [DataContract]
    public class CalculatorServiceParameter
    {
        [DataMember]
        public float Parameter1
        {
            get;
            set;
        }

        [DataMember]
        public float Parameter2
        {
            get;
            set;
        }
    }
}

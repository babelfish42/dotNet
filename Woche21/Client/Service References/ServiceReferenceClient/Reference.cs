﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculatorServiceParameter", Namespace="http://schemas.datacontract.org/2004/07/CalculatorService")]
    [System.SerializableAttribute()]
    public partial class CalculatorServiceParameter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Parameter1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Parameter2Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Parameter1 {
            get {
                return this.Parameter1Field;
            }
            set {
                if ((this.Parameter1Field.Equals(value) != true)) {
                    this.Parameter1Field = value;
                    this.RaisePropertyChanged("Parameter1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Parameter2 {
            get {
                return this.Parameter2Field;
            }
            set {
                if ((this.Parameter2Field.Equals(value) != true)) {
                    this.Parameter2Field = value;
                    this.RaisePropertyChanged("Parameter2");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceClient.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Adding", ReplyAction="http://tempuri.org/ICalculatorService/AddingResponse")]
        float Adding(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtraction", ReplyAction="http://tempuri.org/ICalculatorService/SubtractionResponse")]
        float Subtraction(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiplication", ReplyAction="http://tempuri.org/ICalculatorService/MultiplicationResponse")]
        float Multiplication(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Division", ReplyAction="http://tempuri.org/ICalculatorService/DivisionResponse")]
        float Division(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.ICalculatorService>, ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float Adding(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value) {
            return base.Channel.Adding(value);
        }
        
        public float Subtraction(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value) {
            return base.Channel.Subtraction(value);
        }
        
        public float Multiplication(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value) {
            return base.Channel.Multiplication(value);
        }
        
        public float Division(ZHAW.Philipp.Bachmann.L12.ServiceReferenceClient.CalculatorServiceParameter value) {
            return base.Channel.Division(value);
        }
    }
}

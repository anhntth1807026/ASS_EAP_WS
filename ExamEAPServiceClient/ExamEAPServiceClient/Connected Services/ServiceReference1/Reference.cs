﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamEAPServiceClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/ExamEAPService.Model")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryField;
        
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
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryField, value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEmployeeServices")]
    public interface IEmployeeServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeServices/Search", ReplyAction="http://tempuri.org/IEmployeeServices/SearchResponse")]
        ExamEAPServiceClient.ServiceReference1.Employee[] Search(string department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeServices/Search", ReplyAction="http://tempuri.org/IEmployeeServices/SearchResponse")]
        System.Threading.Tasks.Task<ExamEAPServiceClient.ServiceReference1.Employee[]> SearchAsync(string department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeServices/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeServices/CreateEmployeeResponse")]
        ExamEAPServiceClient.ServiceReference1.Employee CreateEmployee(ExamEAPServiceClient.ServiceReference1.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeServices/CreateEmployee", ReplyAction="http://tempuri.org/IEmployeeServices/CreateEmployeeResponse")]
        System.Threading.Tasks.Task<ExamEAPServiceClient.ServiceReference1.Employee> CreateEmployeeAsync(ExamEAPServiceClient.ServiceReference1.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServicesChannel : ExamEAPServiceClient.ServiceReference1.IEmployeeServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServicesClient : System.ServiceModel.ClientBase<ExamEAPServiceClient.ServiceReference1.IEmployeeServices>, ExamEAPServiceClient.ServiceReference1.IEmployeeServices {
        
        public EmployeeServicesClient() {
        }
        
        public EmployeeServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ExamEAPServiceClient.ServiceReference1.Employee[] Search(string department) {
            return base.Channel.Search(department);
        }
        
        public System.Threading.Tasks.Task<ExamEAPServiceClient.ServiceReference1.Employee[]> SearchAsync(string department) {
            return base.Channel.SearchAsync(department);
        }
        
        public ExamEAPServiceClient.ServiceReference1.Employee CreateEmployee(ExamEAPServiceClient.ServiceReference1.Employee employee) {
            return base.Channel.CreateEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<ExamEAPServiceClient.ServiceReference1.Employee> CreateEmployeeAsync(ExamEAPServiceClient.ServiceReference1.Employee employee) {
            return base.Channel.CreateEmployeeAsync(employee);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL_MVC.ServiceReferenceDepartamento {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/SLWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Departamento))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Area))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Exception))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMassageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Exception ExField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ObjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] ObjectsField;
        
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
        public bool Correct {
            get {
                return this.CorrectField;
            }
            set {
                if ((this.CorrectField.Equals(value) != true)) {
                    this.CorrectField = value;
                    this.RaisePropertyChanged("Correct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMassage {
            get {
                return this.ErrorMassageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMassageField, value) != true)) {
                    this.ErrorMassageField = value;
                    this.RaisePropertyChanged("ErrorMassage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Ex {
            get {
                return this.ExField;
            }
            set {
                if ((object.ReferenceEquals(this.ExField, value) != true)) {
                    this.ExField = value;
                    this.RaisePropertyChanged("Ex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Object {
            get {
                return this.ObjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectField, value) != true)) {
                    this.ObjectField = value;
                    this.RaisePropertyChanged("Object");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] Objects {
            get {
                return this.ObjectsField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsField, value) != true)) {
                    this.ObjectsField = value;
                    this.RaisePropertyChanged("Objects");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDepartamento.IDepartamentoServices")]
    public interface IDepartamentoServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/Add", ReplyAction="http://tempuri.org/IDepartamentoServices/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceDepartamento.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        PL_MVC.ServiceReferenceDepartamento.Result Add(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/Add", ReplyAction="http://tempuri.org/IDepartamentoServices/AddResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> AddAsync(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/Delete", ReplyAction="http://tempuri.org/IDepartamentoServices/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceDepartamento.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        PL_MVC.ServiceReferenceDepartamento.Result Delete(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/Delete", ReplyAction="http://tempuri.org/IDepartamentoServices/DeleteResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> DeleteAsync(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/Update", ReplyAction="http://tempuri.org/IDepartamentoServices/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceDepartamento.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        PL_MVC.ServiceReferenceDepartamento.Result Update(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/Update", ReplyAction="http://tempuri.org/IDepartamentoServices/UpdateResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> UpdateAsync(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/GetAll", ReplyAction="http://tempuri.org/IDepartamentoServices/GetAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceDepartamento.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        PL_MVC.ServiceReferenceDepartamento.Result GetAll(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/GetAll", ReplyAction="http://tempuri.org/IDepartamentoServices/GetAllResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> GetAllAsync(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/GetById", ReplyAction="http://tempuri.org/IDepartamentoServices/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceDepartamento.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        PL_MVC.ServiceReferenceDepartamento.Result GetById(ML.Departamento departamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDepartamentoServices/GetById", ReplyAction="http://tempuri.org/IDepartamentoServices/GetByIdResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> GetByIdAsync(ML.Departamento departamento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDepartamentoServicesChannel : PL_MVC.ServiceReferenceDepartamento.IDepartamentoServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DepartamentoServicesClient : System.ServiceModel.ClientBase<PL_MVC.ServiceReferenceDepartamento.IDepartamentoServices>, PL_MVC.ServiceReferenceDepartamento.IDepartamentoServices {
        
        public DepartamentoServicesClient() {
        }
        
        public DepartamentoServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DepartamentoServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartamentoServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DepartamentoServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PL_MVC.ServiceReferenceDepartamento.Result Add(ML.Departamento departamento) {
            return base.Channel.Add(departamento);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> AddAsync(ML.Departamento departamento) {
            return base.Channel.AddAsync(departamento);
        }
        
        public PL_MVC.ServiceReferenceDepartamento.Result Delete(ML.Departamento departamento) {
            return base.Channel.Delete(departamento);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> DeleteAsync(ML.Departamento departamento) {
            return base.Channel.DeleteAsync(departamento);
        }
        
        public PL_MVC.ServiceReferenceDepartamento.Result Update(ML.Departamento departamento) {
            return base.Channel.Update(departamento);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> UpdateAsync(ML.Departamento departamento) {
            return base.Channel.UpdateAsync(departamento);
        }
        
        public PL_MVC.ServiceReferenceDepartamento.Result GetAll(ML.Departamento departamento) {
            return base.Channel.GetAll(departamento);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> GetAllAsync(ML.Departamento departamento) {
            return base.Channel.GetAllAsync(departamento);
        }
        
        public PL_MVC.ServiceReferenceDepartamento.Result GetById(ML.Departamento departamento) {
            return base.Channel.GetById(departamento);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceDepartamento.Result> GetByIdAsync(ML.Departamento departamento) {
            return base.Channel.GetByIdAsync(departamento);
        }
    }
}

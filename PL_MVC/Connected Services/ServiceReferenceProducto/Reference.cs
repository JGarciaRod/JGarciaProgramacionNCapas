﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL_MVC.ServiceReferenceProducto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/SLWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Producto))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Departamento))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Area))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Proveedor))]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceProducto.IProductoServicio")]
    public interface IProductoServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/Add", ReplyAction="http://tempuri.org/IProductoServicio/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Departamento))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Proveedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceProducto.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        PL_MVC.ServiceReferenceProducto.Result Add(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/Add", ReplyAction="http://tempuri.org/IProductoServicio/AddResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> AddAsync(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/Delete", ReplyAction="http://tempuri.org/IProductoServicio/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Departamento))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Proveedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceProducto.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        PL_MVC.ServiceReferenceProducto.Result Delete(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/Delete", ReplyAction="http://tempuri.org/IProductoServicio/DeleteResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> DeleteAsync(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/Update", ReplyAction="http://tempuri.org/IProductoServicio/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Departamento))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Proveedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceProducto.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        PL_MVC.ServiceReferenceProducto.Result Update(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/Update", ReplyAction="http://tempuri.org/IProductoServicio/UpdateResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> UpdateAsync(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/GetAll", ReplyAction="http://tempuri.org/IProductoServicio/GetAllResponse")]
        PL_MVC.ServiceReferenceProducto.Result GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/GetAll", ReplyAction="http://tempuri.org/IProductoServicio/GetAllResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/GetById", ReplyAction="http://tempuri.org/IProductoServicio/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Departamento))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Area))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Proveedor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL_MVC.ServiceReferenceProducto.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        PL_MVC.ServiceReferenceProducto.Result GetById(ML.Producto producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoServicio/GetById", ReplyAction="http://tempuri.org/IProductoServicio/GetByIdResponse")]
        System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> GetByIdAsync(ML.Producto producto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductoServicioChannel : PL_MVC.ServiceReferenceProducto.IProductoServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductoServicioClient : System.ServiceModel.ClientBase<PL_MVC.ServiceReferenceProducto.IProductoServicio>, PL_MVC.ServiceReferenceProducto.IProductoServicio {
        
        public ProductoServicioClient() {
        }
        
        public ProductoServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductoServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PL_MVC.ServiceReferenceProducto.Result Add(ML.Producto producto) {
            return base.Channel.Add(producto);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> AddAsync(ML.Producto producto) {
            return base.Channel.AddAsync(producto);
        }
        
        public PL_MVC.ServiceReferenceProducto.Result Delete(ML.Producto producto) {
            return base.Channel.Delete(producto);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> DeleteAsync(ML.Producto producto) {
            return base.Channel.DeleteAsync(producto);
        }
        
        public PL_MVC.ServiceReferenceProducto.Result Update(ML.Producto producto) {
            return base.Channel.Update(producto);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> UpdateAsync(ML.Producto producto) {
            return base.Channel.UpdateAsync(producto);
        }
        
        public PL_MVC.ServiceReferenceProducto.Result GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public PL_MVC.ServiceReferenceProducto.Result GetById(ML.Producto producto) {
            return base.Channel.GetById(producto);
        }
        
        public System.Threading.Tasks.Task<PL_MVC.ServiceReferenceProducto.Result> GetByIdAsync(ML.Producto producto) {
            return base.Channel.GetByIdAsync(producto);
        }
    }
}
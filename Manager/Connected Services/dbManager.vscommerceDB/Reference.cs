﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager.dbManager.vscommerceDB {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/dbManager.vscommerceDB")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fiscalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fiscalCode {
            get {
                return this.fiscalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.fiscalCodeField, value) != true)) {
                    this.fiscalCodeField = value;
                    this.RaisePropertyChanged("fiscalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAdmin {
            get {
                return this.isAdminField;
            }
            set {
                if ((this.isAdminField.Equals(value) != true)) {
                    this.isAdminField = value;
                    this.RaisePropertyChanged("isAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="dbManager.vscommerceDB.IDBManager")]
    public interface IDBManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBManager/DoWork", ReplyAction="http://tempuri.org/IDBManager/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBManager/DoWork", ReplyAction="http://tempuri.org/IDBManager/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBManager/GetUserByEmail", ReplyAction="http://tempuri.org/IDBManager/GetUserByEmailResponse")]
        Manager.dbManager.vscommerceDB.User GetUserByEmail(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBManager/GetUserByEmail", ReplyAction="http://tempuri.org/IDBManager/GetUserByEmailResponse")]
        System.Threading.Tasks.Task<Manager.dbManager.vscommerceDB.User> GetUserByEmailAsync(string Email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBManagerChannel : Manager.dbManager.vscommerceDB.IDBManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBManagerClient : System.ServiceModel.ClientBase<Manager.dbManager.vscommerceDB.IDBManager>, Manager.dbManager.vscommerceDB.IDBManager {
        
        public DBManagerClient() {
        }
        
        public DBManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public Manager.dbManager.vscommerceDB.User GetUserByEmail(string Email) {
            return base.Channel.GetUserByEmail(Email);
        }
        
        public System.Threading.Tasks.Task<Manager.dbManager.vscommerceDB.User> GetUserByEmailAsync(string Email) {
            return base.Channel.GetUserByEmailAsync(Email);
        }
    }
}

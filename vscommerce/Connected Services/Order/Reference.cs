﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vscommerce.Order {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/dbManager.vscommerceDB")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private vscommerce.Order.User customerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private vscommerce.Order.OrderLine[] orderLinesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double totalField;
        
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
        public vscommerce.Order.User customer {
            get {
                return this.customerField;
            }
            set {
                if ((object.ReferenceEquals(this.customerField, value) != true)) {
                    this.customerField = value;
                    this.RaisePropertyChanged("customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public vscommerce.Order.OrderLine[] orderLines {
            get {
                return this.orderLinesField;
            }
            set {
                if ((object.ReferenceEquals(this.orderLinesField, value) != true)) {
                    this.orderLinesField = value;
                    this.RaisePropertyChanged("orderLines");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
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
        private System.DateTime birthdayField;
        
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
        public System.DateTime birthday {
            get {
                return this.birthdayField;
            }
            set {
                if ((this.birthdayField.Equals(value) != true)) {
                    this.birthdayField = value;
                    this.RaisePropertyChanged("birthday");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderLine", Namespace="http://schemas.datacontract.org/2004/07/dbManager.vscommerceDB")]
    [System.SerializableAttribute()]
    public partial class OrderLine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int orderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private vscommerce.Order.Product productField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int qtyField;
        
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
        public int order {
            get {
                return this.orderField;
            }
            set {
                if ((this.orderField.Equals(value) != true)) {
                    this.orderField = value;
                    this.RaisePropertyChanged("order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double priceUnit {
            get {
                return this.priceUnitField;
            }
            set {
                if ((this.priceUnitField.Equals(value) != true)) {
                    this.priceUnitField = value;
                    this.RaisePropertyChanged("priceUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public vscommerce.Order.Product product {
            get {
                return this.productField;
            }
            set {
                if ((object.ReferenceEquals(this.productField, value) != true)) {
                    this.productField = value;
                    this.RaisePropertyChanged("product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int qty {
            get {
                return this.qtyField;
            }
            set {
                if ((this.qtyField.Equals(value) != true)) {
                    this.qtyField = value;
                    this.RaisePropertyChanged("qty");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/dbManager.vscommerceDB")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string barcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private vscommerce.Order.Brand brandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private vscommerce.Order.Category categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int qtyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int taxField;
        
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
        public string barcode {
            get {
                return this.barcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.barcodeField, value) != true)) {
                    this.barcodeField = value;
                    this.RaisePropertyChanged("barcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public vscommerce.Order.Brand brand {
            get {
                return this.brandField;
            }
            set {
                if ((object.ReferenceEquals(this.brandField, value) != true)) {
                    this.brandField = value;
                    this.RaisePropertyChanged("brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public vscommerce.Order.Category category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
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
        public double price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int qty {
            get {
                return this.qtyField;
            }
            set {
                if ((this.qtyField.Equals(value) != true)) {
                    this.qtyField = value;
                    this.RaisePropertyChanged("qty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int tax {
            get {
                return this.taxField;
            }
            set {
                if ((this.taxField.Equals(value) != true)) {
                    this.taxField = value;
                    this.RaisePropertyChanged("tax");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Brand", Namespace="http://schemas.datacontract.org/2004/07/dbManager.vscommerceDB")]
    [System.SerializableAttribute()]
    public partial class Brand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/dbManager.vscommerceDB")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
    [System.SerializableAttribute()]
    public partial class ManagerFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Order.IOrderManager")]
    public interface IOrderManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/getOrdersByPartner", ReplyAction="http://tempuri.org/IOrderManager/getOrdersByPartnerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Order.ManagerFault), Action="http://tempuri.org/IOrderManager/getOrdersByPartnerManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        vscommerce.Order.Order[] getOrdersByPartner(string email, string password, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/getOrdersByPartner", ReplyAction="http://tempuri.org/IOrderManager/getOrdersByPartnerResponse")]
        System.Threading.Tasks.Task<vscommerce.Order.Order[]> getOrdersByPartnerAsync(string email, string password, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/getOrders", ReplyAction="http://tempuri.org/IOrderManager/getOrdersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Order.ManagerFault), Action="http://tempuri.org/IOrderManager/getOrdersManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        vscommerce.Order.Order[] getOrders(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/getOrders", ReplyAction="http://tempuri.org/IOrderManager/getOrdersResponse")]
        System.Threading.Tasks.Task<vscommerce.Order.Order[]> getOrdersAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/createOrder", ReplyAction="http://tempuri.org/IOrderManager/createOrderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Order.ManagerFault), Action="http://tempuri.org/IOrderManager/createOrderManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        bool createOrder(string email, string password, vscommerce.Order.Order newOrder, vscommerce.Order.OrderLine[] orderLines);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/createOrder", ReplyAction="http://tempuri.org/IOrderManager/createOrderResponse")]
        System.Threading.Tasks.Task<bool> createOrderAsync(string email, string password, vscommerce.Order.Order newOrder, vscommerce.Order.OrderLine[] orderLines);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/getOrderById", ReplyAction="http://tempuri.org/IOrderManager/getOrderByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Order.ManagerFault), Action="http://tempuri.org/IOrderManager/getOrderByIdManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        vscommerce.Order.Order getOrderById(string email, string password, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/getOrderById", ReplyAction="http://tempuri.org/IOrderManager/getOrderByIdResponse")]
        System.Threading.Tasks.Task<vscommerce.Order.Order> getOrderByIdAsync(string email, string password, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/deleteOrder", ReplyAction="http://tempuri.org/IOrderManager/deleteOrderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Order.ManagerFault), Action="http://tempuri.org/IOrderManager/deleteOrderManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        bool deleteOrder(string email, string password, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderManager/deleteOrder", ReplyAction="http://tempuri.org/IOrderManager/deleteOrderResponse")]
        System.Threading.Tasks.Task<bool> deleteOrderAsync(string email, string password, int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderManagerChannel : vscommerce.Order.IOrderManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderManagerClient : System.ServiceModel.ClientBase<vscommerce.Order.IOrderManager>, vscommerce.Order.IOrderManager {
        
        public OrderManagerClient() {
        }
        
        public OrderManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public vscommerce.Order.Order[] getOrdersByPartner(string email, string password, int ID) {
            return base.Channel.getOrdersByPartner(email, password, ID);
        }
        
        public System.Threading.Tasks.Task<vscommerce.Order.Order[]> getOrdersByPartnerAsync(string email, string password, int ID) {
            return base.Channel.getOrdersByPartnerAsync(email, password, ID);
        }
        
        public vscommerce.Order.Order[] getOrders(string email, string password) {
            return base.Channel.getOrders(email, password);
        }
        
        public System.Threading.Tasks.Task<vscommerce.Order.Order[]> getOrdersAsync(string email, string password) {
            return base.Channel.getOrdersAsync(email, password);
        }
        
        public bool createOrder(string email, string password, vscommerce.Order.Order newOrder, vscommerce.Order.OrderLine[] orderLines) {
            return base.Channel.createOrder(email, password, newOrder, orderLines);
        }
        
        public System.Threading.Tasks.Task<bool> createOrderAsync(string email, string password, vscommerce.Order.Order newOrder, vscommerce.Order.OrderLine[] orderLines) {
            return base.Channel.createOrderAsync(email, password, newOrder, orderLines);
        }
        
        public vscommerce.Order.Order getOrderById(string email, string password, int ID) {
            return base.Channel.getOrderById(email, password, ID);
        }
        
        public System.Threading.Tasks.Task<vscommerce.Order.Order> getOrderByIdAsync(string email, string password, int ID) {
            return base.Channel.getOrderByIdAsync(email, password, ID);
        }
        
        public bool deleteOrder(string email, string password, int ID) {
            return base.Channel.deleteOrder(email, password, ID);
        }
        
        public System.Threading.Tasks.Task<bool> deleteOrderAsync(string email, string password, int ID) {
            return base.Channel.deleteOrderAsync(email, password, ID);
        }
    }
}

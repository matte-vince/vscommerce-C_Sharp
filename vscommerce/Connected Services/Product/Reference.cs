﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vscommerce.Product {
    using System.Runtime.Serialization;
    using System;
    
    
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
        private vscommerce.Product.Brand brandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private vscommerce.Product.Category categoryField;
        
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
        public vscommerce.Product.Brand brand {
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
        public vscommerce.Product.Category category {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Product.IProductManager")]
    public interface IProductManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/getProducts", ReplyAction="http://tempuri.org/IProductManager/getProductsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Product.ManagerFault), Action="http://tempuri.org/IProductManager/getProductsManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        vscommerce.Product.Product[] getProducts(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/getProducts", ReplyAction="http://tempuri.org/IProductManager/getProductsResponse")]
        System.Threading.Tasks.Task<vscommerce.Product.Product[]> getProductsAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/getProductById", ReplyAction="http://tempuri.org/IProductManager/getProductByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Product.ManagerFault), Action="http://tempuri.org/IProductManager/getProductByIdManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        vscommerce.Product.Product getProductById(int productId, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/getProductById", ReplyAction="http://tempuri.org/IProductManager/getProductByIdResponse")]
        System.Threading.Tasks.Task<vscommerce.Product.Product> getProductByIdAsync(int productId, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/updateProduct", ReplyAction="http://tempuri.org/IProductManager/updateProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Product.ManagerFault), Action="http://tempuri.org/IProductManager/updateProductManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        bool updateProduct(string email, string password, vscommerce.Product.Product updatedProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/updateProduct", ReplyAction="http://tempuri.org/IProductManager/updateProductResponse")]
        System.Threading.Tasks.Task<bool> updateProductAsync(string email, string password, vscommerce.Product.Product updatedProduct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/createProduct", ReplyAction="http://tempuri.org/IProductManager/createProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(vscommerce.Product.ManagerFault), Action="http://tempuri.org/IProductManager/createProductManagerFaultFault", Name="ManagerFault", Namespace="http://schemas.datacontract.org/2004/07/Manager")]
        bool createProduct(string email, string password, vscommerce.Product.Product productToCreate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductManager/createProduct", ReplyAction="http://tempuri.org/IProductManager/createProductResponse")]
        System.Threading.Tasks.Task<bool> createProductAsync(string email, string password, vscommerce.Product.Product productToCreate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductManagerChannel : vscommerce.Product.IProductManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductManagerClient : System.ServiceModel.ClientBase<vscommerce.Product.IProductManager>, vscommerce.Product.IProductManager {
        
        public ProductManagerClient() {
        }
        
        public ProductManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public vscommerce.Product.Product[] getProducts(string email, string password) {
            return base.Channel.getProducts(email, password);
        }
        
        public System.Threading.Tasks.Task<vscommerce.Product.Product[]> getProductsAsync(string email, string password) {
            return base.Channel.getProductsAsync(email, password);
        }
        
        public vscommerce.Product.Product getProductById(int productId, string email, string password) {
            return base.Channel.getProductById(productId, email, password);
        }
        
        public System.Threading.Tasks.Task<vscommerce.Product.Product> getProductByIdAsync(int productId, string email, string password) {
            return base.Channel.getProductByIdAsync(productId, email, password);
        }
        
        public bool updateProduct(string email, string password, vscommerce.Product.Product updatedProduct) {
            return base.Channel.updateProduct(email, password, updatedProduct);
        }
        
        public System.Threading.Tasks.Task<bool> updateProductAsync(string email, string password, vscommerce.Product.Product updatedProduct) {
            return base.Channel.updateProductAsync(email, password, updatedProduct);
        }
        
        public bool createProduct(string email, string password, vscommerce.Product.Product productToCreate) {
            return base.Channel.createProduct(email, password, productToCreate);
        }
        
        public System.Threading.Tasks.Task<bool> createProductAsync(string email, string password, vscommerce.Product.Product productToCreate) {
            return base.Channel.createProductAsync(email, password, productToCreate);
        }
    }
}

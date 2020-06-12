using Manager.database.vscommerceDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Manager.interfaces;
using System.Threading.Tasks;

namespace Manager.classes
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ProductManager" nel codice e nel file di configurazione contemporaneamente.
    public class ProductManager : IProductManager
    {
        private DBManagerClient DB;
        public ProductManager()
        {
            this.DB = new DBManagerClient();
        }
        public List<Product> getProducts(string email,string password)
        {
            Task<List<Product>> taskOperation = Task<List<Product>>.Run(() =>
            {
                try
                {
                    Auth.Authenticate(email, password, this.DB);
                }
                catch (UnAuthorizedExc e)
                {
                    return null;
                }
                try
                {
                    return new List<Product>(DB.getProducts());
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });
            return taskOperation.Result;
            
        }

        public Product getProductById(int productId, string email, string password)
        {
            Task<Product> taskOperation = Task<Product>.Run(() =>
            {
                try
                {
                    Auth.Authenticate(email, password, this.DB);
                }
                catch (UnAuthorizedExc e)
                {
                    return null;
                }
                try
                {
                    return DB.getProductById(productId);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });

            return taskOperation.Result;

        }

        public bool createProduct(string email, string password, Product productToCreate)
        {
            Task<bool> taskOperation = Task<bool>.Run(() =>
            {
                try
                {
                    Auth.Authenticate(email, password, this.DB);
                }
                catch (UnAuthorizedExc e)
                {
                    return false;
                }
                try
                {
                    return DB.createProduct(productToCreate);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }

            });
            return taskOperation.Result;
        }

        public bool updateProduct(string email, string password, Product updatedProduct)
        {
            Task<bool> taskOperation = Task<bool>.Run(() =>
            {
                try
                {
                    Auth.Authenticate(email, password, this.DB);
                }
                catch (UnAuthorizedExc e)
                {
                    return false;
                }
                try
                {
                    return DB.updateProduct(updatedProduct);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }

            });
            return taskOperation.Result;
        }
    }
}

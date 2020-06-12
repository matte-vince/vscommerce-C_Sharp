using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Manager.database.vscommerceDB;
namespace Manager.interfaces
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IProductManager" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IProductManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Product> getProducts(string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Product getProductById(int productId, string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool updateProduct(string email, string password, Product updatedProduct);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool createProduct(string email, string password, Product productToCreate);
    }
}

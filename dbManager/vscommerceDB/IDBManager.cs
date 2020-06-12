
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace dbManager.vscommerceDB
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IDBManager" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IDBManager
    {
        [OperationContract]
        [FaultContract(typeof(DBFault))]
        void DoWork();

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        User getUserByEmail(string Email);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool existUser(string Email);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        User getUserById(int ID);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        List<User> getUsers();

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        Brand getBrandById(int id);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        List<Brand> getBrands();

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        Category getCategoryById(int id);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        List<Category> getCategories();

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        Product getProductById(int id);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        List<Product> getProducts();

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        List<Order> getOrdersByPartner(int ID);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        List<Order> getOrders();

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        Order getOrderById(int ID);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool updateUser(User userUpdated);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool updateBrand(Brand brandUpdated);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool updateCategory(Category categoryUpdated);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool updateProduct(Product productUpdated);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool createOrder(Order newOrder, List<OrderLine> orderLines);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool createBrand(Brand brandToCreate);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool createCategory(Category categoryToCreate);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool createProduct(Product productToCreate);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool createUser(User userToCreate);

        [OperationContract]
        [FaultContract(typeof(DBFault))]
        bool deleteOrder(int ID);
    }
}

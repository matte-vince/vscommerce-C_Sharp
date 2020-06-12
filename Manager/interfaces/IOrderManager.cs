using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Manager.database.vscommerceDB;
namespace Manager.interfaces
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IOrderManager" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IOrderManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Order> getOrdersByPartner(string email, string password, int ID);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Order> getOrders(string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool createOrder(string email, string password, Order newOrder, List<OrderLine> orderLines);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Order getOrderById(string email, string password, int ID);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool deleteOrder(string email, string password, int ID);
    }
}

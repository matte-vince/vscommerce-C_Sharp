using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Manager.database.vscommerceDB;
using Manager.interfaces;

namespace Manager.classes
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "OrderManager" nel codice e nel file di configurazione contemporaneamente.
    public class OrderManager : IOrderManager
    {
        private DBManagerClient DB;
        public OrderManager()
        {
            this.DB = new DBManagerClient();
        }
        public List<Order> getOrdersByPartner(string email, string password, int ID)
        {
            Task<List<Order>> taskOperation = Task<List<Order>>.Run(() =>
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
                    return new List<Order>(DB.getOrdersByPartner(ID));
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });
            return taskOperation.Result;
        }

        public List<Order> getOrders(string email, string password)
        {
            Task<List<Order>> taskOperation = Task<List<Order>>.Run(() =>
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
                    return new List<Order>(DB.getOrders());
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });
            return taskOperation.Result;

        }

        public Order getOrderById(string email, string password, int ID)
        {
            Task<Order> taskOperation = Task<Order>.Run(() =>
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
                    return DB.getOrderById(ID);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });
            return taskOperation.Result;
        }

        public bool createOrder(string email, string password, Order newOrder, List<OrderLine> cartLines)
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
                    OrderLine[] orderLines = new OrderLine[cartLines.Count];
                    Product cartPoduct = new Product();
                    OrderLine line = new OrderLine();
                    for (int i = 0; i < cartLines.Count; i++)
                    {
                        orderLines[i] = cartLines[i];
                    }
                    
                    return DB.createOrder(newOrder, orderLines);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });
            return taskOperation.Result;
        }

        public bool deleteOrder(string email, string password, int ID)
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
                    return DB.deleteOrder(ID);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Manager.database.vscommerceDB;
namespace Manager.interfaces
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IUserManager" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IUserManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool Login(string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        User getUserByEmail(string email);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool existUser(string email);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        User getUserById(string email, string password, int ID);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<User> getUsers(string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool updateUser(User userUpdate);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool createUser(User userUpdate);
    }
}

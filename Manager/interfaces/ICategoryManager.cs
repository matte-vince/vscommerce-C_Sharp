using Manager.database.vscommerceDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Manager.interfaces
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "ICategoryManager" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface ICategoryManager
    {
        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Category> getCategories(string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Category getCategoryById(string email, string password, int ID);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool updateCategory(string email, string password, Category category);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool createCategory(string email, string password, Category category);
    }
}

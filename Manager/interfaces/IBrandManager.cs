using Manager.database.vscommerceDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Manager.interfaces
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IBrandManager" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IBrandManager
    {

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        List<Brand> getBrands(string email, string password);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        Brand getBrandById(string email, string password, int ID);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool updateBrand(string email, string password, Brand brand);

        [OperationContract]
        [FaultContract(typeof(ManagerFault))]
        bool createBrand(string email, string password, Brand brand);
    }
}

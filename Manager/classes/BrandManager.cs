using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Manager.interfaces;
using Manager.database.vscommerceDB;
using System.Threading.Tasks;

namespace Manager.classes
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "BrandManager" nel codice e nel file di configurazione contemporaneamente.
    public class BrandManager : IBrandManager
    {
        private DBManagerClient DB;
        public BrandManager()
        {
            this.DB = new DBManagerClient();
        }
        public List<Brand> getBrands(string email, string password)
        {
            Task<List<Brand>> taskOperation = Task<List<Brand>>.Run(() =>
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
                    return new List<Brand>(DB.getBrands());
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });

            return taskOperation.Result;
        }

        public Brand getBrandById(string email, string password, int ID)
        {
            Task<Brand> taskOperation = Task<Brand>.Run(() =>
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
                    return DB.getBrandById(ID);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });

            return taskOperation.Result;

        }

        public bool updateBrand(string email, string password, Brand brandToUpdate)
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
                    return DB.updateBrand(brandToUpdate);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }

            });
            return taskOperation.Result;
        }

        public bool createBrand(string email, string password, Brand brandToCreate)
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
                    return DB.createBrand(brandToCreate);
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

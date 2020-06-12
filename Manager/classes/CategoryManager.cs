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
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "CategoryManager" nel codice e nel file di configurazione contemporaneamente.
    public class CategoryManager : ICategoryManager
    {
        private DBManagerClient DB;
        public CategoryManager()
        {
            this.DB = new DBManagerClient();
        }
        public List<Category> getCategories(string email, string password)
        {
            Task<List<Category>> taskOperation = Task<List<Category>>.Run(() =>
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
                    return new List<Category>(DB.getCategories());
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });

            return taskOperation.Result;
        }

        public Category getCategoryById(string email, string password, int ID)
        {
            Task<Category> taskOperation = Task<Category>.Run(() =>
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
                    return DB.getCategoryById(ID);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });

            return taskOperation.Result;

        }

        public bool updateCategory(string email, string password, Category categoryToUpdate)
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
                    return DB.updateCategory(categoryToUpdate);
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }

            });
            return taskOperation.Result;
        }

        public bool createCategory(string email, string password, Category categoryToCreate)
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
                    return DB.createCategory(categoryToCreate);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Manager.classes;
using Manager.database.vscommerceDB;
using Manager.interfaces;
using System.Threading.Tasks;
namespace Manager.classes
{

    public class UserManager : IUserManager
    {
        private DBManagerClient DB;
        public UserManager()
        {
            this.DB = new DBManagerClient();
        }

        public bool Login(string email, string password)
        {
            Task<bool> taskOperation = Task<bool>.Run(() =>
            {
                return Auth.Authenticate(email, password, this.DB);
            });
            return taskOperation.Result;
        }
        public User getUserByEmail(string email)
        {
            Task<User> taskOperation = Task<User>.Run(() =>
            {
                return DB.getUserByEmail(email);
            });
            return taskOperation.Result;
        }

        public bool existUser(string email)
        {
            Task<bool> taskOperation = Task<bool>.Run(() =>
            {
                return DB.existUser(email);
            });
            return taskOperation.Result;
        }

        public bool updateUser(User userUpdated) 
        {
            Task<bool> taskOperation = Task<bool>.Run(() =>
            {
                return DB.updateUser(userUpdated);
            });
            return taskOperation.Result;
        }

        public bool createUser(User userToCreate)
        {
            Task<bool> taskOperation = Task<bool>.Run(() =>
            {
                return DB.createUser(userToCreate);
            });
            return taskOperation.Result;
        }

        public List<User> getUsers(string email, string password)
        {
            Task<List<User>> taskOperation = Task<List<User>>.Run(() =>
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
                    return new List<User> (DB.getUsers());
                }
                catch (FaultException<DBFault> df)
                {
                    throw new FaultException<ManagerFault>(new ManagerFault(df.ToString()));
                }
            });

            return taskOperation.Result;
        }

        public User getUserById(string email, string password, int ID)
        {
            Task<User> taskOperation = Task<User>.Run(() =>
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
                    return DB.getUserById(ID);
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

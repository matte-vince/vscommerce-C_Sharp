using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.database.vscommerceDB;
namespace Manager
{
    class Auth
    {

        public static bool Authenticate(string email, string password, DBManagerClient DB)
        {
            try
            {
                User userToAuthenticate = DB.getUserByEmail(email);
                if (userToAuthenticate == null)
                    return false;
                if (userToAuthenticate.password != password)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB
{
    class Program
    {

            public static void Main()
            {
                Console.WriteLine("Wait connection");
                try
                {
                    ServiceHost svcHost = new ServiceHost(typeof(DBManager));
                    svcHost.Open();
                    Console.WriteLine("\nServer is running!");
                    Console.ReadLine();
                    svcHost.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ops, error:", e.ToString());
                }
                //Console.WriteLine("Delta is now stopped. Press RETURN to kill me. ");
                //Console.ReadLine();
            }
       
    }
}

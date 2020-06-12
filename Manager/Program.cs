using Manager.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Wait connection");
            try
            {
                ServiceHost serviceUser = new ServiceHost(typeof(UserManager));
                ServiceHost serviceProduct = new ServiceHost(typeof(ProductManager));
                ServiceHost serviceOrder = new ServiceHost(typeof(OrderManager));
                ServiceHost serviceBrand = new ServiceHost(typeof(BrandManager));
                ServiceHost serviceCategory = new ServiceHost(typeof(CategoryManager));
                serviceUser.Open();
                serviceProduct.Open();
                serviceOrder.Open();
                serviceBrand.Open();
                serviceCategory.Open();
                Console.WriteLine("\nServer is running!");
                Console.ReadLine();
                serviceUser.Close();
                serviceProduct.Close();
                serviceProduct.Close();
                serviceBrand.Close();
                serviceCategory.Close();
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

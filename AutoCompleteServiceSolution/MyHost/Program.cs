using ServiceProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BrandService)))
            {
                host.Open();
                Console.WriteLine("Application is running");
                Console.ReadLine();
            }
        }
    }
}

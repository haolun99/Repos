using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HostConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // correct one
            ServiceHost myhost = new ServiceHost(typeof(WCF_Nov.MathService));
            myhost.Open();
            //Console.WriteLine(typeof(WCF_Nov.IMathService).ToString());
            Console.ReadKey();
        }  
    }
}

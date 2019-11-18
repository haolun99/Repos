using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    // WCF

    class Program
    {
        static void Main(string[] args)
        {
            MyServiceReference.MathServiceClient myServiceClient = new MyServiceReference.MathServiceClient();
            Console.WriteLine(myServiceClient.Sum(2,3).ToString());
            Console.WriteLine(myServiceClient.Divide(21, 3).ToString());
            Console.ReadKey();
        }
    }
}

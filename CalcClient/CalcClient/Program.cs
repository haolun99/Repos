using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcClient.CalcServiceReference;

namespace CalcClient
{
    // Web servicve
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorSoapClient client = new CalculatorSoapClient();

            int result = client.Sum(3, 7);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}

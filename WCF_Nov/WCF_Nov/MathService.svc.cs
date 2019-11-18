using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Nov

    // WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MathService.svc or MathService.svc.cs at the Solution Explorer and start debugging.
    public class MathService : IMathService
    {
 

        public void DoWork()
        {
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        /*
        public List<Customers> GetCustomers()
        {
            List<Customer> myList = new List<Customer>();
            Customer c = new Customer();
            Customer cl = new Customer();
            c.age = 30;
            c.name = "eee";
            myList.add(c);
            c1.age = 30;
            c1.name = "eee";
            myList.add(c2);

            return myList;
        }
        */

    }
}

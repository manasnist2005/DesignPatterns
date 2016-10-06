using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer(); // order object not loaded
            Console.WriteLine(cust.CustomerName);
            foreach (Order o1 in cust.Orders) // Load order object only at this moment
            {
                Console.WriteLine(o1.OrderNumber);
            }
            Console.ReadLine();
        }
    }
}

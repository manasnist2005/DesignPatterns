using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiddleLayer;

namespace FactoryCustomer
{
    public static class Factory //** Design Pattren: Simple factory pattern
    {
        private static Dictionary<string, CustomerBase> cust = new Dictionary<string, CustomerBase>();
        //!!This construtor is loaded every time. We need to fix this and it should be loaded on demand ::solution Lazy loading
        /*
        static Factory()
        {
            cust.Add("Customer", new Customer());
            cust.Add("Lead", new Lead());
        }
        */
        /// <summary>
        /// Returns the type of class as per input
        /// </summary>
        /// <param name="custType"></param>
        /// <returns></returns>
        public static CustomerBase Create(string custType)
        {
            //!!!still the if condition is here in the factory class and hence the polymorphism is not exploited properly
            /*if (custType == "Customer")
            {
                return new Customer();
            }
            else
            {
                return new Lead();
            }*/

            // If in future if any other type is added in the class then this is the only place in the factory we have to chanege
            if(cust.Count == 0) //** Design Pattren: Lazy loading 
            {
                cust.Add("Customer", new Customer());
                cust.Add("Lead", new Lead());
            }

            // To avoid if condition use dictionary and constructor.             
            return cust[custType]; //**Design Pattren: RIP - Replace if with polymorphism
        }
    }
}

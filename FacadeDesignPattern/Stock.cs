using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class Stock
    {
        //Class is declared as internal. So cannot be instanciated outside library
        public void IsAvailabe()
        {
            //Write the business logic over here.
            Console.WriteLine("The item is available");
        }
    }
}

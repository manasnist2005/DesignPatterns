using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    //Class is declared as internal. So cannot be instanciated outside library
    internal class ItemCost
    {
        public void GetItemCost()
        {
            //Write the business logic here to fetch the item cost
            Console.WriteLine("The cost of the item is 60 rupees");
        }
    }
}

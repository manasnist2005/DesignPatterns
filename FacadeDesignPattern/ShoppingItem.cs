using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class ShoppingItem
    {
        public void GetItemDetails()
        {
            Console.WriteLine("Fetching the item details");

            // These classes can be instciated in this library only
            Console.WriteLine("**** Calling function of Stock class ****");
            Stock st = new Stock();
            st.IsAvailabe();
            Console.WriteLine("**** Calling function of ItemCost class ****");
            ItemCost icst = new ItemCost();
            icst.GetItemCost();


        }
    }
}

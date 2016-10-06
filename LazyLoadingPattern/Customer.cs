using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingPattern
{
    public  class Customer
    {
        private string _customerName;
        /*
         * Minimizes start up time of the application.
         * Application consumes less memory because of on-demand loading.
         * Unnecessary database SQL execution is avoided.
         * *********Disadvantage***********
         * The only one disadvantage is that the code becomes complicated. 
         * As we need to do checks if the loading is needed or not, there is a slight decrease in performance.
         * 
         * Implement to restrict the load of a large number of objects at the time of class instantiation
         */
        private Lazy<List<Order>> _orders = null;
       

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public List<Order> Orders
        {
            //get { return _orders; }
            //For on demand loading
            get
            {                                   
                return _orders.Value; // Provides the List of order in inside the lazy object
            }
        }

        //Before lazy loading
        /*
        public Customer()
        {
            _CustomerName = "Manas";
            _Orders = LoadOrders(); // Loads the order object even though //not needed
        }
        */

        //After lazy loading
        public Customer()
        {
           _customerName = "Manas";
            _orders = new Lazy<List<Order>>(() => LoadOrders());        
        }

        private List<Order> LoadOrders()
        {
            List<Order> temp = new List<Order>();
            Order o = new Order();
            o.OrderNumber = "ord001";
            temp.Add(o);
            o = new Order();
            o.OrderNumber = "ord002";
            temp.Add(o);
            return temp;
        }
    }

    public class Order
    {
        public string OrderNumber { get; set; }
    }

}

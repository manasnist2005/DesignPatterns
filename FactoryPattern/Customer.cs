using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; } 
        public virtual void Validate()
        {           
        }
    }

    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if (string.IsNullOrEmpty(CustomerName))
            {
                throw new Exception("Customer name is required"); 
            }
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                throw new Exception("Phone Number is required");
            }
            if (BillAmount <= 0)
            {
                throw new Exception("BillAmount is required");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception("Enter correct bill date");
            }
            if (string.IsNullOrEmpty(Address))
            {
                throw new Exception("Address is required");
            }
        }
    }

    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (string.IsNullOrEmpty(CustomerName))
            {
                throw new Exception("Customer name is required");
            }
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                throw new Exception("Phone Number is required");
            }            
        }
    }
}

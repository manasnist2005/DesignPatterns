using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleLayer;
using FactoryCustomer;

namespace WinFormCustomer
{
    public partial class Form1 : Form
    {
        CustomerBase custbase;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                FillData();
                custbase.Validate();
                MessageBox.Show("Person is validated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private CustomerBase FillData()
        {
            custbase.Address = txtAddress.Text;
            if (!string.IsNullOrEmpty(txtBillAmt.Text))
                custbase.BillAmount = Convert.ToDecimal(txtBillAmt.Text);
            else
                custbase.BillAmount = 0;
            custbase.BillDate = Convert.ToDateTime(dtBillDate.Text);
            custbase.CustomerName = txtCustName.Text;
            custbase.PhoneNumber = txtPhNumber.Text;
            return custbase;
        }

        private void ddltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            custbase = Factory.Create(ddltype.SelectedItem.ToString()); // Factory creates the object as per requirement
            //if (ddltype.SelectedItem.ToString() == "Customer")
            //{
            //    custbase = new Customer();                                     
            //}
            //else                   
            //{
            //    custbase = new Lead();                    
            //}
        }
    }
}

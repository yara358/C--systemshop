using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CustomersUC : UserControl
    {
        DBSQLCustomer customerSQL;
        public CustomersUC()
        {
            InitializeComponent();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            int id; //To check if the new id does not exists
            if (int.TryParse(CustomerID.Text, out id) == true) //If the id doesn't exists, then it'll be added
                customer.ID = int.Parse(CustomerID.Text);
            else
            {
                MessageBox.Show("ID Already exists!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }

            customer.Name = CustomerName.Text;
            customer.phone = CustomerPhone.Text;
            customer.City = CustomerCity.Text;
            try
            {
                customerSQL.InsertCustomer(customer);
                MessageBox.Show("Customer has been added successfuly!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void CustomersUC_Load(object sender, EventArgs e)
        {
            
            string dbPath = Application.StartupPath + @"\..\..\ProjectDB.accdb";
            customerSQL = new DBSQLCustomer(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            //Array to add the customers to database
            Customer[] customerArr;
            customerArr = customerSQL.GetCustomerId();
            for (int i = 0; i < customerArr.Length; i++)
            {
                txtbCustomerID.Items.Add(customerArr[i].ID);
                txtbCustomerIdDel.Items.Add(customerArr[i].ID);
            }
        }
        

        //Editing customer that already exists
        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ID = int.Parse(txtbCustomerID.Text);
            customer.Name = EditCustomerName.Text;
            customer.phone = EditCustomerPhone.Text;
            customer.City = EditCustomerCity.Text;

            try
            {
                customerSQL.UpdateCustomer(customer);
                MessageBox.Show("Customer has been updated successfully", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Removing customer from DB
        private void DeleteCustomerBTN_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ID = int.Parse(txtbCustomerIdDel.Text);
            try
            {

                customerSQL.DeleteCustomer(customer.ID); //Deletes customer from DBSQLCustomer
                MessageBox.Show("Customer has been successfully removed", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbCustomerIdDel.Items.Remove(customer.ID);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCustomerIddel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustomerCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void EditCustomerCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void EditCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


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
    public partial class OrderUC : UserControl
    {
        DBSQLOrders orderSQL;
        DBSQLProducts productSQL;
        DBSQLCustomer customerSQL;
        public OrderUC()
        {
            InitializeComponent();
        }

        private void OrderUC_Load(object sender, EventArgs e)
        {
            //Directory of Microsoft Access file
            string dbPath = Application.StartupPath + @"\..\..\ProjectDB.accdb";
            orderSQL = new DBSQLOrders(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            productSQL = new DBSQLProducts(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            customerSQL = new DBSQLCustomer(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
           
            //Customer & Products array to get data from database
            Customer[] customerArr;
            Products[] proudctArr;
            customerArr = customerSQL.GetCustomerId();
            proudctArr = productSQL.GetProductName();
            for (int i = 0; i < customerArr.Length; i++)
                cmbCustomerID.Items.Add(customerArr[i].ID);
            for (int i = 0; i < proudctArr.Length; i++)
                cmbProductName.Items.Add(proudctArr[i].Name);
        }

        private void MakeOrderBTN_Click(object sender, EventArgs e)//Make order function
        {
            double price;
            if ((int)ProductAmount.Value > int.Parse(AvailableAmount.Text))//If the amount is bigger than the product quantity in stock
            {
                MessageBox.Show("Sorry, The Quantity you entered isn't available in stock!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            Products product = new Products();
            product.Name = cmbProductName.Text;
            Products[] ProductArr;
            ProductArr = productSQL.GetProductData(product);

            Customer customer = new Customer();
            customer.ID = int.Parse(cmbCustomerID.Text);
            price = productSQL.getProductprice(ProductArr[0].ID);
            price *= (int)ProductAmount.Value; //Calculate total price
            try
            {
                orderSQL.MakeOrder(customer.ID, CustomerName.Text, ProductArr[0], (int)ProductAmount.Value, price);
                MessageBox.Show("Thank you, Your order has been placed!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int NewAmount = int.Parse(AvailableAmount.Text) - (int)ProductAmount.Value;
            ProductArr[0].Amount = NewAmount;

            
            try
            {
                //Update product amount
                productSQL.UpdateProduct(ProductArr[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Updates quantity immediately
            Products[] arrNames, arrAmount;
            arrNames = productSQL.GetProductName();
            arrAmount = productSQL.GetProductAmount(cmbProductName.Text);
            AvailableAmount.Text = arrAmount[0].Amount.ToString();
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)//Select id, and it shows you the details about specific id
        {
            Customer[] arrNames, arrID;
            arrNames = customerSQL.GetCustomerName();
            arrID = customerSQL.GetCustomerId();
            for (int i = 0; i < arrID.Length; i++)
                if (cmbCustomerID.Text == arrID[i].ID.ToString())
                {
                    CustomerName.Text = arrNames[i].Name;

                    CustomerName.Visible = true;
                }
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)//Update product amount in database after purchase
        {
            Products[] arrNames, arrAmount;
            arrNames = productSQL.GetProductName();
            arrAmount = productSQL.GetProductAmount(cmbProductName.Text);
            AvailableAmount.Text = arrAmount[0].Amount.ToString();
            AvailableAmount.Visible = true;
        }

        private void ProductAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}

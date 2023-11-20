
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
    public partial class SearchUC : UserControl
    {
        DBSQLSearch searchSQL;
        DBSQLCustomer customerSQL;
        DBSQLSupplier supplierSQL;
        public SearchUC()
        {
            InitializeComponent();
        }

        private void SearchUC_Load(object sender, EventArgs e)
        {
            //Directory of Microsoft Access file
            string dbPath = Application.StartupPath + @"\..\..\ProjectDB.accdb";
            searchSQL = new DBSQLSearch(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            supplierSQL = new DBSQLSupplier(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            customerSQL = new DBSQLCustomer(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            //Customer & supplier array to get data from database
            Supplier[] supplierArr;
            Customer[] customerArr;
            supplierArr = supplierSQL.GetSupplierId();
            customerArr = customerSQL.GetCustomerId();
            for (int i = 0; i < supplierArr.Length; i++)
                cmbSupplierID.Items.Add(supplierArr[i].ID);
            for (int i = 0; i < customerArr.Length; i++)
                cmbCustomerID.Items.Add(customerArr[i].ID);
        }

        private void SearchProductBTN_Click(object sender, EventArgs e)//After clicking on "Search product" Button, A list will show up 
        {
            int SupplierID = int.Parse(cmbSupplierID.Text);
            AccessGV.DataSource = searchSQL.SearchProductsBySupplier(SupplierID);
            AccessGV.Visible = true;
        }

        private void SearchListBTN_Click(object sender, EventArgs e)//After clicking on "Search customer" Button, A list will show up 
        {
            int CustomerID = int.Parse(cmbCustomerID.Text);
            AccessGV.DataSource = searchSQL.GetOrdersOfCustomer(CustomerID);
            AccessGV.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccessGV.Visible = false;
            supplierPanel.Visible = true;
            customerPanel.Visible = false;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccessGV.Visible = false;
            customerPanel.Visible = true;
            supplierPanel.Visible = false;
        }
    }
}

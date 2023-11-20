
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
    public partial class ProductsUC : UserControl
    {
        DBSQLProducts productSQL;
        DBSQLSupplier supplierSQL;

        public ProductsUC()
        {
            InitializeComponent();
        }

        private void ProductsUC_Load(object sender, EventArgs e)
        {
            //Directory of Microsoft Access file
    
            string dbPath = Application.StartupPath + @"\..\..\ProjectDB.accdb";
            productSQL = new DBSQLProducts(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            supplierSQL = new DBSQLSupplier(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            //supplier & Products array to get data from database
            Products[] proudctArr;
            Supplier[] supplierArr;
            proudctArr = productSQL.GetProductId();
            supplierArr = supplierSQL.GetSupplierId();
            for (int i = 0; i < proudctArr.Length; i++)
                cmbProductIddel.Items.Add(proudctArr[i].ID);
            for (int i = 0; i < proudctArr.Length; i++)
                cmbProductIdedit.Items.Add(proudctArr[i].ID);
            for (int i = 0; i < supplierArr.Length; i++)
            {
                cmbSupplierID.Items.Add(supplierArr[i].ID);
                cmbSupplierIDedit.Items.Add(supplierArr[i].ID);
            }
        }

        private void AddProductBTN_Click(object sender, EventArgs e)//Adding new product to database
        {
            Products product = new Products();
            int id;
            if (int.TryParse(ProductID.Text, out id) == true)
                product.ID = int.Parse(ProductID.Text);
            else
            {
                MessageBox.Show("Incorrect Input", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            product.Name = ProductName.Text;
            product.Amount = (int)ProductAmount.Value;
            product.Description = ProductDesc.Text;
            double price = (double)ProductPrice.Value;
            int SupplierID = int.Parse(cmbSupplierID.Text);
            try
            {
                productSQL.InsertProduct(product);
                productSQL.InsertSupplierProduct(product.ID, SupplierID, price);
                MessageBox.Show("Product has been added successfully!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editProductBTN_Click(object sender, EventArgs e)//Editing product and updating it on database
        {
            Products product = new Products();
            product.ID = int.Parse(cmbProductIdedit.Text);
            product.Name = ProductNewName.Text;
            product.Amount = (int)ProductAmountedit.Value;
            product.Description = ProductDescedit.Text;

            try
            {
                productSQL.UpdateProduct(product);
                productSQL.updateProductSupplier(int.Parse(cmbSupplierIDedit.Text), product.ID, (int)ProductPriceedit.Value);
                MessageBox.Show("Product has been updated successfully!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProductBTN_Click(object sender, EventArgs e)//Deletes the product from database
        {
            Products product = new Products();
            product.ID = int.Parse(cmbProductIddel.Text);
            try
            {
                productSQL.DeleteProduct(product.ID);
                MessageBox.Show("Product has been removed!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbProductIddel.Items.Remove(product.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void ProductDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductDescedit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}

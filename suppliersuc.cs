
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FinalProject
{
    public partial class SuppliersUC : UserControl
    {
        DBSQLSupplier supplierSQL;
        public SuppliersUC()
        {
            InitializeComponent();
        }

        private void SuppliersUC_Load(object sender, EventArgs e)
        {
            //Directory of Microsoft Access file
            string dbPath = Application.StartupPath + @"\..\..\ProjectDB.accdb";
            supplierSQL = new DBSQLSupplier(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");
            // supplier array to get data from database
            Supplier[] supplierArr;
            supplierArr = supplierSQL.GetSupplierId();
            for (int i = 0; i < supplierArr.Length; i++)
            {
                cmbSupplierID.Items.Add(supplierArr[i].ID);
                cmbSupplierIddel.Items.Add(supplierArr[i].ID);
            }
        }


        private void AddSupplierBTN_Click(object sender, EventArgs e)//Adding new supplier to database
        {

            //Input checker for email address

            Regex mRegxExpression;

            if (SupplierMail.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(SupplierMail.Text.Trim()))

                {

                    MessageBox.Show("E-mail address format is not correct.", "Mona Computers", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    SupplierMail.Focus();
                    return;

                }

            }


            //Checks if the id added and if it doesnt exists
            Supplier supplier = new Supplier();
            int id;
            if (int.TryParse(SupplierID.Text, out id) == true)
                supplier.ID = int.Parse(SupplierID.Text);
            else
            {
                MessageBox.Show("Incorrect Input!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            supplier.Name = SupplierName.Text;
            supplier.Phone = SupplierPhone.Text;
            supplier.Mail = SupplierMail.Text;
            try
            {
                supplierSQL.InsertSupplier(supplier);
                MessageBox.Show("Supplier has been added successfully!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditSupplierBTN_Click(object sender, EventArgs e)////Editing supplier in database
        {
            //Input checker for email address


            Regex mRegxExpression;

            if (EditSupplierMail.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(EditSupplierMail.Text.Trim()))

                {

                    MessageBox.Show("E-mail address format is not correct.", "Mona Computers", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EditSupplierMail.Focus();
                    return;

                }

            }
            Supplier supplier = new Supplier();
            supplier.ID = int.Parse(cmbSupplierID.Text);
            supplier.Name = EditSupplierName.Text;
            supplier.Phone = EditSupplierPhone.Text;
            supplier.Mail = EditSupplierMail.Text;

            try
            {
                supplierSQL.UpdateSupplier(supplier);
                MessageBox.Show("Supplier has been updated successfully!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSupplierBTN_Click(object sender, EventArgs e)//Delete supplier from database
        {
            Supplier supplier = new Supplier();
            supplier.ID = int.Parse(cmbSupplierIddel.Text);
            try
            {
                supplierSQL.DeleteSupplier(supplier.ID);
                MessageBox.Show("Supplier has been removed!", "Mona Computers",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbSupplierIddel.Items.Remove(supplier.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupplierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SupplierMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

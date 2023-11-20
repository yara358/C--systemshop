
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;

namespace FinalProject
{
    public partial class ExportUC : UserControl
    {

        DBSQLPdf pdfSQL;


        int flag = 0; // To know which report to export
        public ExportUC()
        {
            InitializeComponent();
        }

        private void ExportUC_Load(object sender, EventArgs e)
        {
            
            string dbPath = Application.StartupPath + @"\..\..\ProjectDB.accdb";
            pdfSQL = new DBSQLPdf(@"Provider=microsoft.ACE.OLEDB.12.0;dATA Source=" + dbPath + "; Persist Security Info=False;");

        }

 

        private void exportBtn_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1://if flag = 1 it exports the customers into pdf file
                    {
                        PDF Customerpdf = new PDF("Customers");
                        DateTime date = new DateTime();
                        date = DateTime.Now;
                        string title = "Customers Report " + date.ToString();
                        Customerpdf.SetTitle(title);
                        Customer[] customerArr;
                        customerArr = pdfSQL.GetcustomerData();
                        try
                        {
                            Customerpdf.CreateCustomerReport(customerArr);
                            MessageBox.Show("Report has been saved as PDF File");
                        }
                        catch { }


                    }
                    break;
                case 2://if flag = 2 it exports the suppliers into pdf file
                    {
                        PDF SupplierPdf = new PDF("Suppliers");
                        DateTime date = new DateTime();
                        date = DateTime.Now;
                        string title = "Suppliers Report " + date.ToString();
                        SupplierPdf.SetTitle(title);
                        Supplier[] supplierArr;
                        supplierArr = pdfSQL.GetsupplierData();
                        try
                        {
                            SupplierPdf.CreateSupplierReport(supplierArr);
                            MessageBox.Show("Report has been saved as PDF File");
                        }
                        catch { }
                    }
                    break;
                case 3://if flag = 3 it exports the products into pdf file
                    {

                        PDF ProductPdf = new PDF("Products");
                        DateTime date = new DateTime();
                        date = DateTime.Now;
                        string title = "Products Report " + date.ToString();
                        ProductPdf.SetTitle(title);
                        Products[] productArr;
                        productArr = pdfSQL.GetProductData();
                        try
                        {
                            ProductPdf.CreateProductReport(productArr);
                            MessageBox.Show("Report has been saved as PDF File");
                        }
                        catch { }
                    }
                    break;
                default:
                    MessageBox.Show("You need to choose one of the options above!"); break;
            }


        }





        private void exportCustomerBtn_Click(object sender, EventArgs e)
        {
            flag = 1;
            AccessGV.DataSource = pdfSQL.GetcustomerData();
            AccessGV.Visible = true;
        }
        private void exportSupplierBtn_Click(object sender, EventArgs e)
        {
            flag = 2;
            AccessGV.DataSource = pdfSQL.GetsupplierData();
            AccessGV.Visible = true;
        }
        private void productExportBtn_Click(object sender, EventArgs e)
        {
            flag = 3;
            AccessGV.DataSource = pdfSQL.GetProductData();
            AccessGV.Visible = true;
        }


    }
}

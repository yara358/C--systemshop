
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class DBSQLPdf : DBAccess
    {
        public DBSQLPdf(string connectionString)
            : base(connectionString)
        {

        }
        public Products[] GetProductData()
        {
            string Command = "SELECT * FROM Products ";
            DataSet data_set = new DataSet();
            ArrayList ProductArr = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                data_set = GetMultipleQuery(command);
            }
            DataTable data_table = new DataTable();
            try
            {
                data_table = data_set.Tables[0];

            }
            catch { }
            foreach (DataRow tType in data_table.Rows)
            {
                Products product = new Products();
                product.ID = int.Parse(tType[0].ToString());
                product.Name = (tType[1].ToString());
                product.Description = (tType[2].ToString());
                product.Amount = int.Parse(tType[3].ToString());

                ProductArr.Add(product);
            }
            return (Products[])ProductArr.ToArray(typeof(Products));
        }

        //Function to get the suppliers and insert them into order table in pdf
        public Supplier[] GetsupplierData()
        {
            string cmdStr = "SELECT * FROM Suppliers ";
            DataSet data_set = new DataSet();
            ArrayList SuppliersArr = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                data_set = GetMultipleQuery(command);
            }
            DataTable data_table = new DataTable();
            try
            {
                data_table = data_set.Tables[0];

            }
            catch { }
            foreach (DataRow tType in data_table.Rows)
            {
                Supplier supplier = new Supplier();
                supplier.ID = int.Parse(tType[0].ToString());
                supplier.Name = (tType[1].ToString());
                supplier.Mail = (tType[3].ToString());
                supplier.Phone = (tType[2].ToString());

                SuppliersArr.Add(supplier);
            }
            return (Supplier[])SuppliersArr.ToArray(typeof(Supplier));
        }
        //Function to get the customers and insert them into order table in pdf
        
        public Customer[] GetcustomerData()
        {
            string cmdStr = "SELECT * FROM Customers ";
            DataSet data_set = new DataSet();
            ArrayList CustomersArr = new ArrayList();
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                data_set = GetMultipleQuery(command);
            }
            DataTable data_table = new DataTable();
            try
            {
                data_table = data_set.Tables[0];

            }
            catch { }
            foreach (DataRow tType in data_table.Rows)
            {
                Customer customer = new Customer();
                customer.ID = int.Parse(tType[0].ToString());
                customer.Name = (tType[1].ToString());
                customer.City = (tType[2].ToString());
                customer.phone = (tType[3].ToString());

                CustomersArr.Add(customer);
            }
            return (Customer[])CustomersArr.ToArray(typeof(Customer));
        }
    }
}

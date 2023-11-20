
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DBSQLSearch : DBAccess
    {
        public DBSQLSearch(string connectionString)
            : base(connectionString)
        {

        }

        public Products[] SearchProductsBySupplier(int SupplierID)
        {
            string Command = "SELECT * FROM Products where Product_id=ANY(Select Product_id From Supplier_Product where Supplier_id=" + SupplierID + ")";
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
                product.Amount = int.Parse(tType[4].ToString());
                ProductArr.Add(product);
            }
            return (Products[])ProductArr.ToArray(typeof(Products));
        }

        
        //Search order of customer through the customer id
        public Order[] GetOrdersOfCustomer(int CustomerID)
        {
            string Command = "SELECT * FROM Orders WHERE Customer_id=" + CustomerID;
            DataSet data_set = new DataSet();
            ArrayList OrderArr = new ArrayList();
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
                Order order = new Order();
                order.Customerid = int.Parse(tType[0].ToString());
                order.Productid = int.Parse(tType[1].ToString());
                order.customerName = tType[2].ToString();
                order.productName = tType[3].ToString();
                order.price = double.Parse(tType[4].ToString());
                order.Amount = int.Parse(tType[5].ToString());
                OrderArr.Add(order);
            }
            return (Order[])OrderArr.ToArray(typeof(Order));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DBSQLOrders : DBAccess
    {
        public DBSQLOrders(string connectionString)
            : base(connectionString)
        {

        }

        public void MakeOrder(int CustomerID, string CustomerName, Products product, int productAmount, double price)
        {
            string Command = "INSERT INTO [Orders] (Customer_id,Customer_Name,Product_id,Product_Name,Amount,Price) VALUES  (@Customer_id,@Customer_Name,@Product_id,@Product_Name,@Amount,@Price)";
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Customer_id", CustomerID);
                command.Parameters.AddWithValue("@Customer_Name", CustomerName);
                command.Parameters.AddWithValue("@Product_id", product.ID);
                command.Parameters.AddWithValue("@Product_Name", product.Name);
                command.Parameters.AddWithValue("@Amount", productAmount);
                command.Parameters.AddWithValue("@Price", price);
                base.ExecuteSimpleQuery(command);
            }
        }
    }
}

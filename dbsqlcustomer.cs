
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class DBSQLCustomer : DBAccess
    {
        public DBSQLCustomer(string connectionString)
            : base(connectionString)
        {

        }
        public void InsertCustomer(Customer customer)
        {
            string Command = "INSERT INTO [Customers] (Customer_id,Customer_Name,Customer_City,Customer_Phone) VALUES (@Customer_id,@Customer_Name,@Customer_City,@Customer_Phone) ";
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Customer_id", customer.ID);
                command.Parameters.AddWithValue("@Customer_Name", customer.Name);

                command.Parameters.AddWithValue("@Customer_City", customer.City);
                command.Parameters.AddWithValue("@Customer_Phone", customer.phone);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Gets the customers id
        public Customer[] GetCustomerId()
        {
            DataSet data_set = new DataSet();
            ArrayList CustomerArr = new ArrayList();
            string Command = "SELECT Customer_id  FROM Customers";

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
                Customer customer = new Customer();
                customer.ID = int.Parse(tType[0].ToString());
                CustomerArr.Add(customer);
            }
            return (Customer[])CustomerArr.ToArray(typeof(Customer));
        }

        //Gets the customer name
        public Customer[] GetCustomerName()
        {
            DataSet data_set = new DataSet();
            ArrayList CustomerArr = new ArrayList();
            string Command = "SELECT Customer_Name  FROM Customers";

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
                Customer customer = new Customer();
                customer.Name = tType[0].ToString();
                CustomerArr.Add(customer);
            }
            return (Customer[])CustomerArr.ToArray(typeof(Customer));
        }

        //Update customer information
        public void UpdateCustomer(Customer customer)
        {
            string Command = "Update Customers SET Customer_id=@Customer_id,Customer_Name=@Customer_Name,Customer_Phone=@Customer_Phone,Customer_City=@Customer_City WHERE Customer_id=" + customer.ID;
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Customer_id", customer.ID);
                command.Parameters.AddWithValue("@Customer_Name", customer.Name);
                command.Parameters.AddWithValue("@Customer_Phone", customer.phone);
                command.Parameters.AddWithValue("@Customer_City", customer.City);

                base.ExecuteSimpleQuery(command);
            }
        }

        //Delete customer
        public void DeleteCustomer(int ID)
        {
            string Command = "DELETE FROM Customers WHERE Customer_id=" + ID;
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                base.ExecuteSimpleQuery(command);
            }
        }
    }
}
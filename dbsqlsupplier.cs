
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DBSQLSupplier : DBAccess
    {
        public DBSQLSupplier(string connectionString)
            : base(connectionString)
        {

        }

        public void InsertSupplier(Supplier supplier)
        {
            string Command = "INSERT INTO [Suppliers] (Supplier_id,Supplier_Name,Supplier_Phone,Supplier_Mail) VALUES (@Supplier_id,@Supplier_Name,@Supplier_Phone,@Supplier_Mail) ";
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Supplier_id", supplier.ID);
                command.Parameters.AddWithValue("@Supplier_Name", supplier.Name);

                command.Parameters.AddWithValue("@Supplier_Phone", supplier.Phone);
                command.Parameters.AddWithValue("@Supplier_Mail", supplier.Mail);
                base.ExecuteSimpleQuery(command);
            }
        }

        
        //Gets the supplier id
        public Supplier[] GetSupplierId()
        {
            DataSet data_set = new DataSet();
            ArrayList SupplierArr = new ArrayList();
            string Command = "SELECT Supplier_id  FROM Suppliers";

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
                Supplier supplier = new Supplier();
                supplier.ID = int.Parse(tType[0].ToString());
                SupplierArr.Add(supplier);
            }
            return (Supplier[])SupplierArr.ToArray(typeof(Supplier));
        }
        //Gets the supplier name
        public Supplier[] GetSupplierName()
        {
            DataSet data_set = new DataSet();
            ArrayList SupplierArr = new ArrayList();
            string Command = "SELECT Supplier_Name  FROM Suppliers";

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
                Supplier supplier = new Supplier();
                supplier.Name = tType[0].ToString();
                SupplierArr.Add(supplier);
            }
            return (Supplier[])SupplierArr.ToArray(typeof(Supplier));
        }
        //Update product information
        public void UpdateSupplier(Supplier supplier)
        {
            string Command = "Update Suppliers SET Supplier_id=@Supplier_id,Supplier_Name=@Supplier_Name,Supplier_Phone=@Supplier_Phone,Supplier_Mail=@Supplier_Mail WHERE Supplier_id=" + supplier.ID;
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Supplier_id", supplier.ID);
                command.Parameters.AddWithValue("@Supplier_Name", supplier.Name);
                command.Parameters.AddWithValue("@Supplier_Phone", supplier.Phone);
                command.Parameters.AddWithValue("@Supplier_Mail", supplier.Mail);

                base.ExecuteSimpleQuery(command);
            }
        }

        //Delete supplier
        public void DeleteSupplier(int ID)
        {
            string Command = "DELETE FROM Suppliers WHERE Supplier_id=" + ID;
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                base.ExecuteSimpleQuery(command);
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class DBSQLProducts : DBAccess
    {
        public DBSQLProducts(string connectionString)
            : base(connectionString)
        {

        }
        public void InsertProduct(Products product)
        {
            string Command = "INSERT INTO [Products] (Product_id,Product_Name,Product_Description,Product_Amount,Supplier_Product_Amount) VALUES (@Product_id,@Product_Name,@Product_Description,@Product_Amount,@Product_Amount) ";
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Product_id", product.ID);
                command.Parameters.AddWithValue("@Product_Name", product.Name);

                command.Parameters.AddWithValue("@Product_Description", product.Description);
                command.Parameters.AddWithValue("@Product_Amount", product.Amount);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Get the product id
        public Products[] GetProductId()
        {
            DataSet data_set = new DataSet();
            ArrayList ProductArr = new ArrayList();
            string Command = "SELECT Product_id  FROM Products";

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
                ProductArr.Add(product);
            }
            return (Products[])ProductArr.ToArray(typeof(Products));
        }

        //Gets the product quantity
        public Products[] GetProductAmount(string productName)
        {
            DataSet data_set = new DataSet();
            ArrayList ProductArr = new ArrayList();
            string Command = "SELECT Product_Amount  FROM Products WHERE Product_Name=" + "'" + productName + "'";

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
                product.Amount = int.Parse(tType[0].ToString());
                ProductArr.Add(product);
            }
            return (Products[])ProductArr.ToArray(typeof(Products));
        }

        //Gets the product price from supplier_product table
        public double getProductprice(int ID)
        {
            double price = 0;
            DataSet data_set = new DataSet();
            string Command = "SELECT Price FROM Supplier_Product WHERE Product_id =" + ID;

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
                price = double.Parse(tType[0].ToString());
            }
            return price;
        }

        //Gets products name
        public Products[] GetProductName()
        {
            DataSet data_set = new DataSet();
            ArrayList ProductArr = new ArrayList();
            string Command = "SELECT Product_Name  FROM Products";

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
                product.Name = tType[0].ToString();
                ProductArr.Add(product);
            }
            return (Products[])ProductArr.ToArray(typeof(Products));
        }

        
        //Insert value to supplier_product table
        public void InsertSupplierProduct(int ProductID, int SupplierID, double Price)
        {
            string Command = "INSERT INTO [Supplier_Product] (Supplier_id,Product_id,Price) VALUES (@Supplier_id,@Product_id,@Price)";
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Supplier_id", SupplierID);
                command.Parameters.AddWithValue("@Product_id", ProductID);
                command.Parameters.AddWithValue("@Price", Price);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Update product information
        public void UpdateProduct(Products product)
        {
            string Command = "UPDATE Products SET Product_id=@Product_id,Product_Name=@Product_Name,Product_Description=@Product_Description,Product_Amount=@Product_Amount WHERE Product_id=" + product.ID;
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Product_id", product.ID);
                command.Parameters.AddWithValue("@Product_Name", product.Name);
                command.Parameters.AddWithValue("@Product_Description", product.Description);
                command.Parameters.AddWithValue("@Product_Amount", product.Amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        
        //Update product and supplier information 
        public void updateProductSupplier(int SupplierID, int ProductID, int Price)
        {
            string Command = "UPDATE Supplier_Product SET Supplier_id=@Supplier_id,Product_id=@Product_id,Price=@Price";
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                command.Parameters.AddWithValue("@Supplier_id", SupplierID);
                command.Parameters.AddWithValue("@Product_id", ProductID);
                command.Parameters.AddWithValue("@Price", Price);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Delete product
        public void DeleteProduct(int ID)
        {
            string Command = "DELETE FROM Products WHERE Product_id=" + ID;
            using (OleDbCommand command = new OleDbCommand(Command))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //Gets the information of the product
        public Products[] GetProductData(Products ProductName)
        {
            string Command = "SELECT * FROM Products WHERE Product_Name=" + "'" + ProductName.Name + "'";
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



    }
}


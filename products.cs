using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Products
    {

        private int Product_id;
        private string Product_Name;
        private string Product_Description;
        private int Product_Amount;

        public Products()
        {
            Product_id = 0;
            Product_Name = string.Empty;
            Product_Description = string.Empty;
            Product_Amount = 0;
        }

       
        //Getters and setters for product attributes
        public int ID
        {
            get
            {
                return Product_id;
            }
            set
            {
                Product_id = value;
            }
        }
        public string Name
        {
            get
            {
                return Product_Name;
            }
            set
            {
                Product_Name = value;
            }
        }
        public string Description
        {
            get
            {
                return Product_Description;
            }
            set
            {
                Product_Description = value;
            }
        }
        public int Amount
        {
            get
            {
                return Product_Amount;
            }
            set
            {
                Product_Amount = value;
            }
        }
    }
}

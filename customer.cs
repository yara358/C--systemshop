using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Customer
    {

        //Attributes of customer 
        private int Customer_id;
        private string Customer_Name;
        private string Customer_City;
        private string Customer_Phone;

        public Customer()
        {
            Customer_id = 0;
            Customer_Name = string.Empty;
            Customer_City = string.Empty;
            Customer_Phone = string.Empty;

        }
        //Getters & Setters to customer attributes
        public int ID
        {
            get
            {
                return Customer_id;
            }
            set
            {
                Customer_id = value;
            }
        }
        public string Name
        {
            get
            {
                return Customer_Name;
            }
            set
            {
                Customer_Name = value;
            }
        }
        public string City
        {
            get
            {
                return Customer_City;
            }
            set
            {
                Customer_City = value;
            }
        }
        public string phone
        {
            get
            {
                return Customer_Phone;
            }
            set
            {
                Customer_Phone = value;
            }
        }
    }
}


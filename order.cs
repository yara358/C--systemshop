using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Order
    {
    
    private int CustomerID;
    private string CustomerName;
    private int ProductID;
    private string ProductName;
    private int productAmount;
    private double Price;

    public Order()
    {

    }

    public int Customerid
    {
        get
        {
            return CustomerID;

        }
        set
        {
            CustomerID = value;
        }
    }

    public string customerName
    {
        get
        {
            return CustomerName;

        }
        set
        {
            CustomerName = value;
        }
    }

    public int Productid
    {
        set
        {

            ProductID = value;
        }
        get
        {
            return ProductID;
        }
    }

    public string productName
    {
        get
        {
            return ProductName;

        }
        set
        {
            ProductName = value;
        }
    }

    public int Amount
    {
        get
        {
            return productAmount;
        }
        set
        {
            productAmount = value;
        }
    }

    public double price
    {
        get
        {
            return Price;

        }
        set
        {
            Price = value;
        }
    }
}
}

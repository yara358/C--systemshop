using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class Supplier
    {
        
        
            //Attributes of Supplier 
            private int Supplier_id;
            private string Supplier_Name;
            private string Supplier_Phone;
            private string Supplier_Mail;

            public Supplier()
            {
                Supplier_id = 0;
                Supplier_Name = string.Empty;
                Supplier_Phone = string.Empty;
                Supplier_Mail = string.Empty;

            }
        //Getters and setters for supplier attributes
        public int ID
            {
                get
                {
                    return Supplier_id;
                }
                set
                {
                    Supplier_id = value;
                }
            }
            public string Name
            {
                get
                {
                    return Supplier_Name;
                }
                set
                {
                    Supplier_Name = value;
                }
            }
            public string Phone
            {
                get
                {
                    return Supplier_Phone;
                }
                set
                {
                    Supplier_Phone = value;
                }
            }
            public string Mail
            {
                get
                {
                    return Supplier_Mail;
                }
                set
                {
                    Supplier_Mail = value;
                }
            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using MyFont = iTextSharp.text.Font;
namespace FinalProject
{
    class PDF
    {
        private Document doc;
      
        public PDF(String name)
        {
            doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Mona Report " + name + "" + ".pdf", FileMode.Create));
            doc.Open();

        }

        //Report title
        public void SetTitle(string Title)
        {
            Font myFont = new Font(Font.FontFamily.COURIER, 11, Font.BOLD);
            myFont.Color = BaseColor.RED;

            doc.Add(new Paragraph(Title, myFont));
            doc.Add(new Paragraph("\n\n", myFont));
        }

        //Exporting the product report
        public void CreateProductReport(Products[] product)
        {
            
            Font myFont = new Font(Font.FontFamily.COURIER, 11, Font.NORMAL);
            PdfPTable table = new PdfPTable(4);

            table.AddCell("Product ID");
            table.AddCell("Product Name");
            table.AddCell("Description");
            table.AddCell("Quantity");

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell cell = new PdfPCell(new Phrase("Products Report"));
            cell.HorizontalAlignment = 1;

            for (int i = 0; i < product.Length; i++)
            {
                cell.Phrase = new Phrase(product[i].ID.ToString(), myFont);
                table.AddCell(cell);
                cell.Phrase = new Phrase(product[i].Name, myFont);
                table.AddCell(cell);
                cell.Phrase = new Phrase(product[i].Description, myFont);
                table.AddCell(cell);
                cell.Phrase = new Phrase(product[i].Amount.ToString(), myFont);
                table.AddCell(cell);
            }
            doc.Add(table);
            doc.Close();
        }

        //Exporting the customer report
        public void CreateCustomerReport(Customer[] customer)
        {
            Font myFont = new Font(Font.FontFamily.COURIER, 11, Font.NORMAL);
            PdfPTable mytable = new PdfPTable(4);

            mytable.AddCell("Customer ID");
            mytable.AddCell("Customer Name");
            mytable.AddCell("City");
            mytable.AddCell("Phone");

            mytable.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell myCell = new PdfPCell();

            for (int i = 0; i < customer.Length; i++)
            {
                myCell.Phrase = new Phrase(customer[i].ID.ToString(), myFont);
                mytable.AddCell(myCell);
                myCell.Phrase = new Phrase(customer[i].Name, myFont);
                mytable.AddCell(myCell);
                myCell.Phrase = new Phrase(customer[i].City, myFont);
                mytable.AddCell(myCell);
                myCell.Phrase = new Phrase(customer[i].phone.ToString(), myFont);
                mytable.AddCell(myCell);
            }
            doc.Add(mytable);
            doc.Close();
        }

        //Exporting the supplier report
        public void CreateSupplierReport(Supplier[] supplier)
        {
            Font myFont = new Font(Font.FontFamily.COURIER, 11, Font.NORMAL);
            PdfPTable mytable = new PdfPTable(4);

            mytable.AddCell("Supplier ID");
            mytable.AddCell("Supplier Name");
            mytable.AddCell("Phone");
            mytable.AddCell("Email Address");

            mytable.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell myCell = new PdfPCell();

            for (int i = 0; i < supplier.Length; i++)
            {
                myCell.Phrase = new Phrase(supplier[i].ID.ToString(), myFont);
                mytable.AddCell(myCell);
                myCell.Phrase = new Phrase(supplier[i].Name, myFont);
                mytable.AddCell(myCell);
                myCell.Phrase = new Phrase(supplier[i].Phone, myFont);
                mytable.AddCell(myCell);
                myCell.Phrase = new Phrase(supplier[i].Mail.ToString(), myFont);
                mytable.AddCell(myCell);
            }
            doc.Add(mytable);
            doc.Close();
        }


        //Close
        public void CloseReport()
        {
            if (doc.IsOpen() == true)
                doc.Close();
        }
    }
}
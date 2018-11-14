using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP2614Assign03
{
    /// <summary>  
    ///  FileReader class
    /// </summary>  
    class FileReader
    {
        const char SECTION_DELIMITER = '|';
        const char ELEMENTS_DELIMITER = ':';
        const string PST_TAXABLE_TRUE = "Y";

        /// <summary>  
        ///  Reads text file
        /// </summary>  
        public static List<Invoice> ReadFile(string path)
        {
            // Allows you to read from a file
            StreamReader streamReader = null;
            List<Invoice> invoices = new List<Invoice>();
            string lineData;

            if(!File.Exists(path))
            {
                Console.WriteLine("\nFile not found.\n");
            }
            else
            {
                try
                {
                    // Attempts to open file. Will thrown an exception if there is an error.
                    streamReader = new StreamReader(path);

                    while (streamReader.Peek() > 0)
                    {
                        lineData = streamReader.ReadLine();
                        Invoice invoice = NewInvoice(lineData);
                        invoices.Add(invoice);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
                finally
                {
                    // Tests for null
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }
            }
            return invoices;
        }

        /// <summary>  
        ///  Parses an invoice from reading the text file
        /// </summary>  
        public static Invoice NewInvoice (string lineData)
        {
            string invoiceNumber;
            DateTime invoiceDate;
            string invoiceDateStr;
            int discountPercentage;
            string discountPercentageStr;
            int discountPeriodDays;
            string discountPeriodDaysStr;
            List<Item> items;

            string[] invoiceTokens = lineData.Split(SECTION_DELIMITER);
            string[] headerTokens = invoiceTokens[0].Split(ELEMENTS_DELIMITER);

            invoiceNumber = headerTokens[0];

            invoiceDateStr = headerTokens[1];
            invoiceDate = DateTime.Parse(invoiceDateStr);

            discountPercentageStr = headerTokens[2].Substring(0, 1);
            discountPercentage = int.Parse(discountPercentageStr);

            discountPeriodDaysStr = headerTokens[2].Substring(1, 2);
            discountPeriodDays = int.Parse(discountPeriodDaysStr);

            items = new List<Item>();

            // Parses individual items from reading the text file and adds to invoice
            int i = 1;
            while (i <= invoiceTokens.Length - 1)
            {
                int quantity;
                string sku;
                string description;
                decimal price;
                bool taxable;

                string[] itemTokens = invoiceTokens[i].Split(ELEMENTS_DELIMITER);

                quantity = int.Parse(itemTokens[0]);
                sku = itemTokens[1];
                description = itemTokens[2];
                price = decimal.Parse(itemTokens[3]);
                taxable = false;

                if (itemTokens[4] == PST_TAXABLE_TRUE)
                {
                    taxable = true;
                }

                Item item = new Item(quantity, sku, description, price, taxable);
                items.Add(item);

                i++;
            }

            Invoice invoice = new Invoice(invoiceNumber, invoiceDate, discountPercentage, discountPeriodDays, items);

            return invoice;
        }
    }
}

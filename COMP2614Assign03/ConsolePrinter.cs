using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>  
    ///  ConsolePrinter class  
    /// </summary>  
    class ConsolePrinter
    {
        /// <summary>  
        ///  Prints the invoice to console
        /// </summary>  
        public static void PrintInvoice(List<Invoice> invoices)
        {
            bool taxable = false;

            const int LINE_WIDTH = 64;
            const string PST_TAXABLE_TRUE = "Y";
            const string PST_TAXABLE_FALSE = "N";

            Console.WriteLine($"Invoice Listing");
            Console.WriteLine(new string('-', LINE_WIDTH));
            Console.WriteLine();

            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine($"{"Invoice Number: "} {invoice.InvoiceNumber, -7}");
                Console.WriteLine($"{"Invoice Date: "} {invoice.InvoiceDate,14:MMM dd, yyyy}");
                Console.WriteLine($"{"Invoice Number: "} {invoice.DiscountDate,12:MMM dd, yyyy}");
                Console.WriteLine($"Terms: {invoice.DiscountPercentage,14:N2}% {invoice.DiscountPeriodDays} {(invoice.DiscountPeriodDays == 1 ? "day" : "days")} ADI");
                Console.WriteLine(new string('-', LINE_WIDTH));
                Console.WriteLine("{0,3} {1,3} {2,20} {3,20} {4,1} {5,10}", "Qty", "SKU", "Description", "Price", "PST", "Ext");
                Console.WriteLine(new string('-', LINE_WIDTH));

                foreach (Item item in invoice.Items)
                {
                    // Keeps track of taxable
                    string pst = PST_TAXABLE_FALSE;

                    if (item.Taxable)
                    {
                        pst = PST_TAXABLE_TRUE;
                        taxable = true;
                    }

                    Console.WriteLine("{0,3} {1,3} {2,22} {3,14} {4,2} {5,11}", item.Quantity, item.Sku, item.Description, item.Price, pst, item.ExtendedPrice);
                }

                    Console.WriteLine(new string('-', LINE_WIDTH));
                    Console.WriteLine($"{"Subtotal:",26} {invoice.Subtotal,37:N2}");
                    Console.WriteLine($"{"GST:",21} {invoice.Gst,42:N2}");

                    if(taxable)
                    {
                        Console.WriteLine($"{"PST:",21} {invoice.Pst,42:N2}");
                    }

                    Console.WriteLine(new string('-', LINE_WIDTH));
                    Console.WriteLine($"{"Total:",23} {invoice.Total,40:N2}\n");
                    Console.WriteLine($"{"Discount:",26} {invoice.Discount,37:N2}\n\n");

                }
            }
        }
    }


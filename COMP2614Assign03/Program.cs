// COMP2614 Assign03
// Reads invoice from text file and displays in required formatted in console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>  
    ///  Point of entry for the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            // Sets console title
            Console.Title = "COMP2614 - Assignment 3 - A00000000";

            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                Console.WriteLine("\nFile not found.\n");
                return;
            }

            List<Invoice> invoices = FileReader.ReadFile(path);

            ConsolePrinter.PrintInvoice(invoices);
        }
    }
}

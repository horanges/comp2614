// COMP2614 Assign04
// Queries a table on a remote SQL Server, processes and displays the data in a formatted manner

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    class Program
    {
        static void Main(string[] args)
        {
            string provinceSelection;
            string provinceFilter;
            int provinceSelectionInt;

            Console.Title = "COMP2614 Assign04 A00000000";

            try
            {
                List<string> provinces = CustomerRepository.GetAllProvinces();

                ConsolePrinter.PrintProvinces(provinces);

                provinceSelection = Console.ReadLine();
                provinceSelectionInt = int.Parse(provinceSelection);
                provinceFilter = provinces[provinceSelectionInt - 1];

                Console.WriteLine($"Customer listing for {provinceFilter}\n");

                List<Customer> customers = CustomerRepository.GetCustomerByProvince(provinceFilter);

                ConsolePrinter.PrintCustomers(customers);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }
    }
}

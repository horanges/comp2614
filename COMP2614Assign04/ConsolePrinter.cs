using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    class ConsolePrinter
    {

        public static void PrintProvinces(List<string> provinces)
        {
            int counter = 1;

            Console.WriteLine("Select province filter: ");

            foreach (string province in provinces)
            {
                Console.WriteLine($"{counter,10}: {province,-3}");
                counter++;
            }
        }

        public static void PrintCustomers(List<Customer> customers)
        {
            int lineWidth = 72;
            string postalCode = null;
            string creditHold = null;

            Console.WriteLine($"{"CompanyName",-36} {"City",-16} {"Prov",-4} {"Postal",-8} {"Hold",-3}");
            Console.WriteLine(new string('-', lineWidth));

            foreach (Customer customer in customers)
            {
                if (customer.PostalCode == null)
                {
                    postalCode = "";
                }
                else
                {
                    postalCode = customer.PostalCode;
                }

                if (customer.CreditHold == null)
                {
                    creditHold = "";
                }
                else if (customer.CreditHold == true)
                {
                    creditHold = "Y";
                }
                else
                {
                    creditHold = "N";
                }

                Console.WriteLine($"{customer.CompanyName,-36} {customer.City,-16} {customer.Province,-4} {postalCode,-8} {creditHold,-4}");
            }
        }
    }
}

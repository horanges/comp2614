using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class ConsolePrinter
    {
        const int LINE_LENGTH = 30;

        public static void PrintContacts(Contact[] contacts)
        {
            Console.WriteLine("\nContacts");
            Console.WriteLine(new string('-', LINE_LENGTH));

            foreach(Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
                Console.WriteLine(contact.Address);
                Console.WriteLine("{0} {1}  {2}\n\n", contact.City, contact.Province, contact.PostalCode);
            }
        }
    }
}

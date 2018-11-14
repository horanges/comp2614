// COMP2614 Assign02
// Creates 3 instances of a Contact class, adds them to an array and then outputs content to console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string address;
            string city;
            string province;
            string postalCode;

            const int LINE_LENGTH = 30;
            const int CONTACTS_LENGTH = 3;

            // Sets console title
            Console.Title = "COMP2614 - Assignment 2 - A00947294";

            Console.WriteLine("Contact Information");
            Console.WriteLine(new string('-', LINE_LENGTH));

            // Prompts and collects contact information from user
            Console.Write("Firstname:   ");
            firstName = Console.ReadLine();

            Console.Write("Lastname:    ");
            lastName = Console.ReadLine();

            Console.Write("Address:     ");
            address = Console.ReadLine();

            Console.Write("City:        ");
            city = Console.ReadLine();

            Console.Write("Province:    ");
            province = Console.ReadLine();

            Console.Write("Postal Code: ");
            postalCode = Console.ReadLine();

            // Adds contacts to Contact array
            Contact[] contacts = new Contact[CONTACTS_LENGTH];

            // Empty Contact object and then populated via properties
            Contact contact1 = new Contact();
            contact1.FirstName = firstName;
            contact1.LastName = lastName;
            contact1.Address = address;
            contact1.City = city;
            contact1.Province = province;
            contact1.PostalCode = postalCode;

            contacts[0] = contact1;

            // Parameterized constructor
            contacts[1] = new Contact(firstName, lastName, address, city, province, postalCode);

            // Object Initializer syntax
            contacts[2] = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                Province = province,
                PostalCode = postalCode
            };

            // Prints contacts
            ConsolePrinter.PrintContacts(contacts);
        }
    }
}

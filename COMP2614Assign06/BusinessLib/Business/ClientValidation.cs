using BusinessLib.Common;
using BusinessLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLib.Business
{
    // Validation of Client objects
    public class ClientValidation
    {
        private static List<string> errors;

        static ClientValidation()
        {
            errors = new List<string>();
        }

        // Stores errors list
        public static string ErrorMessage
        {
            get
            {
                string message = "";

                foreach (string line in errors)
                {
                    message += line + "\r\n";
                }

                return message;
            }
        }

        // Gets clients
        public static ClientCollection GetClient() => ClientRepository.GetAllClients();

        // Adds client if validated
        public static int AddClient(Client client)
        {
            if (Validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return -1;
            }
        }

        // Updates client if validated
        public static int UpdateClient(Client client)
        {
            if (Validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }

        // Deletes client if validated
        public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);

        // Validates clients and adds to error list if unsuccessful
        public static bool Validate(Client client)
        {
            bool success = true;
            errors.Clear();

            if (string.IsNullOrEmpty(client.ClientCode))
            {
                errors.Add("ClientCode cannot be empty.");
                success = false;
            }

            if (string.IsNullOrEmpty(client.CompanyName))
            {
                errors.Add("CompanyName cannot be empty.");
                success = false;
            }

            if (string.IsNullOrEmpty(client.Address1))
            {
                errors.Add("Address1 cannot be empty.");
                success = false;
            }

            if (string.IsNullOrEmpty(client.Province))
            {
                errors.Add("Province cannot be empty.");
                success = false;
            }

            if (client.YtdSales < 0.00M)
            {
                errors.Add("YtdSales cannot be negative.");
                success = false;
            }

            return success;
        }
    }
}

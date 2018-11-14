using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    class CustomerRepository
    {
        private static string connString = @"Server=tcp:skeena.database.windows.net,1433;
                                            Initial Catalog=comp2614;
                                            User ID=student;
                                            Password=93nu5#Z183;
                                            Encrypt=True;
                                            TrustServerCertificate=False;
                                            Connection Timeout=30;";

        public static List<String> GetAllProvinces()
        {
            List<String> provinces = new List<string>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT DISTINCT Province
                    FROM Customer";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string province;

                        while (reader.Read())
                        {
                            province = reader["Province"] as string;

                            provinces.Add(province);
                        }
                    }

                    provinces.Add("ALL");

                    return provinces;
                }
            }
        }

        public static List<Customer> GetCustomerByProvince(string provinceFilter)
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query;

                if (provinceFilter == "ALL")
                {
                    query = @"SELECT CompanyName, City, Province, PostalCode, CreditHold
                        FROM Customer
                        ORDER BY CompanyName";
                }
                else
                {
                    query = @"SELECT CompanyName, City, Province, PostalCode, CreditHold
                        FROM Customer
                        WHERE Province = @provinceFilter
                        ORDER BY CompanyName";
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@provinceFilter", provinceFilter);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // only company name is not nullable
                        string companyName;
                        string city = null;
                        string province = null;
                        string postalCode = null;
                        bool? creditHold = null;

                        while (reader.Read())
                        {
                            companyName = reader["CompanyName"] as string;

                            if (!reader.IsDBNull(1))
                            {
                                city = reader["City"] as string;
                            }

                            if (!reader.IsDBNull(2))
                            {
                                province = reader["Province"] as string;
                            }

                            if (!reader.IsDBNull(3))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                creditHold = reader["CreditHold"] as bool?;
                            }

                            customers.Add(new Customer(companyName, city, province, postalCode, creditHold));

                            // reset the nullables
                            city = null;
                            province = null;
                            postalCode = null;
                        }
                    }

                    return customers;
                }
            }
        }
    }
}

using BusinessLib.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Data
{
    // CRUD methods
    public class ClientRepository
    {
        private static string connString = @"Server=tcp:skeena.database.windows.net,1433;
                                             Initial Catalog=comp2614; 
                                             User ID=student; 
                                             Password=93nu5#Z183; 
                                             Encrypt=True; 
                                             TrustServerCertificate=False; 
                                             Connection Timeout=30;";

        // Get clients
        public static ClientCollection GetAllClients()
        {
            ClientCollection clients;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YtdSales, CreditHold, Notes
                    FROM Client947294";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    clients = new ClientCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string clientCode;
                        string companyName;
                        string address1;
                        string address2 = null;
                        string city = null;
                        string province;
                        string postalCode = null;
                        decimal ytdSales;
                        bool creditHold;
                        string notes = null;

                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                address2 = reader["Address2"] as string;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;
                            }

                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(6))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            ytdSales = (decimal)reader["YtdSales"];
                            creditHold = (bool)reader["CreditHold"];

                            if (!reader.IsDBNull(9))
                            {
                                notes = reader["Notes"] as string;
                            }

                            clients.Add(new Client(clientCode, companyName, address1, address2, city, province, postalCode, ytdSales, creditHold, notes));

                            // Reset nulls
                            address2 = null;
                            city = null;
                            postalCode = null;
                            notes = null;
                        }
                    }

                    return clients;
                }
            }
        }

        // Adds clients
        public static int AddClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"INSERT INTO Client947294
                                (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YtdSales, CreditHold, Notes)
                                 VALUES (@clientCode, @companyName, @address1, @address2, @city, @province, @postalCode, @ytdSales, @creditHold, @notes)";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        // Updates clients
        public static int UpdateClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"UPDATE Client947294
                                 SET CompanyName = @companyName
                                 , Address1 = @address1
                                 , Address2 = @address2
                                 , City = @city
                                 , Province = @province
                                 , PostalCode = @postalCode
                                 , YtdSales = @ytdSales
                                 , CreditHold = @creditHold
                                 , Notes = @notes
                                 WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        // Deletes clients
        public static int DeleteClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"DELETE Client947294
                                 WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
    }
}

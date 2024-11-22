using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MSGProject.Model;

namespace MSGProject.Controllers
{
    internal class BestellingenController
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<BestellingenModel> GetBestellingen()
        {
            List<BestellingenModel> bestellingen = new List<BestellingenModel>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM bestellingen";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BestellingenModel bestelling = new BestellingenModel
                    {
                        Bestelling_Id = reader.GetInt32(0),
                        Gebruiker_Id = reader.GetInt32(1),
                        Menu_Id = reader.GetInt32(2),
                        Bestelling_Datum = reader.GetDateTime(3),
                        Bestelling_Status = reader.GetString(4),
                    };
                    bestellingen.Add(bestelling);
                }
                reader.Close();
            }
            return bestellingen;
        }
    }
}
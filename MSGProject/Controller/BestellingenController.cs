using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MSGProject.Model;
using MySql.Data.MySqlClient;

namespace MSGProject.Controllers
{
    internal class BestellingenController
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<BestellingenModel> GetBestellingen()
        {
            List<BestellingenModel> bestellingen = new List<BestellingenModel>();
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Bestellingen";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BestellingenModel bestelling = new BestellingenModel
                    {
                        Bestelling_Id = reader.GetInt32("Bestelling_Id"),
                        Gebruiker_Id = reader.GetInt32("Gebruiker_Id"),
                        Menu_Id = reader.GetInt32("Menu_Id"),
                        Bestelling_Datum = reader.GetDateTime("Bestelling_Datum"),
                        Bestelling_Status = reader.GetString("Bestelling_Status"),
                    };
                    bestellingen.Add(bestelling);
                }
                reader.Close();
            }
            return bestellingen;
        }

        // Toevoegen button controller
        public void AddBestelling(BestellingenModel bestelling)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Bestellingen (Gebruiker_Id, Menu_Id, Bestelling_Datum, Bestelling_Status) " +
                               "VALUES (@gebruikerId, @menuId, @datum, @status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@gebruikerId", bestelling.Gebruiker_Id);
                command.Parameters.AddWithValue("@menuId", bestelling.Menu_Id);
                command.Parameters.AddWithValue("@datum", bestelling.Bestelling_Datum);
                command.Parameters.AddWithValue("@status", bestelling.Bestelling_Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Aanpassen button controller
        public void UpdateBestelling(BestellingenModel bestelling)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE Bestellingen SET Gebruiker_Id = @gebruikerId, Menu_Id = @menuId, " +
                               "Bestelling_Datum = @datum, Bestelling_Status = @status WHERE Bestelling_Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", bestelling.Bestelling_Id);
                command.Parameters.AddWithValue("@gebruikerId", bestelling.Gebruiker_Id);
                command.Parameters.AddWithValue("@menuId", bestelling.Menu_Id);
                command.Parameters.AddWithValue("@datum", bestelling.Bestelling_Datum);
                command.Parameters.AddWithValue("@status", bestelling.Bestelling_Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Verwijderen button controller
        public void DeleteBestelling(int bestellingId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM Bestellingen WHERE Bestelling_Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", bestellingId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
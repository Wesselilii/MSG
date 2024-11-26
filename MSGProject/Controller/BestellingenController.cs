using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
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
                // Query to join Bestellingen with Gebruikers and get full name
                string query = @"SELECT 
                                    b.Bestelling_Id, 
                                    g.Gebruiker_Voornaam, 
                                    g.Gebruiker_Achternaam, 
                                    b.Menu_Id, 
                                    b.Bestelling_Datum, 
                                    b.Bestelling_Status
                                FROM Bestellingen b
                                JOIN Gebruikers g ON b.Gebruiker_Id = g.Gebruiker_Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BestellingenModel bestelling = new BestellingenModel
                    {
                        Bestelling_Id = reader.GetInt32("Bestelling_Id"),
                        Gebruiker_Voornaam = reader.GetString("Gebruiker_Voornaam"),
                        Gebruiker_Achternaam = reader.GetString("Gebruiker_Achternaam"),
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

        public int GetGebruikerId(string voornaam, string achternaam)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT Gebruiker_Id FROM Gebruikers WHERE Gebruiker_Voornaam = @voornaam AND Gebruiker_Achternaam = @achternaam";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@voornaam", voornaam);
                command.Parameters.AddWithValue("@achternaam", achternaam);

                connection.Open();
                var result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        // Method to add a new bestelling to the database
        public void AddBestelling(BestellingenModel bestelling)
        {
            // Fetch Gebruiker_Id
            int gebruikerId = GetGebruikerId(bestelling.Gebruiker_Voornaam, bestelling.Gebruiker_Achternaam);
            if (gebruikerId == 0)
                throw new Exception("Gebruiker not found. Cannot add bestelling.");

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Bestellingen (Gebruiker_Id, Menu_Id, Bestelling_Datum, Bestelling_Status) " +
                               "VALUES (@gebruikerId, @menuId, @datum, @status)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@gebruikerId", gebruikerId);
                command.Parameters.AddWithValue("@menuId", bestelling.Menu_Id);
                command.Parameters.AddWithValue("@datum", bestelling.Bestelling_Datum);
                command.Parameters.AddWithValue("@status", bestelling.Bestelling_Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateBestelling(BestellingenModel bestelling)
        {
            int gebruikerId = GetGebruikerId(bestelling.Gebruiker_Voornaam, bestelling.Gebruiker_Achternaam);
            if (gebruikerId == 0)
                throw new Exception("Gebruiker not found. Cannot update bestelling.");

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "UPDATE Bestellingen SET Gebruiker_Id = @gebruikerId, Menu_Id = @menuId, " +
                               "Bestelling_Datum = @datum, Bestelling_Status = @status WHERE Bestelling_Id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", bestelling.Bestelling_Id);
                command.Parameters.AddWithValue("@gebruikerId", gebruikerId);
                command.Parameters.AddWithValue("@menuId", bestelling.Menu_Id);
                command.Parameters.AddWithValue("@datum", bestelling.Bestelling_Datum);
                command.Parameters.AddWithValue("@status", bestelling.Bestelling_Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBestelling(int bestellingId)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "DELETE FROM Bestellingen WHERE Bestelling_Id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", bestellingId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
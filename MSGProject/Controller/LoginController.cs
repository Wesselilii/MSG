using System;
using System.Configuration;
using MSGProject.Model;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Windows.Forms; // Import BCrypt library

namespace MSGProject.Controller
{
    internal class LoginController
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public GebruikerModel AuthenticateUser(string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                // Query to retrieve the user by email
                string query = "SELECT Gebruiker_Id, Gebruiker_Voornaam, Gebruiker_Achternaam, Gebruiker_Email, Gebruiker_Wachtwoord, Gebruiker_Rol " +
                               "FROM Gebruikers WHERE Gebruiker_Email = @Email";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHashedPassword = reader.GetString(reader.GetOrdinal("Gebruiker_Wachtwoord"));

                        // Verify the password using bcrypt
                        if (BCrypt.Net.BCrypt.EnhancedVerify(password, storedHashedPassword))
                        {
                            // Return the user model if the password matches
                            return new GebruikerModel
                            {
                                Gebruiker_Id = reader.GetInt32(reader.GetOrdinal("Gebruiker_Id")),
                                Gebruiker_Voornaam = reader.GetString(reader.GetOrdinal("Gebruiker_Voornaam")),
                                Gebruiker_Achternaam = reader.GetString(reader.GetOrdinal("Gebruiker_Achternaam")),
                                Gebruiker_Email = reader.GetString(reader.GetOrdinal("Gebruiker_Email")),
                                Gebruiker_Wachtwoord = storedHashedPassword,
                                Gebruiker_Rol = reader.GetString(reader.GetOrdinal("Gebruiker_Rol"))
                            };
                        }
                    }
                }
            }
            // Return null if authentication fails
            return null;
        }
    }
}

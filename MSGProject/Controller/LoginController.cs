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
    internal class LoginController
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public GebruikerModel AuthenticateUser(string email, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Gebruikers WHERE Gebruiker_Email = @Email AND Gebruiker_Wachtwoord = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password); // Assume passwords are hashed in production!

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new GebruikerModel
                        {
                            Gebruiker_Id = reader.GetInt32("Gebruiker_Id"),
                            Gebruiker_Voornaam = reader.GetString("Gebruiker_Voornaam"),
                            Gebruiker_Achternaam = reader.GetString("Gebruiker_Achternaam"),
                            Gebruiker_Email = reader.GetString("Gebruiker_Email"),
                            Gebruiker_Wachtwoord = reader.GetString("Gebruiker_Wachtwoord"),
                            Gebruiker_Rol = reader.GetString("Gebruiker_Rol")
                        };
                    }
                }
            }
            return null;
        }
    }
}

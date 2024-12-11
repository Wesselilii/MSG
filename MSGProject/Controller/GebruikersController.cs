using MSGProject.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGProject.Controller
{
    internal class GebruikersController
    {
        private readonly string _connectionString;

        public GebruikersController()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        // Function that retrieves users (Read)
        public List<GebruikersModel> GebruikersRead()
        {
            string SelectQuery = "SELECT Gebruiker_Id, Gebruiker_Voornaam, Gebruiker_Achternaam, Gebruiker_Email, Gebruiker_Wachtwoord, Gebruiker_Rol FROM Gebruikers";

            List<GebruikersModel> gebruikerList = new List<GebruikersModel>();

            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(SelectQuery, con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gebruikerList.Add(new GebruikersModel
                            {
                                Gebruiker_Id = reader.GetInt32(reader.GetOrdinal("Gebruiker_Id")),
                                Gebruiker_Voornaam = reader.GetString(reader.GetOrdinal("Gebruiker_Voornaam")),
                                Gebruiker_Achternaam = reader.GetString(reader.GetOrdinal("Gebruiker_Achternaam")),
                                Gebruiker_Email = reader.GetString(reader.GetOrdinal("Gebruiker_Email")),
                                Gebruiker_Wachtwoord = reader.GetString(reader.GetOrdinal("Gebruiker_Wachtwoord")),
                                Gebruiker_Rol = reader.GetString(reader.GetOrdinal("Gebruiker_Rol"))
                            });
                        }
                    }
                }
            }

            return gebruikerList;
        }

        // Function that adds a user (Create)
        public void GebruikersCreate(GebruikersModel gebruiker)
        {
            string checkEmailQuery = "SELECT COUNT(*) FROM Gebruikers WHERE Gebruiker_Email = @Email";
            string createQuery = "INSERT INTO Gebruikers (Gebruiker_Voornaam, Gebruiker_Achternaam, Gebruiker_Email, Gebruiker_Wachtwoord, Gebruiker_Rol) " +
                                 "VALUES (@Voornaam, @Achternaam, @Email, @Wachtwoord, @Rol)";

            string password = gebruiker.Gebruiker_Wachtwoord;
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);

            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();

                // Check if the email already exists
                using (MySqlCommand checkCommand = new MySqlCommand(checkEmailQuery, con))
                {
                    checkCommand.Parameters.AddWithValue("@Email", gebruiker.Gebruiker_Email);
                    int emailCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (emailCount > 0)
                    {
                        throw new Exception("Email already exists in the database.");
                    }
                }

                // Insert the new user if the email is unique
                using (MySqlCommand createCommand = new MySqlCommand(createQuery, con))
                {
                    createCommand.Parameters.AddWithValue("@Voornaam", gebruiker.Gebruiker_Voornaam);
                    createCommand.Parameters.AddWithValue("@Achternaam", gebruiker.Gebruiker_Achternaam);
                    createCommand.Parameters.AddWithValue("@Email", gebruiker.Gebruiker_Email);
                    createCommand.Parameters.AddWithValue("@Wachtwoord", hashedPassword);
                    createCommand.Parameters.AddWithValue("@Rol", gebruiker.Gebruiker_Rol);

                    createCommand.ExecuteNonQuery();
                }
            }
        }


        // Function that edits a user (Update)
        public void GebruikersUpdate(GebruikersModel gebruiker)
        {
            string UpdateQuery;
            bool isPasswordEmpty = string.IsNullOrEmpty(gebruiker.Gebruiker_Wachtwoord);


            UpdateQuery = "UPDATE Gebruikers SET Gebruiker_Voornaam = @Voornaam, Gebruiker_Achternaam = @Achternaam, Gebruiker_Email = @Email, Gebruiker_Rol = @Rol " +
                            "WHERE Gebruiker_Id = @GebruikerId";

            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(UpdateQuery, con))
                {
                    command.Parameters.AddWithValue("@GebruikerId", gebruiker.Gebruiker_Id);
                    command.Parameters.AddWithValue("@Voornaam", gebruiker.Gebruiker_Voornaam);
                    command.Parameters.AddWithValue("@Achternaam", gebruiker.Gebruiker_Achternaam);
                    command.Parameters.AddWithValue("@Email", gebruiker.Gebruiker_Email);
                    command.Parameters.AddWithValue("@Rol", gebruiker.Gebruiker_Rol);

                    if (!isPasswordEmpty)
                    {
                        string password = gebruiker.Gebruiker_Wachtwoord;
                        string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);
                        command.Parameters.AddWithValue("@Wachtwoord", hashedPassword);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }

        // Function that deletes a user (Delete)
        public void GebruikersDelete(int gebruikerId)
        {
            string DeleteQuery = "DELETE FROM Gebruikers WHERE Gebruiker_Id = @GebruikerId";

            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(DeleteQuery, con))
                {
                    command.Parameters.AddWithValue("@GebruikerId", gebruikerId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}


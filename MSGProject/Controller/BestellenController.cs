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
    internal class BestellenController
    {
        // Connection string to the MySQL database
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        // Method to get a list of menu items
        public static List<MenuModel> GetBestellen()
        {
            List<MenuModel> menuList = new List<MenuModel>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                // SQL query to fetch menu data
                string query = @"SELECT 
                                    Menu_Id, 
                                    Menu_Naam, 
                                    Menu_Type, 
                                    Menu_Prijs, 
                                    Menu_Beschrijving 
                                FROM Menu";

                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open(); // Open the database connection

                MySqlDataReader reader = command.ExecuteReader(); // Execute the query

                // Read each row and populate the menuList with MenuModel objects
                while (reader.Read())
                {
                    MenuModel menuItem = new MenuModel
                    {
                        MenuId = reader.GetInt32("Menu_Id"),
                        Menu_Naam = reader.GetString("Menu_Naam"),
                        Menu_Type = reader.GetString("Menu_Type"),
                        Menu_Prijs = reader.GetDecimal("Menu_Prijs"),
                        Menu_Beschrijving = reader.GetString("Menu_Beschrijving")
                    };
                    menuList.Add(menuItem); // Add the item to the list
                }
                reader.Close(); // Close the reader
            }

            return menuList; // Return the list of menu items
        }
    }
}
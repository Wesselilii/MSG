using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MSGProject.Model;

namespace MSGProject.Controller
{
    internal class MenuController
    {

        // Add a new menu item
        public static bool AddMenu(MenuModel menu)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helper.ConnectionString))
                {
                    string query = @"INSERT INTO Menu (Menu_Naam, Menu_Beschrijving, Menu_Type, Menu_Prijs, Menu_Beschikbaar)
                                     VALUES (@MenuNaam, @MenuBeschrijving, @MenuType, @MenuPrijs, @MenuBeschikbaar)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MenuNaam", menu.Menu_Naam);
                    cmd.Parameters.AddWithValue("@MenuBeschrijving", menu.Menu_Beschrijving ?? (object)DBNull.Value); // Handle null descriptions
                    cmd.Parameters.AddWithValue("@MenuType", menu.Menu_Type);
                    cmd.Parameters.AddWithValue("@MenuPrijs", menu.Menu_Prijs);
                    cmd.Parameters.AddWithValue("@MenuBeschikbaar", menu.Menu_Beschikbaar);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add menu item. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Delete a menu item by ID
        public static bool DeleteMenu(int menuId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helper.ConnectionString))
                {
                    string query = @"DELETE FROM Menu WHERE Menu_Id = @MenuId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MenuId", menuId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete menu item. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Update an existing menu item
        public static bool UpdateMenu(MenuModel menu)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helper.ConnectionString))
                {
                    string query = @"UPDATE Menu
                                     SET Menu_Naam = @MenuNaam, 
                                         Menu_Beschrijving = @MenuBeschrijving, 
                                         Menu_Type = @MenuType, 
                                         Menu_Prijs = @MenuPrijs, 
                                         Menu_Beschikbaar = @MenuBeschikbaar
                                     WHERE Menu_Id = @MenuId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MenuNaam", menu.Menu_Naam);
                    cmd.Parameters.AddWithValue("@MenuBeschrijving", menu.Menu_Beschrijving ?? (object)DBNull.Value); // Handle null descriptions
                    cmd.Parameters.AddWithValue("@MenuType", menu.Menu_Type);
                    cmd.Parameters.AddWithValue("@MenuPrijs", menu.Menu_Prijs);
                    cmd.Parameters.AddWithValue("@MenuBeschikbaar", menu.Menu_Beschikbaar);
                    cmd.Parameters.AddWithValue("@MenuId", menu.MenuId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update menu item. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Get a menu item by ID
        public static MenuModel GetMenuById(int menuId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helper.ConnectionString))
                {
                    string query = @"SELECT Menu_Id, Menu_Naam, Menu_Beschrijving, Menu_Type, Menu_Prijs, Menu_Beschikbaar
                             FROM Menu
                             WHERE Menu_Id = @MenuId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MenuId", menuId);

                    conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new MenuModel
                        {
                            MenuId = reader.GetInt32("Menu_Id"),
                            Menu_Naam = reader.GetString("Menu_Naam"),
                            Menu_Beschrijving = reader.IsDBNull(reader.GetOrdinal("Menu_Beschrijving")) ? null : reader.GetString("Menu_Beschrijving"),
                            Menu_Type = reader.GetString("Menu_Type"),
                            Menu_Prijs = reader.GetDecimal("Menu_Prijs"),
                            Menu_Beschikbaar = reader.GetBoolean("Menu_Beschikbaar")
                        };
                    }
                    else
                    {
                        return null; // No menu found with the provided ID
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch the menu item. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Read all menu items
        public static List<MenuModel> GetAllMenus()
        {
            try
            {
                List<MenuModel> menuList = new List<MenuModel>();

                using (MySqlConnection conn = new MySqlConnection(Helper.ConnectionString))
                {
                    string query = @"SELECT Menu_Id, Menu_Naam, Menu_Beschrijving, Menu_Type, Menu_Prijs, Menu_Beschikbaar FROM Menu";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var menu = new MenuModel
                        {
                            MenuId = reader.GetInt32("Menu_Id"),
                            Menu_Naam = reader.GetString("Menu_Naam"),
                            Menu_Beschrijving = reader.IsDBNull(reader.GetOrdinal("Menu_Beschrijving")) ? null : reader.GetString("Menu_Beschrijving"),
                            Menu_Type = reader.GetString("Menu_Type"),
                            Menu_Prijs = reader.GetDecimal("Menu_Prijs"),
                            Menu_Beschikbaar = reader.GetBoolean("Menu_Beschikbaar")
                        };

                        menuList.Add(menu);
                    }
                }

                return menuList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch menu items. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<MenuModel>();
            }
        }
    }
}

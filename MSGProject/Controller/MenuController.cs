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
                    cmd.Parameters.AddWithValue("@MenuNaam", menu.MenuNaam);
                    cmd.Parameters.AddWithValue("@MenuBeschrijving", menu.MenuBeschrijving ?? (object)DBNull.Value); // Handle null descriptions
                    cmd.Parameters.AddWithValue("@MenuType", menu.MenuType);
                    cmd.Parameters.AddWithValue("@MenuPrijs", menu.MenuPrijs);
                    cmd.Parameters.AddWithValue("@MenuBeschikbaar", menu.MenuBeschikbaar);

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
                    cmd.Parameters.AddWithValue("@MenuNaam", menu.MenuNaam);
                    cmd.Parameters.AddWithValue("@MenuBeschrijving", menu.MenuBeschrijving ?? (object)DBNull.Value); // Handle null descriptions
                    cmd.Parameters.AddWithValue("@MenuType", menu.MenuType);
                    cmd.Parameters.AddWithValue("@MenuPrijs", menu.MenuPrijs);
                    cmd.Parameters.AddWithValue("@MenuBeschikbaar", menu.MenuBeschikbaar);
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
                            MenuNaam = reader.GetString("Menu_Naam"),
                            MenuBeschrijving = reader.IsDBNull(reader.GetOrdinal("Menu_Beschrijving")) ? null : reader.GetString("Menu_Beschrijving"),
                            MenuType = reader.GetString("Menu_Type"),
                            MenuPrijs = reader.GetDecimal("Menu_Prijs"),
                            MenuBeschikbaar = reader.GetBoolean("Menu_Beschikbaar")
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

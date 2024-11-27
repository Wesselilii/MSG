using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Model;

namespace MSGProject.View.Menu
{
    public partial class EditMenu : MaterialForm
    {
        private readonly int? menuId; // Holds Menu_Id if editing, null if adding

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public EditMenu(int? menuId = null)
        {
            InitializeComponent();
            this.menuId = menuId;

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void EditMenu_Load(object sender, EventArgs e)
        {
            if (menuId.HasValue)
            {
                // Editing: Load the menu data
                LoadMenuData(menuId.Value);
            }
        }


        private void LoadMenuData(int menuId)
        {
            // Fetch menu data from the database
            var menu = MenuController.GetMenuById(menuId); // Assumes this method exists

            if (menu != null)
            {
                // Debugging to check if the data is being loaded correctly
                MessageBox.Show($"Menu Found: {menu.MenuNaam}, {menu.MenuBeschrijving}, {menu.MenuPrijs}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Setting textboxes values safely to handle possible null values
                txtBox_Menu_Name.Text = menu.MenuNaam ?? string.Empty; // Use empty string if null
                txtBox_Menu_Description.Text = menu.MenuBeschrijving ?? string.Empty; // Use empty string if null
                txtBox_Menu_Price.Text = menu.MenuPrijs.ToString("F2"); // Formatting price to 2 decimal places

                if ((bool)menu.MenuBeschikbaar)
                {
                    Menu_Status_Combobox.SelectedItem = "Ja";  // If MenuBeschikbaar is true, set to "Ja"
                }
                else
                {
                    Menu_Status_Combobox.SelectedItem = "Nee"; // If MenuBeschikbaar is false, set to "Nee"
                }

                Menu_Type_Combobox.SelectedItem = menu.MenuType;
            }
            else
            {
                MessageBox.Show("Menu item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtBox_Menu_Name.Text.Trim();
            string description = txtBox_Menu_Description.Text.Trim();
            decimal price;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || !decimal.TryParse(txtBox_Menu_Price.Text, out price))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected type from Menu_Type_Combobox
            string menuType = Menu_Type_Combobox.SelectedItem?.ToString();

            // Get the selected availability (Ja/Nee) from Menu_Status_Combobox
            bool menuBeschikbaar = Menu_Status_Combobox.SelectedItem?.ToString() == "Ja"; // "Ja" -> true, "Nee" -> false

            if (menuId.HasValue)
            {
                // Editing: Update the menu item
                bool isUpdated = MenuController.UpdateMenu(new MenuModel
                {
                    MenuId = menuId.Value,
                    MenuNaam = name,
                    MenuBeschrijving = description,
                    MenuPrijs = price,
                    MenuType = menuType,
                    MenuBeschikbaar = menuBeschikbaar
                });

                if (isUpdated)
                {
                    MessageBox.Show("Menu item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Adding: Insert a new menu item
                bool isAdded = MenuController.AddMenu(new MenuModel
                {
                    MenuNaam = name,
                    MenuBeschrijving = description,
                    MenuPrijs = price,
                    MenuType = menuType,
                    MenuBeschikbaar = menuBeschikbaar
                });

                if (isAdded)
                {
                    MessageBox.Show("Menu item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to add menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Model;
using MSGProject.View.Menu;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MSGProject
{
    public partial class Dashboard : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Dashboard()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Load_Menus();
        }

        private void Load_Menus()
        {
            // Clear existing items in the ListView
            Listview_Menu.Items.Clear();
            List<MenuModel> menuList = MenuController.GetAllMenus();

            foreach (MenuModel menu in menuList)
            {
                ListViewItem item = new ListViewItem(menu.MenuId.ToString());

                item.SubItems.Add(menu.MenuNaam);
                item.SubItems.Add(menu.MenuBeschrijving ?? ""); // Handle null description
                item.SubItems.Add(menu.MenuType);
                item.SubItems.Add(menu.MenuPrijs.ToString("C")); // Format price as currency
                item.SubItems.Add(menu.MenuBeschikbaar.HasValue && menu.MenuBeschikbaar.Value ? "Yes" : "No");

                // Add the item to the ListView
                Listview_Menu.Items.Add(item);
            }
        }

        private void Maaltijden_Form_Verwijderen_Btn_Click(object sender, EventArgs e)
        {
            //If no menu item selected return error
            if (Listview_Menu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteer een maaltijd om te verwijderen.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //get current selected item by id
            ListViewItem selectedItem = Listview_Menu.SelectedItems[0];
            int menuId = Convert.ToInt32(selectedItem.SubItems[0].Text);

            if (MessageBox.Show($"Weet u zeker dat u dit item wilt verwijderen? {menuId}", "Bevestiging",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Delete menu item
                if (MenuController.DeleteMenu(menuId))
                {
                    Listview_Menu.Items.Remove(selectedItem);
                    MessageBox.Show("Maaltijd is succesvol verwijderd.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("De maaltijd kon niet worden verwijderd.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Maaltijden_Form_Wijzigen_Btn_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in ListView_Menu
            if (Listview_Menu.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = Listview_Menu.SelectedItems[0];
                int menuId = Convert.ToInt32(selectedItem.SubItems[0].Text); // Assuming menuId is in the first column

                // Show the EditMenu form as a modal dialog
                EditMenu editMenuForm = new EditMenu(menuId);
                editMenuForm.ShowDialog(); // This will block the parent form until the dialog is closed

                Load_Menus();
            }
            else
            {
                MessageBox.Show("Selecteer een maaltijd om te bewerken.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Maaltijden_Form_Toevoegen_Btn_Click(object sender, EventArgs e)
        {
            EditMenu editMenuForm = new EditMenu(null);
            editMenuForm.ShowDialog();

            Load_Menus();
        }
    }
}

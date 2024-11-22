using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
    }
}

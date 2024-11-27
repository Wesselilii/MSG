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
        private GebruikerModel _currentUser;
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
            // If no user is logged in, show only the HomeTab and disable all other tabs
            if (_currentUser == null)
            {
                DisableAllTabsExceptHome();
            }
            else
            {
                Load_RoleChecker();
            }
            Load_Bestellingen();
        }

        // ---------------- LOGIN ------------------------------------------------------------------------------------------------------
        private void HomeLButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = HomeLTextBox1.Text;
                string password = HomeLTextBox2.Text;

                // Authenticate user via LoginController
                var loginController = new LoginController();
                var user = loginController.AuthenticateUser(email, password);

                if (user != null)
                {
                    MessageBox.Show($"Welkom, {user.Gebruiker_Voornaam} {user.Gebruiker_Achternaam}!");

                    // Store the authenticated user in the _currentUser variable
                    _currentUser = user;

                    // Check if the user is an admin and handle tab visibility accordingly
                    if (user.Gebruiker_Rol == "Admin")
                    {

                        BestellingenTab.Enabled = true; // Admin can access Bestellingen
                    }
                    else
                    {
                        BestellingenTab.Enabled = false; // Non-admins cannot access Bestellingen
                    }
                    Load_RoleChecker();
                }
                else
                {
                    MessageBox.Show("Ongeldige Email of Wachtwoord.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error bij het inloggen: {ex.Message}");
            }
        }

        // ---------------- ROLE CHECKER ---------------------------------------
        private void Load_RoleChecker()
        {
            // Only proceed if the current user exists (meaning they're logged in)
            if (_currentUser != null && _currentUser.Gebruiker_Rol != "Admin")
            {
                // If the user is not an admin, remove the Bestellingen tab from the tabs list
                materialTabControl1.TabPages.Remove(BestellingenTab);
            }
        }

        private void DisableAllTabsExceptHome()
        {
            foreach (TabPage tabPage in materialTabControl1.TabPages)
            {
                if (tabPage != HomeTab)
                {
                    materialTabControl1.TabPages.Remove(tabPage);
                }
            }
        }

        private void RestoreTabs()
        {
            // Make sure all the necessary tabs are added back before role checks
            if (!materialTabControl1.TabPages.Contains(HomeTab))
            {
                materialTabControl1.TabPages.Add(HomeTab);  // Add HomeTab back if it's missing
            }

            // Add other tabs back if they were removed previously
            if (!materialTabControl1.TabPages.Contains(BestellingenTab))
            {
                materialTabControl1.TabPages.Add(GebruikersTab);
                materialTabControl1.TabPages.Add(MaaltijdTab);
                materialTabControl1.TabPages.Add(BestellingenTab);
            }
        }


    // ---------------- BESTELLINGEN --- Administratie -----------------------------------------------------------------------------
        private void Load_Bestellingen()
        {
            try
            {
                // Clear existing items in the ListView
                BestelAListView1.Items.Clear();

                // get the controller data
                var bestellingController = new BestellingenController();
                var bestellingen = bestellingController.GetBestellingen();

                foreach (var bestelling in bestellingen)
                {
                    // Combine First Name and Last Name for display in the ListView
                    string fullName = $"{bestelling.Gebruiker_Voornaam} {bestelling.Gebruiker_Achternaam}";
                    var item = new ListViewItem(bestelling.Bestelling_Id.ToString());

                    item.SubItems.Add(fullName);
                    item.SubItems.Add(bestelling.Menu_Id.ToString());
                    item.SubItems.Add(bestelling.Bestelling_Datum.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(bestelling.Bestelling_Status);

                    // Attach the order ID to the Tag property for future reference
                    item.Tag = bestelling.Bestelling_Id;

                    // Add the constructed item(s) to the ListView
                    BestelAListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error bij het laden van bestellingen: " + ex.Message);
            }
        }

        // -------- Aanpassen button ---------
        private void BestelAButton1_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected in the ListView
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Gather data from input fields
                    int bestellingId = int.Parse(BestelATextbox1.Text); // Order ID
                    string voornaam = BestelATextbox2.Text; // First Name
                    string achternaam = BestelATextbox3.Text; // Last Name
                    int menuId = int.Parse(BestelATextbox4.Text); // Menu ID
                    DateTime datum = BestelADateTimePicker.Value; // Order Date
                    string status = BestelACombobox1.Text; // Order Status

                    // Create a new Bestelling model with updated data
                    var updatedBestelling = new BestellingenModel
                    {
                        Bestelling_Id = bestellingId,
                        Gebruiker_Voornaam = voornaam,
                        Gebruiker_Achternaam = achternaam,
                        Menu_Id = menuId,
                        Bestelling_Datum = datum,
                        Bestelling_Status = status
                    };

                    // Update the order via the controller
                    var controller = new BestellingenController();
                    controller.UpdateBestelling(updatedBestelling);

                    // Reload the ListView to reflect changes
                    Load_Bestellingen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error bij het aanpassen van een item: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een item om aan te passen.");
            }
        }

        // -------- Toevoegen button ---------
        private void BestelAButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from input fields
                string gebruikerVoornaam = BestelATextbox2.Text; // User First Name
                string gebruikerAchternaam = BestelATextbox3.Text; // User Last Name
                int menuId = int.Parse(BestelATextbox4.Text); // Menu ID
                DateTime datum = BestelADateTimePicker.Value; // Order Date
                string status = BestelACombobox1.SelectedItem.ToString(); // Order Status

                // Retrieve User ID based on First and Last Name
                var controller = new BestellingenController();
                int gebruikerId = controller.GetGebruikerId(gebruikerVoornaam, gebruikerAchternaam);

                if (gebruikerId == 0)
                {
                    // Inform the user if no matching user is found
                    MessageBox.Show("Gebruiker niet gevonden. Check de voor & achternaam.");
                    return;
                }

                // Create a new Bestelling model with input data
                var newBestelling = new BestellingenModel
                {
                    Gebruiker_Id = gebruikerId,
                    Gebruiker_Voornaam = gebruikerVoornaam,
                    Gebruiker_Achternaam = gebruikerAchternaam,
                    Menu_Id = menuId,
                    Bestelling_Datum = datum,
                    Bestelling_Status = status
                };

                // Add the order via the controller
                controller.AddBestelling(newBestelling);
                Load_Bestellingen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout met het toevoegen van order: " + ex.Message);
            }
        }

        // -------- Verwijderen button ---------
        private void BestelAButton3_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected in the ListView
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Retrieve the selected order's ID from the Tag property
                    int bestellingId = (int)BestelAListView1.SelectedItems[0].Tag;

                    // Delete the order via the controller
                    var controller = new BestellingenController();
                    controller.DeleteBestelling(bestellingId);

                    // Reload the ListView to reflect changes
                    Load_Bestellingen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het verwijderen van gebruiker: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een item om te verwijderen.");
            }
        }

        // ------- ListView Item Selection Event -------
        private void BestelAListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                var selectedItem = BestelAListView1.SelectedItems[0];

                // Split the full name into 2 to populate separate the textboxes
                string[] fullName = selectedItem.SubItems[1].Text.Split(' ');

                // Populate the input fields with selected item data
                BestelATextbox1.Text = selectedItem.SubItems[0].Text; 
                BestelATextbox2.Text = fullName.Length > 0 ? fullName[0] : "";
                BestelATextbox3.Text = fullName.Length > 1 ? fullName[1] : "";
                BestelATextbox4.Text = selectedItem.SubItems[2].Text;
                BestelADateTimePicker.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
                BestelACombobox1.Text = selectedItem.SubItems[4].Text;
            }
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

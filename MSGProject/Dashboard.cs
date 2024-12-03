using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Controllers;
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
        private readonly GebruikerModel _currentUser;

        // Constructor accepting GebruikerModel
        public Dashboard(GebruikerModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE
            );
        }

        // Harm --------------- Welcome User ----------------------------------------------------------------------------
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Display a welcome message
            Dashboard_Welcome_Label.Text = $"Welcome, {_currentUser.Gebruiker_Voornaam} {_currentUser.Gebruiker_Achternaam}!";

            // Show or hide tabs based on user role
            UpdateTabsVisibility();
        }

        private void UpdateTabsVisibility()
        {
            // Remove all tabs initially
            List<TabPage> tabsToRemove = new List<TabPage>();
            foreach (TabPage tabPage in materialTabControl1.TabPages)
            {
                tabsToRemove.Add(tabPage);
            }
            foreach (TabPage tabPage in tabsToRemove)
            {
                materialTabControl1.TabPages.Remove(tabPage);
            }

            // Add tabs based on the current user's role
            switch (_currentUser.Gebruiker_Rol.ToLower())
            {
                case "klant":
                    materialTabControl1.TabPages.Add(HomeTab);
                    materialTabControl1.TabPages.Add(GBestellingenTab);
                    Load_GBestellen();

                    break;

                case "chef":
                    materialTabControl1.TabPages.Add(HomeTab);
                    materialTabControl1.TabPages.Add(MaaltijdTab);
                    Load_Menus();
                    break;

                case "administratie":
                    materialTabControl1.TabPages.Add(HomeTab);
                    materialTabControl1.TabPages.Add(GebruikersTab);
                    materialTabControl1.TabPages.Add(MaaltijdTab);
                    materialTabControl1.TabPages.Add(BestellingenTab);
                    Load_Bestellingen();
                    Load_Menus();
                    break;

                default:
                    materialTabControl1.TabPages.Add(HomeTab); // Default tab for unrecognized roles
                    break;
            }
        }

        // Wesley ---------------- BESTELLINGEN --- Gebruiker ---------------------------------------------------------------------------------
        private void Load_GBestellen()
        {
            try
            {
                // Clear any existing items in the ListView
                BestelGListView1.Items.Clear();

                // Get the menu items using the controller
                List<MenuModel> menuList = BestellenController.GetBestellen();

                // Add items to the ListView
                foreach (var menu in menuList)
                {
                    var item = new ListViewItem(menu.Menu_Naam);
                    item.SubItems.Add(menu.Menu_Type);
                    item.SubItems.Add(menu.Menu_Prijs.ToString("C"));
                    item.SubItems.Add(menu.Menu_Beschrijving);

                    // Store the MenuId
                    item.Tag = menu.MenuId;

                    // Add the item to the ListView
                    BestelGListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error bij het laden van deze pagina: " + ex.Message);
            }
        }

        private void BestelGListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BestelGListView1.SelectedItems.Count > 0)
            {
                var selectedItem = BestelGListView1.SelectedItems[0];

                // Retrieve the ID number from the MenuId Tag
                int selectedMenuId = (int)selectedItem.Tag;

                // Populate textboxes with visible data
                BestelGTextbox1.Text = selectedItem.SubItems[0].Text;  // Menu_Naam
                BestelGTextbox2.Text = selectedItem.SubItems[1].Text;  // Menu_Type
                BestelGTextbox3.Text = selectedItem.SubItems[2].Text;  // Menu_Prijs
                BestelGTextbox4.Text = selectedItem.SubItems[3].Text;  // Menu_Beschrijving

                // Disable editing in textboxes
                BestelGTextbox1.Enabled = false;
                BestelGTextbox2.Enabled = false;
                BestelGTextbox3.Enabled = false;
                BestelGTextbox4.Enabled = false;

                Console.WriteLine($"Selected Menu ID: {selectedMenuId}");
            }
        }

        // Wesley ---------------- BESTELLINGEN --- Administratie -----------------------------------------------------------------------------
        private void Load_Bestellingen()
        {
            try
            {
                // Clear existing items in the ListView
                BestelAListView1.Items.Clear();

                // Get the controller data
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
                MessageBox.Show("error bij het laden van deze pagina: " + ex.Message);
            }
        }

        // -------- BESTELLINGEN Aanpassen button ---------
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

        // -------- BESTELLINGEN Toevoegen button ---------
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

                // Add the Bestelling via the controller
                controller.AddBestelling(newBestelling);
                Load_Bestellingen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout met het toevoegen van een bestelling: " + ex.Message);
            }
        }

        // -------- BESTELLINGEN Verwijderen button ---------
        private void BestelAButton3_Click(object sender, EventArgs e)
        {
            // Ensure an item is selected in the ListView
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Retrieve the selected Bestelling ID from the Tag Bestelling_Id
                    int bestellingId = (int)BestelAListView1.SelectedItems[0].Tag;

                    // Delete the Bestelling via the controller
                    var controller = new BestellingenController();
                    controller.DeleteBestelling(bestellingId);
                    Load_Bestellingen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij het verwijderen van een bestelling: " + ex.Message);
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

        // Harm ----------- Menu loading ---------------------------
        private void Load_Menus()
        {
            // Clear existing items in the ListView
            Listview_Menu.Items.Clear();
            List<MenuModel> menuList = MenuController.GetAllMenus();

            foreach (MenuModel menu in menuList)
            {
                ListViewItem item = new ListViewItem(menu.MenuId.ToString());

                item.SubItems.Add(menu.Menu_Naam);
                item.SubItems.Add(menu.Menu_Beschrijving ?? ""); // Handle null description
                item.SubItems.Add(menu.Menu_Type);
                item.SubItems.Add(menu.Menu_Prijs.ToString("C")); // Format price as currency
                item.SubItems.Add(menu.Menu_Beschikbaar.HasValue && menu.Menu_Beschikbaar.Value ? "Yes" : "No");

                // Add the item to the ListView
                Listview_Menu.Items.Add(item);
            }
        }

        // Harm -------------------- Menu Deleting ---------------------

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

        // Harm -------------------- Menu Edit and show Form ---------------------
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

        // Harm -------------------- Add Button to Show Form ---------------------

        private void Maaltijden_Form_Toevoegen_Btn_Click(object sender, EventArgs e)
        {
            EditMenu editMenuForm = new EditMenu(null);
            editMenuForm.ShowDialog();

            Load_Menus();
        }
    }
}

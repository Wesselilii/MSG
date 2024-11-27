using MaterialSkin.Controls;
using MSGProject.Controllers;
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
            Load_GBestellen();
            Load_Bestellingen();
        }



        // ---------------- BESTELLINGEN --- Gebruiker ---------------------------------------------------------------------------------
        private void Load_GBestellen()
        {
            try
            {
                // Clear any existing items in the ListView
                BestelGListView1.Items.Clear();

                // Get the menu items using the controller
                List<MenuModel> menuList = BestellenController.GetBestellen();

                // Loop through the list and add items to the ListView
                foreach (var menu in menuList)
                {
                    // Create a ListView item, using Menu_Naam as the first visible column
                    var item = new ListViewItem(menu.Menu_Naam);

                    // Add the remaining subitems (Type, Prijs, Beschrijving)
                    item.SubItems.Add(menu.Menu_Type);
                    item.SubItems.Add(menu.Menu_Prijs.ToString("C"));  // Format the price as currency
                    item.SubItems.Add(menu.Menu_Beschrijving);

                    // Store the MenuId in the Tag property (not visible to the user)
                    item.Tag = menu.MenuId;

                    // Add the item to the ListView
                    BestelGListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("error bij het laden van deze pagina: " + ex.Message);
            }
        }

        private void BestelGListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BestelGListView1.SelectedItems.Count > 0)
            {
                var selectedItem = BestelGListView1.SelectedItems[0];

                // Retrieve the ID from the Tag
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
                MessageBox.Show("error bij het laden van deze pagina: " + ex.Message);
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
    }
}

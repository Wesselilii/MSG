using MaterialSkin.Controls;
using MSGProject.Controllers;
using MSGProject.Model;
using System;
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
            Load_Bestellingen();
        }

        // ---------------- BESTELLINGEN -------------------------------------------------------------------------------------------
        private void Load_Bestellingen()
        {
            try
            {
                // Clear existing items in the ListView
                BestelAListView1.Items.Clear();

                // Instantiate the controller and get data
                var bestellingController = new BestellingenController();
                var bestellingen = bestellingController.GetBestellingen();

                foreach (var bestelling in bestellingen)
                {
                    // Combine Voornaam and Achternaam for display in ListView
                    string fullName = $"{bestelling.Gebruiker_Voornaam} {bestelling.Gebruiker_Achternaam}";

                    // Add a new row to the ListView
                    var item = new ListViewItem(bestelling.Bestelling_Id.ToString());
                    item.SubItems.Add(fullName); // Full name in second column
                    item.SubItems.Add(bestelling.Menu_Id.ToString());
                    item.SubItems.Add(bestelling.Bestelling_Datum.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(bestelling.Bestelling_Status);

                    // Attach the ID to Tag for future reference
                    item.Tag = bestelling.Bestelling_Id;

                    BestelAListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // -------- Aanpassen knop (Update Button) ---------
        private void BestelAButton1_Click(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    int bestellingId = int.Parse(BestelATextbox1.Text);
                    string voornaam = BestelATextbox2.Text;
                    string achternaam = BestelATextbox3.Text;
                    int menuId = int.Parse(BestelATextbox4.Text);
                    DateTime datum = BestelADateTimePicker.Value;
                    string status = BestelACombobox1.Text;

                    var updatedBestelling = new BestellingenModel
                    {
                        Bestelling_Id = bestellingId,
                        Gebruiker_Voornaam = voornaam,
                        Gebruiker_Achternaam = achternaam,
                        Menu_Id = menuId,
                        Bestelling_Datum = datum,
                        Bestelling_Status = status
                    };

                    var controller = new BestellingenController();
                    controller.UpdateBestelling(updatedBestelling);
                    Load_Bestellingen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling om aan te passen.");
            }
        }

        // -------- Toevoegen knop (Add Button) ---------
        private void BestelAButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from input fields
                string gebruikerVoornaam = BestelATextbox2.Text;  // Gebruiker Voornaam
                string gebruikerAchternaam = BestelATextbox3.Text;  // Gebruiker Achternaam
                int menuId = int.Parse(BestelATextbox4.Text);  // Menu Id
                DateTime datum = BestelADateTimePicker.Value;  // Bestelling Datum (DateTimePicker)
                string status = BestelACombobox1.SelectedItem.ToString();  // Bestelling Status (ComboBox)

                // Find Gebruiker_Id based on Voornaam and Achternaam
                var controller = new BestellingenController();
                int gebruikerId = controller.GetGebruikerId(gebruikerVoornaam, gebruikerAchternaam);

                if (gebruikerId == 0)
                {
                    MessageBox.Show("Gebruiker niet gevonden. Controleer de voornaam en achternaam.");
                    return;
                }

                // Create new Bestelling model
                var newBestelling = new BestellingenModel
                {
                    Gebruiker_Id = gebruikerId,
                    Gebruiker_Voornaam = gebruikerVoornaam,
                    Gebruiker_Achternaam = gebruikerAchternaam,
                    Menu_Id = menuId,
                    Bestelling_Datum = datum,
                    Bestelling_Status = status
                };

                // Add the bestelling via controller
                controller.AddBestelling(newBestelling);

                // Refresh the ListView
                Load_Bestellingen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding bestelling: " + ex.Message);
            }
        }

        // -------- Verwijderen knop (Delete Button) ---------
        private void BestelAButton3_Click(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Get the selected item's ID from Tag (which stores the Bestelling_Id)
                    int bestellingId = (int)BestelAListView1.SelectedItems[0].Tag;

                    // Delete the bestelling via controller
                    var controller = new BestellingenController();
                    controller.DeleteBestelling(bestellingId);

                    // Refresh the ListView
                    Load_Bestellingen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting bestelling: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling om te verwijderen.");
            }
        }

        // ------- Interactieve Listview (ListView Item Selection) -------
        private void BestelAListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                var selectedItem = BestelAListView1.SelectedItems[0];

                // Split the full name to populate separate textboxes
                string[] fullName = selectedItem.SubItems[1].Text.Split(' ');

                BestelATextbox1.Text = selectedItem.SubItems[0].Text; // Bestelling_Id
                BestelATextbox2.Text = fullName.Length > 0 ? fullName[0] : ""; // Voornaam
                BestelATextbox3.Text = fullName.Length > 1 ? fullName[1] : ""; // Achternaam
                BestelATextbox4.Text = selectedItem.SubItems[2].Text; // Menu_Id
                BestelADateTimePicker.Value = DateTime.Parse(selectedItem.SubItems[3].Text); // Bestelling_Datum
                BestelACombobox1.Text = selectedItem.SubItems[4].Text; // Bestelling_Status
            }
        }
    }
}

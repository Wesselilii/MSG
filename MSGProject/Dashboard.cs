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

                // Instantiate the controller
                var bestellingController = new BestellingenController();
                var bestellingen = bestellingController.GetBestellingen();

                foreach (var bestelling in bestellingen)
                {
                    var item = new ListViewItem(bestelling.Gebruiker_Id.ToString());
                    item.SubItems.Add(bestelling.Menu_Id.ToString());
                    item.SubItems.Add(bestelling.Bestelling_Datum.ToShortDateString());
                    item.SubItems.Add(bestelling.Bestelling_Status);
                    item.Tag = bestelling.Bestelling_Id; // Store ID for reference

                    BestelAListView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // -------- Aanpassen knop ---------
        private void BestelAButton1_Click(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Get the selected item's ID from Tag
                    int bestellingId = (int)BestelAListView1.SelectedItems[0].Tag;

                    // Gather updated data from input fields
                    int gebruikerId = int.Parse(BestelATextbox1.Text);
                    int menuId = int.Parse(BestelATextbox2.Text);
                    DateTime datum = DateTime.Parse(BestelATextbox3.Text);
                    string status = BestelATextbox4.Text;

                    // Create updated bestelling model
                    var updatedBestelling = new BestellingenModel
                    {
                        Bestelling_Id = bestellingId,
                        Gebruiker_Id = gebruikerId,
                        Menu_Id = menuId,
                        Bestelling_Datum = datum,
                        Bestelling_Status = status
                    };

                    // Update the bestelling via controller
                    var controller = new BestellingenController();
                    controller.UpdateBestelling(updatedBestelling);

                    // Refresh the ListView
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

        // -------- Toevoegen knop ---------
        private void BestelAButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data from input fields
                int gebruikerId = int.Parse(BestelATextbox1.Text);
                int menuId = int.Parse(BestelATextbox2.Text);
                DateTime datum = DateTime.Parse(BestelATextbox3.Text);
                string status = BestelATextbox4.Text;

                // Create new bestelling model
                var newBestelling = new BestellingenModel
                {
                    Gebruiker_Id = gebruikerId,
                    Menu_Id = menuId,
                    Bestelling_Datum = datum,
                    Bestelling_Status = status
                };

                // Add the bestelling via controller
                var controller = new BestellingenController();
                controller.AddBestelling(newBestelling);

                // Refresh the ListView
                Load_Bestellingen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // -------- Verwijderen knop ---------
        private void BestelAButton3_Click(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                try
                {
                    // Get the selected item's ID from Tag
                    int bestellingId = (int)BestelAListView1.SelectedItems[0].Tag;

                    // Delete the bestelling via controller
                    var controller = new BestellingenController();
                    controller.DeleteBestelling(bestellingId);

                    // Refresh the ListView
                    Load_Bestellingen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling om te verwijderen.");
            }
        }

        // ------- Interactieve Listview -------
        private void BestelAListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BestelAListView1.SelectedItems.Count > 0)
            {
                var selectedItem = BestelAListView1.SelectedItems[0];

                // Populate input fields with the selected item's details
                BestelATextbox1.Text = selectedItem.SubItems[0].Text; // Gebruiker ID
                BestelATextbox2.Text = selectedItem.SubItems[1].Text; // Menu ID
                BestelATextbox3.Text = selectedItem.SubItems[2].Text; // Datum
                BestelATextbox4.Text = selectedItem.SubItems[3].Text; // Status
            }
        }
    }
}

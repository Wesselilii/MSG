using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Model;
using MSGProject.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MSGProject
{
    public partial class Dashboard : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        readonly GebruikersController gebruikersController = new GebruikersController();
        public Dashboard()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            GebruikersLoad();
        }




        // ----------------------------gebruikers---------------------------
        //
        //

        // read function
        public void GebruikersLoad()
        {
            // Retrieve the list of users
            List<GebruikersModel> gebruikers = gebruikersController.GebruikersRead();

            // Clear and configure the ListView
            gebruikerListView1.Items.Clear();
            gebruikerListView1.FullRowSelect = true;
            gebruikerListView1.View = System.Windows.Forms.View.Details;
            gebruikerListView1.HeaderStyle = ColumnHeaderStyle.Clickable;

            // Populate the ListView
            foreach (var gebruiker in gebruikers)
            {
                ListViewItem item = new ListViewItem(gebruiker.Gebruiker_Id.ToString());
                item.SubItems.Add(gebruiker.Gebruiker_Voornaam);
                item.SubItems.Add(gebruiker.Gebruiker_Achternaam);
                item.SubItems.Add(gebruiker.Gebruiker_Email);
                item.SubItems.Add(gebruiker.Gebruiker_Rol);

                gebruikerListView1.Items.Add(item);
            }
        }

        // create button
        private void gebruikerCreateButton_Click(object sender, EventArgs e)
        {
            GebruikersCreate gebruikersCreate = new GebruikersCreate(this);
            gebruikersCreate.Show();
        }

        // edit button
        private void gebruikerEditButton_Click(object sender, EventArgs e)
        {
            // check if there is a item selected
            if (gebruikerListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kies een gebruiker om te bewerken.", "geen selectie gemaakt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item and the UserID
            var selectedItem = gebruikerListView1.SelectedItems[0];

            GebruikersUpdate GebruikersUpdate = new GebruikersUpdate(selectedItem, this);
            GebruikersUpdate.Show();
        }

        // delete button
        private void gebruikerDeleteButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView and ask for confirmation
            if (gebruikerListView1.SelectedItems.Count > 0 && MessageBox.Show("Weet je zeker dat je deze gebruiker wilt verwijderen?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get the selected ListViewItem
                ListViewItem selectedItem = gebruikerListView1.SelectedItems[0];
                // Delete player by id
                try
                {
                    int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                    gebruikersController.GebruikersDelete(id);
                }
                catch
                {
                    MessageBox.Show("Fout met het verwijderen van de gebruiker.");
                }
                //Refresh listview data
                GebruikersLoad();
            }
            else
            {
                MessageBox.Show("Kies eerst een gebruiker om te verwijderen");
            }
        }
    }
}

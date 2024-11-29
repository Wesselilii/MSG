using MaterialSkin;
using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSGProject.View
{
    public partial class GebruikersCreate : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        readonly GebruikersController gebruikersController = new GebruikersController();
        private readonly Dashboard dashboard; // Reference to the other form

        public GebruikersCreate(Dashboard dashboard)
        {
            InitializeComponent();
            // Initialize MaterialSkin
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Indigo200,
                MaterialSkin.TextShade.WHITE
            );

            this.dashboard = dashboard;
        }

        private void UpdateConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                GebruikersModel gebruikersModel = new GebruikersModel
                {
                    Gebruiker_Voornaam = VoornaamTextBox.Text,
                    Gebruiker_Achternaam = AchternaamTextBox.Text,
                    Gebruiker_Email = EmailTextBox.Text,
                    Gebruiker_Rol = RolComboBox.SelectedItem.ToString(), // Assuming the ComboBox items are strings
                    Gebruiker_Wachtwoord = WachtwoordTextBox.Text
                };

                gebruikersController.GebruikersCreate(gebruikersModel);

                dashboard.GebruikersLoad();

                MessageBox.Show("Gebruiker aangepast");
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MSGProject.Controller;
using MSGProject.Model;

namespace MSGProject.View.Startup
{
    public partial class Register_Form : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        readonly GebruikersController gebruikersController = new GebruikersController();
        public Register_Form()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void Register_CreateConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                GebruikersModel gebruikersModel = new GebruikersModel
                {
                    Gebruiker_Voornaam = Register_VoornaamTextBox.Text,
                    Gebruiker_Achternaam = Register_AchternaamTextBox.Text,
                    Gebruiker_Email = Register_EmailTextBox.Text,
                    Gebruiker_Rol = "Klant",
                    Gebruiker_Wachtwoord = Register_WachtwoordTextBox.Text
                };

                gebruikersController.GebruikersCreate(gebruikersModel);

                MessageBox.Show("Succesvol geregistreerd!");
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Fout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

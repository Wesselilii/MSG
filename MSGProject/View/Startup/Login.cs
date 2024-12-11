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
using MSGProject.View.Startup;

namespace MSGProject.View.Login
{
    public partial class Login : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Capture email and password input
            string email = Login_Email_TextBox.Text.Trim();
            string password = Login_Password_Textbox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vul alle velden in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Authenticate the user
                LoginController loginController = new LoginController();
                GebruikerModel user = loginController.AuthenticateUser(email, password);

                if (user != null)
                {
                    // Clear input fields
                    Login_Email_TextBox.Clear();
                    Login_Password_Textbox.Clear();

                    // Authentication successful, open Dashboard
                    Dashboard dashboard = new Dashboard(user); // Pass authenticated user to Dashboard
                    dashboard.Show();

                    // Hide the current form
                    this.Hide();
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Foute email of wachtwoord.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"Fout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MaterialLabel1_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegisterForm
            Register_Form registerForm = new Register_Form();

            // Show the RegisterForm as a modal dialog
            registerForm.Show();
        }
    }
}

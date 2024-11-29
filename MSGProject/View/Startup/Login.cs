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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Capture email and password input
            string email = Login_Email_TextBox.Text.Trim();
            string password = Login_Password_Textbox.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Authenticate the user
                LoginController loginController = new LoginController();
                GebruikerModel user = loginController.AuthenticateUser(email, password);

                if (user != null)
                {
                    Login_Email_TextBox.Clear();
                    Login_Password_Textbox.Clear();
                    // Authentication successful, open Dashboard
                    Dashboard dashboard = new Dashboard(user); // Pass user to Dashboard
                    dashboard.Show();
                    this.Hide(); // Close the login form
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

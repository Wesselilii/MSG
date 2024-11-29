namespace MSGProject.View.Login
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Button = new MaterialSkin.Controls.MaterialButton();
            this.Login_Password_Textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.Login_Email_TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.AutoSize = false;
            this.Login_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Login_Button.Depth = 0;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Login_Button.HighEmphasis = true;
            this.Login_Button.Icon = null;
            this.Login_Button.Location = new System.Drawing.Point(226, 330);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Login_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Login_Button.Size = new System.Drawing.Size(349, 48);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Login_Button.UseAccentColor = false;
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login_Password_Textbox
            // 
            this.Login_Password_Textbox.AnimateReadOnly = false;
            this.Login_Password_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Password_Textbox.Depth = 0;
            this.Login_Password_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Password_Textbox.LeadingIcon = null;
            this.Login_Password_Textbox.Location = new System.Drawing.Point(226, 251);
            this.Login_Password_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Login_Password_Textbox.MaxLength = 50;
            this.Login_Password_Textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Login_Password_Textbox.Multiline = false;
            this.Login_Password_Textbox.Name = "Login_Password_Textbox";
            this.Login_Password_Textbox.Password = true;
            this.Login_Password_Textbox.Size = new System.Drawing.Size(349, 50);
            this.Login_Password_Textbox.TabIndex = 4;
            this.Login_Password_Textbox.Text = "";
            this.Login_Password_Textbox.TrailingIcon = null;
            // 
            // Login_Email_TextBox
            // 
            this.Login_Email_TextBox.AnimateReadOnly = false;
            this.Login_Email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Email_TextBox.Depth = 0;
            this.Login_Email_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Email_TextBox.LeadingIcon = null;
            this.Login_Email_TextBox.Location = new System.Drawing.Point(226, 182);
            this.Login_Email_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Login_Email_TextBox.MaxLength = 50;
            this.Login_Email_TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Login_Email_TextBox.Multiline = false;
            this.Login_Email_TextBox.Name = "Login_Email_TextBox";
            this.Login_Email_TextBox.Size = new System.Drawing.Size(349, 50);
            this.Login_Email_TextBox.TabIndex = 3;
            this.Login_Email_TextBox.Text = "";
            this.Login_Email_TextBox.TrailingIcon = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 482);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Login_Password_Textbox);
            this.Controls.Add(this.Login_Email_TextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Login_Button;
        private MaterialSkin.Controls.MaterialTextBox Login_Password_Textbox;
        private MaterialSkin.Controls.MaterialTextBox Login_Email_TextBox;
    }
}
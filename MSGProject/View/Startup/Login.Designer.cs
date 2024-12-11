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
            this.Login_Password_Label = new MaterialSkin.Controls.MaterialLabel();
            this.Login_Email_Label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Login_Button.AutoSize = false;
            this.Login_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Login_Button.Depth = 0;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Login_Button.HighEmphasis = true;
            this.Login_Button.Icon = null;
            this.Login_Button.Location = new System.Drawing.Point(227, 385);
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
            this.Login_Button.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login_Password_Textbox
            // 
            this.Login_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Login_Password_Textbox.AnimateReadOnly = false;
            this.Login_Password_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Password_Textbox.Depth = 0;
            this.Login_Password_Textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Password_Textbox.LeadingIcon = null;
            this.Login_Password_Textbox.Location = new System.Drawing.Point(227, 268);
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
            this.Login_Email_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Login_Email_TextBox.AnimateReadOnly = false;
            this.Login_Email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Email_TextBox.Depth = 0;
            this.Login_Email_TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Email_TextBox.LeadingIcon = null;
            this.Login_Email_TextBox.Location = new System.Drawing.Point(227, 165);
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
            // Login_Password_Label
            // 
            this.Login_Password_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Login_Password_Label.AutoSize = true;
            this.Login_Password_Label.Depth = 0;
            this.Login_Password_Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Password_Label.Location = new System.Drawing.Point(223, 241);
            this.Login_Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_Password_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Password_Label.Name = "Login_Password_Label";
            this.Login_Password_Label.Size = new System.Drawing.Size(94, 19);
            this.Login_Password_Label.TabIndex = 6;
            this.Login_Password_Label.Text = "Wachtwoord:";
            // 
            // Login_Email_Label
            // 
            this.Login_Email_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Login_Email_Label.AutoSize = true;
            this.Login_Email_Label.Depth = 0;
            this.Login_Email_Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Email_Label.Location = new System.Drawing.Point(223, 138);
            this.Login_Email_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_Email_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Email_Label.Name = "Login_Email_Label";
            this.Login_Email_Label.Size = new System.Drawing.Size(45, 19);
            this.Login_Email_Label.TabIndex = 7;
            this.Login_Email_Label.Text = "Email:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(6, 350);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(816, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Geen account? Klik hier!";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.UseAccent = true;
            this.materialLabel1.Click += new System.EventHandler(this.MaterialLabel1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 482);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Login_Email_Label);
            this.Controls.Add(this.Login_Password_Label);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Login_Password_Textbox);
            this.Controls.Add(this.Login_Email_TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Login_Button;
        private MaterialSkin.Controls.MaterialTextBox Login_Password_Textbox;
        private MaterialSkin.Controls.MaterialTextBox Login_Email_TextBox;
        private MaterialSkin.Controls.MaterialLabel Login_Password_Label;
        private MaterialSkin.Controls.MaterialLabel Login_Email_Label;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
namespace MSGProject.View.Menu
{
    partial class EditMenu
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBox_Menu_Name = new MaterialSkin.Controls.MaterialTextBox();
            this.Menu_Form_Title = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBox_Menu_Price = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBox_Menu_Description = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Menu_Type_Combobox = new MaterialSkin.Controls.MaterialComboBox();
            this.Menu_Status_Combobox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(493, 663);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(195, 46);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Opslaan";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(552, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 23);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Naam";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Menu_Name
            // 
            this.txtBox_Menu_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Menu_Name.AnimateReadOnly = false;
            this.txtBox_Menu_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Menu_Name.Depth = 0;
            this.txtBox_Menu_Name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBox_Menu_Name.LeadingIcon = null;
            this.txtBox_Menu_Name.Location = new System.Drawing.Point(409, 163);
            this.txtBox_Menu_Name.MaxLength = 50;
            this.txtBox_Menu_Name.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBox_Menu_Name.Multiline = false;
            this.txtBox_Menu_Name.Name = "txtBox_Menu_Name";
            this.txtBox_Menu_Name.Size = new System.Drawing.Size(373, 36);
            this.txtBox_Menu_Name.TabIndex = 2;
            this.txtBox_Menu_Name.Text = "";
            this.txtBox_Menu_Name.TrailingIcon = null;
            this.txtBox_Menu_Name.UseTallSize = false;
            // 
            // Menu_Form_Title
            // 
            this.Menu_Form_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Form_Title.Depth = 0;
            this.Menu_Form_Title.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Menu_Form_Title.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.Menu_Form_Title.HighEmphasis = true;
            this.Menu_Form_Title.Location = new System.Drawing.Point(499, 50);
            this.Menu_Form_Title.MouseState = MaterialSkin.MouseState.HOVER;
            this.Menu_Form_Title.Name = "Menu_Form_Title";
            this.Menu_Form_Title.Size = new System.Drawing.Size(186, 54);
            this.Menu_Form_Title.TabIndex = 3;
            this.Menu_Form_Title.Text = "Maaltijd";
            this.Menu_Form_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(544, 214);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 31);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Type";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(557, 303);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 42);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Prijs";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Menu_Price
            // 
            this.txtBox_Menu_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Menu_Price.AnimateReadOnly = false;
            this.txtBox_Menu_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Menu_Price.Depth = 0;
            this.txtBox_Menu_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBox_Menu_Price.LeadingIcon = null;
            this.txtBox_Menu_Price.Location = new System.Drawing.Point(409, 350);
            this.txtBox_Menu_Price.MaxLength = 50;
            this.txtBox_Menu_Price.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBox_Menu_Price.Multiline = false;
            this.txtBox_Menu_Price.Name = "txtBox_Menu_Price";
            this.txtBox_Menu_Price.Size = new System.Drawing.Size(373, 36);
            this.txtBox_Menu_Price.TabIndex = 7;
            this.txtBox_Menu_Price.Text = "";
            this.txtBox_Menu_Price.TrailingIcon = null;
            this.txtBox_Menu_Price.UseTallSize = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(521, 406);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(143, 25);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Beschikbaar";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(518, 491);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(156, 38);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Beschrijving";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Menu_Description
            // 
            this.txtBox_Menu_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Menu_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBox_Menu_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Menu_Description.Depth = 0;
            this.txtBox_Menu_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBox_Menu_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBox_Menu_Description.Location = new System.Drawing.Point(409, 539);
            this.txtBox_Menu_Description.MaxLength = 255;
            this.txtBox_Menu_Description.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_Menu_Description.Name = "txtBox_Menu_Description";
            this.txtBox_Menu_Description.Size = new System.Drawing.Size(373, 82);
            this.txtBox_Menu_Description.TabIndex = 11;
            this.txtBox_Menu_Description.Text = "";
            // 
            // Menu_Type_Combobox
            // 
            this.Menu_Type_Combobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Type_Combobox.AutoResize = false;
            this.Menu_Type_Combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu_Type_Combobox.Depth = 0;
            this.Menu_Type_Combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Menu_Type_Combobox.DropDownHeight = 118;
            this.Menu_Type_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Menu_Type_Combobox.DropDownWidth = 121;
            this.Menu_Type_Combobox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Menu_Type_Combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Menu_Type_Combobox.FormattingEnabled = true;
            this.Menu_Type_Combobox.IntegralHeight = false;
            this.Menu_Type_Combobox.ItemHeight = 29;
            this.Menu_Type_Combobox.Items.AddRange(new object[] {
            "Vlees",
            "Vis",
            "Vegetarisch"});
            this.Menu_Type_Combobox.Location = new System.Drawing.Point(409, 257);
            this.Menu_Type_Combobox.MaxDropDownItems = 4;
            this.Menu_Type_Combobox.MouseState = MaterialSkin.MouseState.OUT;
            this.Menu_Type_Combobox.Name = "Menu_Type_Combobox";
            this.Menu_Type_Combobox.Size = new System.Drawing.Size(373, 35);
            this.Menu_Type_Combobox.StartIndex = 0;
            this.Menu_Type_Combobox.TabIndex = 12;
            this.Menu_Type_Combobox.UseTallSize = false;
            // 
            // Menu_Status_Combobox
            // 
            this.Menu_Status_Combobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_Status_Combobox.AutoResize = false;
            this.Menu_Status_Combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu_Status_Combobox.Depth = 0;
            this.Menu_Status_Combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Menu_Status_Combobox.DropDownHeight = 118;
            this.Menu_Status_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Menu_Status_Combobox.DropDownWidth = 121;
            this.Menu_Status_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Menu_Status_Combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Menu_Status_Combobox.FormattingEnabled = true;
            this.Menu_Status_Combobox.IntegralHeight = false;
            this.Menu_Status_Combobox.ItemHeight = 29;
            this.Menu_Status_Combobox.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.Menu_Status_Combobox.Location = new System.Drawing.Point(409, 443);
            this.Menu_Status_Combobox.MaxDropDownItems = 4;
            this.Menu_Status_Combobox.MouseState = MaterialSkin.MouseState.OUT;
            this.Menu_Status_Combobox.Name = "Menu_Status_Combobox";
            this.Menu_Status_Combobox.Size = new System.Drawing.Size(373, 35);
            this.Menu_Status_Combobox.StartIndex = 0;
            this.Menu_Status_Combobox.TabIndex = 13;
            this.Menu_Status_Combobox.UseTallSize = false;
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 732);
            this.Controls.Add(this.Menu_Status_Combobox);
            this.Controls.Add(this.Menu_Type_Combobox);
            this.Controls.Add(this.txtBox_Menu_Description);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtBox_Menu_Price);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Menu_Form_Title);
            this.Controls.Add(this.txtBox_Menu_Name);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "EditMenu";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Maaltijd";
            this.Load += new System.EventHandler(this.EditMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtBox_Menu_Name;
        private MaterialSkin.Controls.MaterialLabel Menu_Form_Title;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtBox_Menu_Price;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtBox_Menu_Description;
        private MaterialSkin.Controls.MaterialComboBox Menu_Type_Combobox;
        private MaterialSkin.Controls.MaterialComboBox Menu_Status_Combobox;
    }
}
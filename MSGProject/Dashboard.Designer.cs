namespace MSGProject
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.GebruikersTab = new System.Windows.Forms.TabPage();
            this.MaaltijdTab = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Listview_Menu = new MaterialSkin.Controls.MaterialListView();
            this.Menu_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maaltijden_Form_Verwijderen_Btn = new MaterialSkin.Controls.MaterialButton();
            this.Maaltijden_Form_Wijzigen_Btn = new MaterialSkin.Controls.MaterialButton();
            this.Maaltijden_Form_Toevoegen_Btn = new MaterialSkin.Controls.MaterialButton();
            this.BestellingenTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.MaaltijdTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.HomeTab);
            this.materialTabControl1.Controls.Add(this.GebruikersTab);
            this.materialTabControl1.Controls.Add(this.MaaltijdTab);
            this.materialTabControl1.Controls.Add(this.BestellingenTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 79);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1325, 532);
            this.materialTabControl1.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.ImageKey = "home-32.png";
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(1317, 489);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // GebruikersTab
            // 
            this.GebruikersTab.ImageKey = "user-32.png";
            this.GebruikersTab.Location = new System.Drawing.Point(4, 39);
            this.GebruikersTab.Margin = new System.Windows.Forms.Padding(4);
            this.GebruikersTab.Name = "GebruikersTab";
            this.GebruikersTab.Padding = new System.Windows.Forms.Padding(4);
            this.GebruikersTab.Size = new System.Drawing.Size(1317, 489);
            this.GebruikersTab.TabIndex = 0;
            this.GebruikersTab.Text = "Gebruikers";
            this.GebruikersTab.UseVisualStyleBackColor = true;
            // 
            // MaaltijdTab
            // 
            this.MaaltijdTab.Controls.Add(this.materialLabel1);
            this.MaaltijdTab.Controls.Add(this.Listview_Menu);
            this.MaaltijdTab.Controls.Add(this.Maaltijden_Form_Verwijderen_Btn);
            this.MaaltijdTab.Controls.Add(this.Maaltijden_Form_Wijzigen_Btn);
            this.MaaltijdTab.Controls.Add(this.Maaltijden_Form_Toevoegen_Btn);
            this.MaaltijdTab.ImageKey = "rice-32.png";
            this.MaaltijdTab.Location = new System.Drawing.Point(4, 39);
            this.MaaltijdTab.Margin = new System.Windows.Forms.Padding(4);
            this.MaaltijdTab.Name = "MaaltijdTab";
            this.MaaltijdTab.Padding = new System.Windows.Forms.Padding(4);
            this.MaaltijdTab.Size = new System.Drawing.Size(1317, 489);
            this.MaaltijdTab.TabIndex = 1;
            this.MaaltijdTab.Text = "Maaltijden";
            this.MaaltijdTab.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(16, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 29);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Maaltijden";
            // 
            // Listview_Menu
            // 
            this.Listview_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listview_Menu.AutoSizeTable = false;
            this.Listview_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Listview_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listview_Menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Menu_Id,
            this.Menu_Name,
            this.Menu_Description,
            this.Menu_Type,
            this.Menu_Price,
            this.Menu_Status});
            this.Listview_Menu.Depth = 0;
            this.Listview_Menu.FullRowSelect = true;
            this.Listview_Menu.HideSelection = false;
            this.Listview_Menu.Location = new System.Drawing.Point(7, 57);
            this.Listview_Menu.MinimumSize = new System.Drawing.Size(200, 100);
            this.Listview_Menu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Listview_Menu.MouseState = MaterialSkin.MouseState.OUT;
            this.Listview_Menu.Name = "Listview_Menu";
            this.Listview_Menu.OwnerDraw = true;
            this.Listview_Menu.Size = new System.Drawing.Size(1292, 359);
            this.Listview_Menu.TabIndex = 3;
            this.Listview_Menu.UseCompatibleStateImageBehavior = false;
            this.Listview_Menu.View = System.Windows.Forms.View.Details;
            // 
            // Menu_Id
            // 
            this.Menu_Id.Text = "Id";
            this.Menu_Id.Width = 90;
            // 
            // Menu_Name
            // 
            this.Menu_Name.Text = "Naam";
            this.Menu_Name.Width = 250;
            // 
            // Menu_Description
            // 
            this.Menu_Description.Text = "Beschrijving";
            this.Menu_Description.Width = 450;
            // 
            // Menu_Type
            // 
            this.Menu_Type.Text = "Type";
            this.Menu_Type.Width = 100;
            // 
            // Menu_Price
            // 
            this.Menu_Price.Text = "Prijs";
            this.Menu_Price.Width = 100;
            // 
            // Menu_Status
            // 
            this.Menu_Status.Text = "Beschikbaar";
            this.Menu_Status.Width = 120;
            // 
            // Maaltijden_Form_Verwijderen_Btn
            // 
            this.Maaltijden_Form_Verwijderen_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Maaltijden_Form_Verwijderen_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Maaltijden_Form_Verwijderen_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Maaltijden_Form_Verwijderen_Btn.Depth = 0;
            this.Maaltijden_Form_Verwijderen_Btn.HighEmphasis = true;
            this.Maaltijden_Form_Verwijderen_Btn.Icon = null;
            this.Maaltijden_Form_Verwijderen_Btn.Location = new System.Drawing.Point(1179, 443);
            this.Maaltijden_Form_Verwijderen_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Maaltijden_Form_Verwijderen_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Maaltijden_Form_Verwijderen_Btn.Name = "Maaltijden_Form_Verwijderen_Btn";
            this.Maaltijden_Form_Verwijderen_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Maaltijden_Form_Verwijderen_Btn.Size = new System.Drawing.Size(120, 36);
            this.Maaltijden_Form_Verwijderen_Btn.TabIndex = 2;
            this.Maaltijden_Form_Verwijderen_Btn.Text = "Verwijderen";
            this.Maaltijden_Form_Verwijderen_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Maaltijden_Form_Verwijderen_Btn.UseAccentColor = false;
            this.Maaltijden_Form_Verwijderen_Btn.UseVisualStyleBackColor = true;
            this.Maaltijden_Form_Verwijderen_Btn.Click += new System.EventHandler(this.Maaltijden_Form_Verwijderen_Btn_Click);
            // 
            // Maaltijden_Form_Wijzigen_Btn
            // 
            this.Maaltijden_Form_Wijzigen_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Maaltijden_Form_Wijzigen_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Maaltijden_Form_Wijzigen_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Maaltijden_Form_Wijzigen_Btn.Depth = 0;
            this.Maaltijden_Form_Wijzigen_Btn.HighEmphasis = true;
            this.Maaltijden_Form_Wijzigen_Btn.Icon = null;
            this.Maaltijden_Form_Wijzigen_Btn.Location = new System.Drawing.Point(976, 443);
            this.Maaltijden_Form_Wijzigen_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Maaltijden_Form_Wijzigen_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Maaltijden_Form_Wijzigen_Btn.Name = "Maaltijden_Form_Wijzigen_Btn";
            this.Maaltijden_Form_Wijzigen_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Maaltijden_Form_Wijzigen_Btn.Size = new System.Drawing.Size(89, 36);
            this.Maaltijden_Form_Wijzigen_Btn.TabIndex = 1;
            this.Maaltijden_Form_Wijzigen_Btn.Text = "Wijzigen";
            this.Maaltijden_Form_Wijzigen_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Maaltijden_Form_Wijzigen_Btn.UseAccentColor = false;
            this.Maaltijden_Form_Wijzigen_Btn.UseVisualStyleBackColor = true;
            this.Maaltijden_Form_Wijzigen_Btn.Click += new System.EventHandler(this.Maaltijden_Form_Wijzigen_Btn_Click);
            // 
            // Maaltijden_Form_Toevoegen_Btn
            // 
            this.Maaltijden_Form_Toevoegen_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Maaltijden_Form_Toevoegen_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Maaltijden_Form_Toevoegen_Btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Maaltijden_Form_Toevoegen_Btn.Depth = 0;
            this.Maaltijden_Form_Toevoegen_Btn.HighEmphasis = true;
            this.Maaltijden_Form_Toevoegen_Btn.Icon = null;
            this.Maaltijden_Form_Toevoegen_Btn.Location = new System.Drawing.Point(21, 443);
            this.Maaltijden_Form_Toevoegen_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Maaltijden_Form_Toevoegen_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Maaltijden_Form_Toevoegen_Btn.Name = "Maaltijden_Form_Toevoegen_Btn";
            this.Maaltijden_Form_Toevoegen_Btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Maaltijden_Form_Toevoegen_Btn.Size = new System.Drawing.Size(106, 36);
            this.Maaltijden_Form_Toevoegen_Btn.TabIndex = 0;
            this.Maaltijden_Form_Toevoegen_Btn.Text = "Toevoegen";
            this.Maaltijden_Form_Toevoegen_Btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Maaltijden_Form_Toevoegen_Btn.UseAccentColor = false;
            this.Maaltijden_Form_Toevoegen_Btn.UseVisualStyleBackColor = true;
            this.Maaltijden_Form_Toevoegen_Btn.Click += new System.EventHandler(this.Maaltijden_Form_Toevoegen_Btn_Click);
            // 
            // BestellingenTab
            // 
            this.BestellingenTab.ImageKey = "truck-32.png";
            this.BestellingenTab.Location = new System.Drawing.Point(4, 39);
            this.BestellingenTab.Margin = new System.Windows.Forms.Padding(4);
            this.BestellingenTab.Name = "BestellingenTab";
            this.BestellingenTab.Size = new System.Drawing.Size(1317, 489);
            this.BestellingenTab.TabIndex = 2;
            this.BestellingenTab.Text = "Bestellingen";
            this.BestellingenTab.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rice-32.png");
            this.imageList1.Images.SetKeyName(1, "truck-32.png");
            this.imageList1.Images.SetKeyName(2, "user-32.png");
            this.imageList1.Images.SetKeyName(3, "home-32.png");
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.MaaltijdTab.ResumeLayout(false);
            this.MaaltijdTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage GebruikersTab;
        private System.Windows.Forms.TabPage MaaltijdTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage BestellingenTab;
        private System.Windows.Forms.TabPage HomeTab;
        private MaterialSkin.Controls.MaterialButton Maaltijden_Form_Toevoegen_Btn;
        private MaterialSkin.Controls.MaterialButton Maaltijden_Form_Verwijderen_Btn;
        private MaterialSkin.Controls.MaterialButton Maaltijden_Form_Wijzigen_Btn;
        private MaterialSkin.Controls.MaterialListView Listview_Menu;
        private System.Windows.Forms.ColumnHeader Menu_Name;
        private System.Windows.Forms.ColumnHeader Menu_Description;
        private System.Windows.Forms.ColumnHeader Menu_Type;
        private System.Windows.Forms.ColumnHeader Menu_Price;
        private System.Windows.Forms.ColumnHeader Menu_Status;
        private System.Windows.Forms.ColumnHeader Menu_Id;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}


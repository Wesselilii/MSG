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
            this.gebruikerDeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.gebruikerEditButton = new MaterialSkin.Controls.MaterialButton();
            this.gebruikerCreateButton = new MaterialSkin.Controls.MaterialButton();
            this.gebruikerLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.gebruikerListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaaltijdTab = new System.Windows.Forms.TabPage();
            this.BestellingenTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.GebruikersTab.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 433);
            this.materialTabControl1.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.ImageKey = "home-32.png";
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(986, 390);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // GebruikersTab
            // 
            this.GebruikersTab.Controls.Add(this.gebruikerDeleteButton);
            this.GebruikersTab.Controls.Add(this.gebruikerEditButton);
            this.GebruikersTab.Controls.Add(this.gebruikerCreateButton);
            this.GebruikersTab.Controls.Add(this.gebruikerLabel1);
            this.GebruikersTab.Controls.Add(this.gebruikerListView1);
            this.GebruikersTab.ImageKey = "user-32.png";
            this.GebruikersTab.Location = new System.Drawing.Point(4, 39);
            this.GebruikersTab.Name = "GebruikersTab";
            this.GebruikersTab.Padding = new System.Windows.Forms.Padding(3);
            this.GebruikersTab.Size = new System.Drawing.Size(986, 390);
            this.GebruikersTab.TabIndex = 0;
            this.GebruikersTab.Text = "Gebruikers";
            this.GebruikersTab.UseVisualStyleBackColor = true;
            // 
            // gebruikerDeleteButton
            // 
            this.gebruikerDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerDeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gebruikerDeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gebruikerDeleteButton.Depth = 0;
            this.gebruikerDeleteButton.HighEmphasis = true;
            this.gebruikerDeleteButton.Icon = null;
            this.gebruikerDeleteButton.Location = new System.Drawing.Point(833, 346);
            this.gebruikerDeleteButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gebruikerDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gebruikerDeleteButton.Name = "gebruikerDeleteButton";
            this.gebruikerDeleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gebruikerDeleteButton.Size = new System.Drawing.Size(120, 36);
            this.gebruikerDeleteButton.TabIndex = 4;
            this.gebruikerDeleteButton.Text = "Verwijderen";
            this.gebruikerDeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gebruikerDeleteButton.UseAccentColor = false;
            this.gebruikerDeleteButton.UseVisualStyleBackColor = true;
            this.gebruikerDeleteButton.Click += new System.EventHandler(this.gebruikerDeleteButton_Click);
            // 
            // gebruikerEditButton
            // 
            this.gebruikerEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerEditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gebruikerEditButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gebruikerEditButton.Depth = 0;
            this.gebruikerEditButton.HighEmphasis = true;
            this.gebruikerEditButton.Icon = null;
            this.gebruikerEditButton.Location = new System.Drawing.Point(700, 346);
            this.gebruikerEditButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gebruikerEditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gebruikerEditButton.Name = "gebruikerEditButton";
            this.gebruikerEditButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gebruikerEditButton.Size = new System.Drawing.Size(107, 36);
            this.gebruikerEditButton.TabIndex = 3;
            this.gebruikerEditButton.Text = "Aanpassen";
            this.gebruikerEditButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gebruikerEditButton.UseAccentColor = false;
            this.gebruikerEditButton.UseVisualStyleBackColor = true;
            this.gebruikerEditButton.Click += new System.EventHandler(this.gebruikerEditButton_Click);
            // 
            // gebruikerCreateButton
            // 
            this.gebruikerCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gebruikerCreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gebruikerCreateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.gebruikerCreateButton.Depth = 0;
            this.gebruikerCreateButton.HighEmphasis = true;
            this.gebruikerCreateButton.Icon = null;
            this.gebruikerCreateButton.Location = new System.Drawing.Point(15, 346);
            this.gebruikerCreateButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gebruikerCreateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.gebruikerCreateButton.Name = "gebruikerCreateButton";
            this.gebruikerCreateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.gebruikerCreateButton.Size = new System.Drawing.Size(106, 36);
            this.gebruikerCreateButton.TabIndex = 2;
            this.gebruikerCreateButton.Text = "Toevoegen";
            this.gebruikerCreateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.gebruikerCreateButton.UseAccentColor = false;
            this.gebruikerCreateButton.UseVisualStyleBackColor = true;
            this.gebruikerCreateButton.Click += new System.EventHandler(this.gebruikerCreateButton_Click);
            // 
            // gebruikerLabel1
            // 
            this.gebruikerLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerLabel1.AutoSize = true;
            this.gebruikerLabel1.Depth = 0;
            this.gebruikerLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gebruikerLabel1.Location = new System.Drawing.Point(13, 13);
            this.gebruikerLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gebruikerLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.gebruikerLabel1.Name = "gebruikerLabel1";
            this.gebruikerLabel1.Size = new System.Drawing.Size(136, 19);
            this.gebruikerLabel1.TabIndex = 1;
            this.gebruikerLabel1.Text = "Gebruiker overzicht";
            // 
            // gebruikerListView1
            // 
            this.gebruikerListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gebruikerListView1.AutoSizeTable = false;
            this.gebruikerListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gebruikerListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gebruikerListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.gebruikerListView1.Depth = 0;
            this.gebruikerListView1.FullRowSelect = true;
            this.gebruikerListView1.HideSelection = false;
            this.gebruikerListView1.Location = new System.Drawing.Point(5, 46);
            this.gebruikerListView1.Margin = new System.Windows.Forms.Padding(2);
            this.gebruikerListView1.MinimumSize = new System.Drawing.Size(150, 81);
            this.gebruikerListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.gebruikerListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.gebruikerListView1.Name = "gebruikerListView1";
            this.gebruikerListView1.OwnerDraw = true;
            this.gebruikerListView1.Size = new System.Drawing.Size(977, 285);
            this.gebruikerListView1.TabIndex = 0;
            this.gebruikerListView1.UseCompatibleStateImageBehavior = false;
            this.gebruikerListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voornaam";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Achternaam";
            this.columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 240;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rol";
            this.columnHeader5.Width = 180;
            // 
            // MaaltijdTab
            // 
            this.MaaltijdTab.ImageKey = "rice-32.png";
            this.MaaltijdTab.Location = new System.Drawing.Point(4, 39);
            this.MaaltijdTab.Name = "MaaltijdTab";
            this.MaaltijdTab.Padding = new System.Windows.Forms.Padding(3);
            this.MaaltijdTab.Size = new System.Drawing.Size(986, 390);
            this.MaaltijdTab.TabIndex = 1;
            this.MaaltijdTab.Text = "Maaltijden";
            this.MaaltijdTab.UseVisualStyleBackColor = true;
            // 
            // BestellingenTab
            // 
            this.BestellingenTab.ImageKey = "truck-32.png";
            this.BestellingenTab.Location = new System.Drawing.Point(4, 39);
            this.BestellingenTab.Name = "BestellingenTab";
            this.BestellingenTab.Size = new System.Drawing.Size(986, 390);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.GebruikersTab.ResumeLayout(false);
            this.GebruikersTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage GebruikersTab;
        private System.Windows.Forms.TabPage MaaltijdTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage BestellingenTab;
        private System.Windows.Forms.TabPage HomeTab;
        private MaterialSkin.Controls.MaterialListView gebruikerListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel gebruikerLabel1;
        private MaterialSkin.Controls.MaterialButton gebruikerDeleteButton;
        private MaterialSkin.Controls.MaterialButton gebruikerEditButton;
        private MaterialSkin.Controls.MaterialButton gebruikerCreateButton;
    }
}


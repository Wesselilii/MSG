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
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Dashboard_Welcome_Label = new MaterialSkin.Controls.MaterialLabel();
            this.GebruikersTab = new System.Windows.Forms.TabPage();
            this.MaaltijdTab = new System.Windows.Forms.TabPage();
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BestellingenTab = new System.Windows.Forms.TabPage();
            this.BestelATextbox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BestelAButton3 = new MaterialSkin.Controls.MaterialButton();
            this.BestelAButton2 = new MaterialSkin.Controls.MaterialButton();
            this.BestelAButton1 = new MaterialSkin.Controls.MaterialButton();
            this.BestelAListView1 = new MaterialSkin.Controls.MaterialListView();
            this.BestelAHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelAHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelAHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelAHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelAHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelACombobox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.BestelATextbox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelATextbox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelATextbox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelALabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.GBestellingenTab = new System.Windows.Forms.TabPage();
            this.BestelGTextbox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelGTextbox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelGTextbox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelGLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelGLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelGLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelGListView1 = new MaterialSkin.Controls.MaterialListView();
            this.BestelGHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelGHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelGHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelGHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestelGButton1 = new MaterialSkin.Controls.MaterialButton();
            this.BestelGTextbox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelGLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.HomeTab.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.MaaltijdTab.SuspendLayout();
            this.BestellingenTab.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.GBestellingenTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.materialCard1);
            this.HomeTab.ImageKey = "home-32.png";
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(984, 497);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Dashboard_Welcome_Label);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(300, 45);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.Size = new System.Drawing.Size(430, 121);
            this.materialCard1.TabIndex = 0;
            // 
            // Dashboard_Welcome_Label
            // 
            this.Dashboard_Welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard_Welcome_Label.Depth = 0;
            this.Dashboard_Welcome_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboard_Welcome_Label.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Dashboard_Welcome_Label.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.Dashboard_Welcome_Label.HighEmphasis = true;
            this.Dashboard_Welcome_Label.Location = new System.Drawing.Point(10, 11);
            this.Dashboard_Welcome_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dashboard_Welcome_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Dashboard_Welcome_Label.Name = "Dashboard_Welcome_Label";
            this.Dashboard_Welcome_Label.Size = new System.Drawing.Size(410, 99);
            this.Dashboard_Welcome_Label.TabIndex = 1;
            this.Dashboard_Welcome_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GebruikersTab
            // 
            this.GebruikersTab.ImageKey = "user-32.png";
            this.GebruikersTab.Location = new System.Drawing.Point(4, 39);
            this.GebruikersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GebruikersTab.Name = "GebruikersTab";
            this.GebruikersTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GebruikersTab.Size = new System.Drawing.Size(984, 497);
            this.GebruikersTab.TabIndex = 0;
            this.GebruikersTab.Text = "Gebruikers";
            this.GebruikersTab.UseVisualStyleBackColor = true;
            // 
            // MaaltijdTab
            // 
            this.MaaltijdTab.Controls.Add(this.Listview_Menu);
            this.MaaltijdTab.Controls.Add(this.Maaltijden_Form_Verwijderen_Btn);
            this.MaaltijdTab.Controls.Add(this.Maaltijden_Form_Wijzigen_Btn);
            this.MaaltijdTab.Controls.Add(this.Maaltijden_Form_Toevoegen_Btn);
            this.MaaltijdTab.ImageKey = "rice-32.png";
            this.MaaltijdTab.Location = new System.Drawing.Point(4, 39);
            this.MaaltijdTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaaltijdTab.Name = "MaaltijdTab";
            this.MaaltijdTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaaltijdTab.Size = new System.Drawing.Size(984, 497);
            this.MaaltijdTab.TabIndex = 1;
            this.MaaltijdTab.Text = "Maaltijden";
            this.MaaltijdTab.UseVisualStyleBackColor = true;
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
            this.Listview_Menu.Location = new System.Drawing.Point(4, 36);
            this.Listview_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Listview_Menu.MinimumSize = new System.Drawing.Size(150, 81);
            this.Listview_Menu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Listview_Menu.MouseState = MaterialSkin.MouseState.OUT;
            this.Listview_Menu.Name = "Listview_Menu";
            this.Listview_Menu.OwnerDraw = true;
            this.Listview_Menu.Size = new System.Drawing.Size(975, 366);
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
            this.Maaltijden_Form_Verwijderen_Btn.Location = new System.Drawing.Point(813, 440);
            this.Maaltijden_Form_Verwijderen_Btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.Maaltijden_Form_Wijzigen_Btn.Location = new System.Drawing.Point(690, 440);
            this.Maaltijden_Form_Wijzigen_Btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.Maaltijden_Form_Toevoegen_Btn.Location = new System.Drawing.Point(18, 440);
            this.Maaltijden_Form_Toevoegen_Btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rice-32.png");
            this.imageList1.Images.SetKeyName(1, "truck-32.png");
            this.imageList1.Images.SetKeyName(2, "user-32.png");
            this.imageList1.Images.SetKeyName(3, "home-32.png");
            this.imageList1.Images.SetKeyName(4, "package-32.png");
            // 
            // BestellingenTab
            // 
            this.BestellingenTab.Controls.Add(this.BestelATextbox4);
            this.BestellingenTab.Controls.Add(this.BestelADateTimePicker);
            this.BestellingenTab.Controls.Add(this.BestelAButton3);
            this.BestellingenTab.Controls.Add(this.BestelAButton2);
            this.BestellingenTab.Controls.Add(this.BestelAButton1);
            this.BestellingenTab.Controls.Add(this.BestelAListView1);
            this.BestellingenTab.Controls.Add(this.BestelACombobox1);
            this.BestellingenTab.Controls.Add(this.BestelATextbox3);
            this.BestellingenTab.Controls.Add(this.BestelATextbox2);
            this.BestellingenTab.Controls.Add(this.BestelATextbox1);
            this.BestellingenTab.Controls.Add(this.BestelALabel5);
            this.BestellingenTab.Controls.Add(this.BestelALabel4);
            this.BestellingenTab.Controls.Add(this.BestelALabel3);
            this.BestellingenTab.Controls.Add(this.BestelALabel2);
            this.BestellingenTab.Controls.Add(this.BestelALabel1);
            this.BestellingenTab.ImageKey = "truck-32.png";
            this.BestellingenTab.Location = new System.Drawing.Point(4, 39);
            this.BestellingenTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestellingenTab.Name = "BestellingenTab";
            this.BestellingenTab.Size = new System.Drawing.Size(984, 497);
            this.BestellingenTab.TabIndex = 2;
            this.BestellingenTab.Text = "Bestellingen";
            this.BestellingenTab.UseVisualStyleBackColor = true;
            // 
            // BestelATextbox4
            // 
            this.BestelATextbox4.AnimateReadOnly = false;
            this.BestelATextbox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelATextbox4.Depth = 0;
            this.BestelATextbox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelATextbox4.LeadingIcon = null;
            this.BestelATextbox4.Location = new System.Drawing.Point(20, 176);
            this.BestelATextbox4.Margin = new System.Windows.Forms.Padding(2);
            this.BestelATextbox4.MaxLength = 50;
            this.BestelATextbox4.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox4.Multiline = false;
            this.BestelATextbox4.Name = "BestelATextbox4";
            this.BestelATextbox4.Size = new System.Drawing.Size(172, 36);
            this.BestelATextbox4.TabIndex = 15;
            this.BestelATextbox4.Text = "";
            this.BestelATextbox4.TrailingIcon = null;
            this.BestelATextbox4.UseTallSize = false;
            // 
            // BestelADateTimePicker
            // 
            this.BestelADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BestelADateTimePicker.Location = new System.Drawing.Point(20, 244);
            this.BestelADateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.BestelADateTimePicker.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.BestelADateTimePicker.Name = "BestelADateTimePicker";
            this.BestelADateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BestelADateTimePicker.Size = new System.Drawing.Size(234, 20);
            this.BestelADateTimePicker.TabIndex = 14;
            // 
            // BestelAButton3
            // 
            this.BestelAButton3.AutoSize = false;
            this.BestelAButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BestelAButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BestelAButton3.Depth = 0;
            this.BestelAButton3.HighEmphasis = true;
            this.BestelAButton3.Icon = null;
            this.BestelAButton3.Location = new System.Drawing.Point(141, 391);
            this.BestelAButton3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BestelAButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelAButton3.Name = "BestelAButton3";
            this.BestelAButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelAButton3.Size = new System.Drawing.Size(109, 29);
            this.BestelAButton3.TabIndex = 13;
            this.BestelAButton3.Text = "Verwijderen";
            this.BestelAButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BestelAButton3.UseAccentColor = false;
            this.BestelAButton3.UseVisualStyleBackColor = true;
            this.BestelAButton3.Click += new System.EventHandler(this.BestelAButton3_Click);
            // 
            // BestelAButton2
            // 
            this.BestelAButton2.AutoSize = false;
            this.BestelAButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BestelAButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BestelAButton2.Depth = 0;
            this.BestelAButton2.HighEmphasis = true;
            this.BestelAButton2.Icon = null;
            this.BestelAButton2.Location = new System.Drawing.Point(20, 391);
            this.BestelAButton2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BestelAButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelAButton2.Name = "BestelAButton2";
            this.BestelAButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelAButton2.Size = new System.Drawing.Size(115, 29);
            this.BestelAButton2.TabIndex = 12;
            this.BestelAButton2.Text = "Toevoegen";
            this.BestelAButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BestelAButton2.UseAccentColor = false;
            this.BestelAButton2.UseVisualStyleBackColor = true;
            this.BestelAButton2.Click += new System.EventHandler(this.BestelAButton2_Click);
            // 
            // BestelAButton1
            // 
            this.BestelAButton1.AutoSize = false;
            this.BestelAButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BestelAButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BestelAButton1.Depth = 0;
            this.BestelAButton1.HighEmphasis = true;
            this.BestelAButton1.Icon = null;
            this.BestelAButton1.Location = new System.Drawing.Point(20, 345);
            this.BestelAButton1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BestelAButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelAButton1.Name = "BestelAButton1";
            this.BestelAButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelAButton1.Size = new System.Drawing.Size(230, 29);
            this.BestelAButton1.TabIndex = 11;
            this.BestelAButton1.Text = "Aanpassen";
            this.BestelAButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BestelAButton1.UseAccentColor = false;
            this.BestelAButton1.UseVisualStyleBackColor = true;
            this.BestelAButton1.Click += new System.EventHandler(this.BestelAButton1_Click);
            // 
            // BestelAListView1
            // 
            this.BestelAListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BestelAListView1.AutoSizeTable = false;
            this.BestelAListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BestelAListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelAListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BestelAHeader1,
            this.BestelAHeader2,
            this.BestelAHeader3,
            this.BestelAHeader4,
            this.BestelAHeader5});
            this.BestelAListView1.Depth = 0;
            this.BestelAListView1.FullRowSelect = true;
            this.BestelAListView1.HideSelection = false;
            this.BestelAListView1.Location = new System.Drawing.Point(271, 15);
            this.BestelAListView1.Margin = new System.Windows.Forms.Padding(2);
            this.BestelAListView1.MinimumSize = new System.Drawing.Size(562, 528);
            this.BestelAListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BestelAListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelAListView1.Name = "BestelAListView1";
            this.BestelAListView1.OwnerDraw = true;
            this.BestelAListView1.Size = new System.Drawing.Size(697, 528);
            this.BestelAListView1.TabIndex = 10;
            this.BestelAListView1.UseCompatibleStateImageBehavior = false;
            this.BestelAListView1.View = System.Windows.Forms.View.Details;
            this.BestelAListView1.Click += new System.EventHandler(this.BestelAListView1_SelectedIndexChanged);
            // 
            // BestelAHeader1
            // 
            this.BestelAHeader1.Text = "Bestellings Nr.";
            this.BestelAHeader1.Width = 125;
            // 
            // BestelAHeader2
            // 
            this.BestelAHeader2.Text = "Ontvanger";
            this.BestelAHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BestelAHeader2.Width = 150;
            // 
            // BestelAHeader3
            // 
            this.BestelAHeader3.Text = "Menu Nr.";
            this.BestelAHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BestelAHeader3.Width = 90;
            // 
            // BestelAHeader4
            // 
            this.BestelAHeader4.Text = "Datum";
            this.BestelAHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BestelAHeader4.Width = 90;
            // 
            // BestelAHeader5
            // 
            this.BestelAHeader5.Text = "Status";
            this.BestelAHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BestelAHeader5.Width = 110;
            // 
            // BestelACombobox1
            // 
            this.BestelACombobox1.AutoResize = false;
            this.BestelACombobox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BestelACombobox1.Depth = 0;
            this.BestelACombobox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BestelACombobox1.DropDownHeight = 118;
            this.BestelACombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BestelACombobox1.DropDownWidth = 121;
            this.BestelACombobox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelACombobox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BestelACombobox1.FormattingEnabled = true;
            this.BestelACombobox1.IntegralHeight = false;
            this.BestelACombobox1.ItemHeight = 29;
            this.BestelACombobox1.Items.AddRange(new object[] {
            "Actief",
            "Geannuleerd",
            "Betaald"});
            this.BestelACombobox1.Location = new System.Drawing.Point(20, 293);
            this.BestelACombobox1.Margin = new System.Windows.Forms.Padding(2);
            this.BestelACombobox1.MaxDropDownItems = 4;
            this.BestelACombobox1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelACombobox1.Name = "BestelACombobox1";
            this.BestelACombobox1.Size = new System.Drawing.Size(230, 35);
            this.BestelACombobox1.StartIndex = 0;
            this.BestelACombobox1.TabIndex = 9;
            this.BestelACombobox1.UseTallSize = false;
            // 
            // BestelATextbox3
            // 
            this.BestelATextbox3.AnimateReadOnly = false;
            this.BestelATextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelATextbox3.Depth = 0;
            this.BestelATextbox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelATextbox3.LeadingIcon = null;
            this.BestelATextbox3.Location = new System.Drawing.Point(130, 106);
            this.BestelATextbox3.Margin = new System.Windows.Forms.Padding(2);
            this.BestelATextbox3.MaxLength = 50;
            this.BestelATextbox3.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox3.Multiline = false;
            this.BestelATextbox3.Name = "BestelATextbox3";
            this.BestelATextbox3.Size = new System.Drawing.Size(122, 36);
            this.BestelATextbox3.TabIndex = 7;
            this.BestelATextbox3.Text = "";
            this.BestelATextbox3.TrailingIcon = null;
            this.BestelATextbox3.UseTallSize = false;
            // 
            // BestelATextbox2
            // 
            this.BestelATextbox2.AnimateReadOnly = false;
            this.BestelATextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelATextbox2.Depth = 0;
            this.BestelATextbox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelATextbox2.LeadingIcon = null;
            this.BestelATextbox2.Location = new System.Drawing.Point(22, 106);
            this.BestelATextbox2.Margin = new System.Windows.Forms.Padding(2);
            this.BestelATextbox2.MaxLength = 50;
            this.BestelATextbox2.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox2.Multiline = false;
            this.BestelATextbox2.Name = "BestelATextbox2";
            this.BestelATextbox2.Size = new System.Drawing.Size(104, 36);
            this.BestelATextbox2.TabIndex = 6;
            this.BestelATextbox2.Text = "";
            this.BestelATextbox2.TrailingIcon = null;
            this.BestelATextbox2.UseTallSize = false;
            // 
            // BestelATextbox1
            // 
            this.BestelATextbox1.AnimateReadOnly = false;
            this.BestelATextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelATextbox1.Depth = 0;
            this.BestelATextbox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelATextbox1.LeadingIcon = null;
            this.BestelATextbox1.Location = new System.Drawing.Point(22, 36);
            this.BestelATextbox1.Margin = new System.Windows.Forms.Padding(2);
            this.BestelATextbox1.MaxLength = 50;
            this.BestelATextbox1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox1.Multiline = false;
            this.BestelATextbox1.Name = "BestelATextbox1";
            this.BestelATextbox1.Size = new System.Drawing.Size(230, 36);
            this.BestelATextbox1.TabIndex = 5;
            this.BestelATextbox1.Text = "";
            this.BestelATextbox1.TrailingIcon = null;
            this.BestelATextbox1.UseTallSize = false;
            // 
            // BestelALabel5
            // 
            this.BestelALabel5.AutoSize = true;
            this.BestelALabel5.Depth = 0;
            this.BestelALabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelALabel5.Location = new System.Drawing.Point(19, 276);
            this.BestelALabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelALabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelALabel5.Name = "BestelALabel5";
            this.BestelALabel5.Size = new System.Drawing.Size(128, 19);
            this.BestelALabel5.TabIndex = 4;
            this.BestelALabel5.Text = "Bestellings Status";
            // 
            // BestelALabel4
            // 
            this.BestelALabel4.AutoSize = true;
            this.BestelALabel4.Depth = 0;
            this.BestelALabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelALabel4.Location = new System.Drawing.Point(21, 222);
            this.BestelALabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelALabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelALabel4.Name = "BestelALabel4";
            this.BestelALabel4.Size = new System.Drawing.Size(130, 19);
            this.BestelALabel4.TabIndex = 3;
            this.BestelALabel4.Text = "Bestellings Datum";
            // 
            // BestelALabel3
            // 
            this.BestelALabel3.AutoSize = true;
            this.BestelALabel3.Depth = 0;
            this.BestelALabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelALabel3.Location = new System.Drawing.Point(19, 155);
            this.BestelALabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelALabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelALabel3.Name = "BestelALabel3";
            this.BestelALabel3.Size = new System.Drawing.Size(106, 19);
            this.BestelALabel3.TabIndex = 2;
            this.BestelALabel3.Text = "Gekozen Menu";
            // 
            // BestelALabel2
            // 
            this.BestelALabel2.AutoSize = true;
            this.BestelALabel2.Depth = 0;
            this.BestelALabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelALabel2.Location = new System.Drawing.Point(21, 84);
            this.BestelALabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelALabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelALabel2.Name = "BestelALabel2";
            this.BestelALabel2.Size = new System.Drawing.Size(74, 19);
            this.BestelALabel2.TabIndex = 1;
            this.BestelALabel2.Text = "Ontvanger";
            // 
            // BestelALabel1
            // 
            this.BestelALabel1.AutoSize = true;
            this.BestelALabel1.Depth = 0;
            this.BestelALabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelALabel1.Location = new System.Drawing.Point(21, 15);
            this.BestelALabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelALabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelALabel1.Name = "BestelALabel1";
            this.BestelALabel1.Size = new System.Drawing.Size(143, 19);
            this.BestelALabel1.TabIndex = 0;
            this.BestelALabel1.Text = "Bestellings Nummer";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.HomeTab);
            this.materialTabControl1.Controls.Add(this.GebruikersTab);
            this.materialTabControl1.Controls.Add(this.MaaltijdTab);
            this.materialTabControl1.Controls.Add(this.BestellingenTab);
            this.materialTabControl1.Controls.Add(this.GBestellingenTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 79);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(992, 540);
            this.materialTabControl1.TabIndex = 0;
            // 
            // GBestellingenTab
            // 
            this.GBestellingenTab.Controls.Add(this.BestelGTextbox4);
            this.GBestellingenTab.Controls.Add(this.BestelGTextbox3);
            this.GBestellingenTab.Controls.Add(this.BestelGTextbox2);
            this.GBestellingenTab.Controls.Add(this.BestelGLabel4);
            this.GBestellingenTab.Controls.Add(this.BestelGLabel3);
            this.GBestellingenTab.Controls.Add(this.BestelGLabel2);
            this.GBestellingenTab.Controls.Add(this.BestelGListView1);
            this.GBestellingenTab.Controls.Add(this.BestelGButton1);
            this.GBestellingenTab.Controls.Add(this.BestelGTextbox1);
            this.GBestellingenTab.Controls.Add(this.BestelGLabel1);
            this.GBestellingenTab.ImageKey = "package-32.png";
            this.GBestellingenTab.Location = new System.Drawing.Point(4, 39);
            this.GBestellingenTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBestellingenTab.Name = "GBestellingenTab";
            this.GBestellingenTab.Size = new System.Drawing.Size(984, 497);
            this.GBestellingenTab.TabIndex = 4;
            this.GBestellingenTab.Text = "Bestellen";
            this.GBestellingenTab.UseVisualStyleBackColor = true;
            // 
            // BestelGTextbox4
            // 
            this.BestelGTextbox4.AnimateReadOnly = false;
            this.BestelGTextbox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelGTextbox4.Depth = 0;
            this.BestelGTextbox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGTextbox4.LeadingIcon = null;
            this.BestelGTextbox4.Location = new System.Drawing.Point(25, 213);
            this.BestelGTextbox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelGTextbox4.MaxLength = 50;
            this.BestelGTextbox4.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelGTextbox4.Multiline = false;
            this.BestelGTextbox4.Name = "BestelGTextbox4";
            this.BestelGTextbox4.Size = new System.Drawing.Size(216, 36);
            this.BestelGTextbox4.TabIndex = 9;
            this.BestelGTextbox4.Text = "";
            this.BestelGTextbox4.TrailingIcon = null;
            this.BestelGTextbox4.UseTallSize = false;
            // 
            // BestelGTextbox3
            // 
            this.BestelGTextbox3.AnimateReadOnly = false;
            this.BestelGTextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelGTextbox3.Depth = 0;
            this.BestelGTextbox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGTextbox3.LeadingIcon = null;
            this.BestelGTextbox3.Location = new System.Drawing.Point(25, 154);
            this.BestelGTextbox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelGTextbox3.MaxLength = 50;
            this.BestelGTextbox3.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelGTextbox3.Multiline = false;
            this.BestelGTextbox3.Name = "BestelGTextbox3";
            this.BestelGTextbox3.Size = new System.Drawing.Size(216, 36);
            this.BestelGTextbox3.TabIndex = 8;
            this.BestelGTextbox3.Text = "";
            this.BestelGTextbox3.TrailingIcon = null;
            this.BestelGTextbox3.UseTallSize = false;
            // 
            // BestelGTextbox2
            // 
            this.BestelGTextbox2.AnimateReadOnly = false;
            this.BestelGTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelGTextbox2.Depth = 0;
            this.BestelGTextbox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGTextbox2.LeadingIcon = null;
            this.BestelGTextbox2.Location = new System.Drawing.Point(25, 95);
            this.BestelGTextbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelGTextbox2.MaxLength = 50;
            this.BestelGTextbox2.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelGTextbox2.Multiline = false;
            this.BestelGTextbox2.Name = "BestelGTextbox2";
            this.BestelGTextbox2.Size = new System.Drawing.Size(216, 36);
            this.BestelGTextbox2.TabIndex = 7;
            this.BestelGTextbox2.Text = "";
            this.BestelGTextbox2.TrailingIcon = null;
            this.BestelGTextbox2.UseTallSize = false;
            // 
            // BestelGLabel4
            // 
            this.BestelGLabel4.AutoSize = true;
            this.BestelGLabel4.Depth = 0;
            this.BestelGLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGLabel4.Location = new System.Drawing.Point(22, 195);
            this.BestelGLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelGLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelGLabel4.Name = "BestelGLabel4";
            this.BestelGLabel4.Size = new System.Drawing.Size(87, 19);
            this.BestelGLabel4.TabIndex = 6;
            this.BestelGLabel4.Text = "Beschrijving";
            // 
            // BestelGLabel3
            // 
            this.BestelGLabel3.AutoSize = true;
            this.BestelGLabel3.Depth = 0;
            this.BestelGLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGLabel3.Location = new System.Drawing.Point(22, 136);
            this.BestelGLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelGLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelGLabel3.Name = "BestelGLabel3";
            this.BestelGLabel3.Size = new System.Drawing.Size(32, 19);
            this.BestelGLabel3.TabIndex = 5;
            this.BestelGLabel3.Text = "Prijs";
            // 
            // BestelGLabel2
            // 
            this.BestelGLabel2.AutoSize = true;
            this.BestelGLabel2.Depth = 0;
            this.BestelGLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGLabel2.Location = new System.Drawing.Point(22, 77);
            this.BestelGLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelGLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelGLabel2.Name = "BestelGLabel2";
            this.BestelGLabel2.Size = new System.Drawing.Size(36, 19);
            this.BestelGLabel2.TabIndex = 4;
            this.BestelGLabel2.Text = "Type";
            // 
            // BestelGListView1
            // 
            this.BestelGListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BestelGListView1.AutoSizeTable = false;
            this.BestelGListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BestelGListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelGListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BestelGHeader1,
            this.BestelGHeader2,
            this.BestelGHeader3,
            this.BestelGHeader4});
            this.BestelGListView1.Depth = 0;
            this.BestelGListView1.FullRowSelect = true;
            this.BestelGListView1.HideSelection = false;
            this.BestelGListView1.Location = new System.Drawing.Point(260, 16);
            this.BestelGListView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelGListView1.MinimumSize = new System.Drawing.Size(150, 81);
            this.BestelGListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BestelGListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelGListView1.Name = "BestelGListView1";
            this.BestelGListView1.OwnerDraw = true;
            this.BestelGListView1.Size = new System.Drawing.Size(708, 467);
            this.BestelGListView1.TabIndex = 3;
            this.BestelGListView1.UseCompatibleStateImageBehavior = false;
            this.BestelGListView1.View = System.Windows.Forms.View.Details;
            this.BestelGListView1.Click += new System.EventHandler(this.BestelGListView1_SelectedIndexChanged);
            // 
            // BestelGHeader1
            // 
            this.BestelGHeader1.Text = "Menu";
            this.BestelGHeader1.Width = 110;
            // 
            // BestelGHeader2
            // 
            this.BestelGHeader2.Text = "Type";
            this.BestelGHeader2.Width = 80;
            // 
            // BestelGHeader3
            // 
            this.BestelGHeader3.Text = "Prijs";
            this.BestelGHeader3.Width = 80;
            // 
            // BestelGHeader4
            // 
            this.BestelGHeader4.Text = "Beschrijving";
            this.BestelGHeader4.Width = 200;
            // 
            // BestelGButton1
            // 
            this.BestelGButton1.AutoSize = false;
            this.BestelGButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BestelGButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BestelGButton1.Depth = 0;
            this.BestelGButton1.HighEmphasis = true;
            this.BestelGButton1.Icon = null;
            this.BestelGButton1.Location = new System.Drawing.Point(24, 301);
            this.BestelGButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BestelGButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelGButton1.Name = "BestelGButton1";
            this.BestelGButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelGButton1.Size = new System.Drawing.Size(217, 70);
            this.BestelGButton1.TabIndex = 2;
            this.BestelGButton1.Text = "Bestelling Toevoegen";
            this.BestelGButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BestelGButton1.UseAccentColor = false;
            this.BestelGButton1.UseVisualStyleBackColor = true;
            // 
            // BestelGTextbox1
            // 
            this.BestelGTextbox1.AnimateReadOnly = false;
            this.BestelGTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelGTextbox1.Depth = 0;
            this.BestelGTextbox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGTextbox1.LeadingIcon = null;
            this.BestelGTextbox1.Location = new System.Drawing.Point(25, 34);
            this.BestelGTextbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelGTextbox1.MaxLength = 50;
            this.BestelGTextbox1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelGTextbox1.Multiline = false;
            this.BestelGTextbox1.Name = "BestelGTextbox1";
            this.BestelGTextbox1.Size = new System.Drawing.Size(216, 36);
            this.BestelGTextbox1.TabIndex = 1;
            this.BestelGTextbox1.Text = "";
            this.BestelGTextbox1.TrailingIcon = null;
            this.BestelGTextbox1.UseTallSize = false;
            // 
            // BestelGLabel1
            // 
            this.BestelGLabel1.AutoSize = true;
            this.BestelGLabel1.Depth = 0;
            this.BestelGLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelGLabel1.Location = new System.Drawing.Point(22, 16);
            this.BestelGLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelGLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelGLabel1.Name = "BestelGLabel1";
            this.BestelGLabel1.Size = new System.Drawing.Size(41, 19);
            this.BestelGLabel1.TabIndex = 0;
            this.BestelGLabel1.Text = "Menu";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 623);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.HomeTab.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.MaaltijdTab.ResumeLayout(false);
            this.MaaltijdTab.PerformLayout();
            this.BestellingenTab.ResumeLayout(false);
            this.BestellingenTab.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.GBestellingenTab.ResumeLayout(false);
            this.GBestellingenTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage BestellingenTab;
        private MaterialSkin.Controls.MaterialButton BestelAButton3;
        private MaterialSkin.Controls.MaterialButton BestelAButton2;
        private MaterialSkin.Controls.MaterialButton BestelAButton1;
        private MaterialSkin.Controls.MaterialListView BestelAListView1;
        private System.Windows.Forms.ColumnHeader BestelAHeader1;
        private System.Windows.Forms.ColumnHeader BestelAHeader2;
        private System.Windows.Forms.ColumnHeader BestelAHeader3;
        private System.Windows.Forms.ColumnHeader BestelAHeader4;
        private System.Windows.Forms.ColumnHeader BestelAHeader5;
        private MaterialSkin.Controls.MaterialComboBox BestelACombobox1;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox3;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox2;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox1;
        private MaterialSkin.Controls.MaterialLabel BestelALabel5;
        private MaterialSkin.Controls.MaterialLabel BestelALabel4;
        private MaterialSkin.Controls.MaterialLabel BestelALabel3;
        private MaterialSkin.Controls.MaterialLabel BestelALabel2;
        private MaterialSkin.Controls.MaterialLabel BestelALabel1;
        private System.Windows.Forms.TabPage MaaltijdTab;
        private System.Windows.Forms.TabPage GebruikersTab;
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
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.DateTimePicker BestelADateTimePicker;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel Dashboard_Welcome_Label;
        private System.Windows.Forms.TabPage GBestellingenTab;
        private MaterialSkin.Controls.MaterialTextBox BestelGTextbox1;
        private MaterialSkin.Controls.MaterialLabel BestelGLabel1;
        private MaterialSkin.Controls.MaterialButton BestelGButton1;
        private MaterialSkin.Controls.MaterialListView BestelGListView1;
        private System.Windows.Forms.ColumnHeader BestelGHeader1;
        private System.Windows.Forms.ColumnHeader BestelGHeader2;
        private System.Windows.Forms.ColumnHeader BestelGHeader3;
        private System.Windows.Forms.ColumnHeader BestelGHeader4;
        private MaterialSkin.Controls.MaterialLabel BestelGLabel4;
        private MaterialSkin.Controls.MaterialLabel BestelGLabel3;
        private MaterialSkin.Controls.MaterialLabel BestelGLabel2;
        private MaterialSkin.Controls.MaterialTextBox BestelGTextbox4;
        private MaterialSkin.Controls.MaterialTextBox BestelGTextbox3;
        private MaterialSkin.Controls.MaterialTextBox BestelGTextbox2;
    }
}




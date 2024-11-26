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
            this.BestellingenTab = new System.Windows.Forms.TabPage();
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
            this.BestelATextbox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelATextbox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelATextbox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelATextbox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.BestelALabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BestelALabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BestellingenGebruikerTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.BestellingenTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.HomeTab);
            this.materialTabControl1.Controls.Add(this.GebruikersTab);
            this.materialTabControl1.Controls.Add(this.MaaltijdTab);
            this.materialTabControl1.Controls.Add(this.BestellingenTab);
            this.materialTabControl1.Controls.Add(this.BestellingenGebruikerTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 556);
            this.materialTabControl1.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.ImageKey = "home-32.png";
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(986, 390);
            this.HomeTab.TabIndex = 3;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // GebruikersTab
            // 
            this.GebruikersTab.ImageKey = "user-32.png";
            this.GebruikersTab.Location = new System.Drawing.Point(4, 39);
            this.GebruikersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GebruikersTab.Name = "GebruikersTab";
            this.GebruikersTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GebruikersTab.Size = new System.Drawing.Size(1428, 780);
            this.GebruikersTab.TabIndex = 0;
            this.GebruikersTab.Text = "Gebruikers";
            this.GebruikersTab.UseVisualStyleBackColor = true;
            // 
            // MaaltijdTab
            // 
            this.MaaltijdTab.ImageKey = "rice-32.png";
            this.MaaltijdTab.Location = new System.Drawing.Point(4, 39);
            this.MaaltijdTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaaltijdTab.Name = "MaaltijdTab";
            this.MaaltijdTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaaltijdTab.Size = new System.Drawing.Size(1428, 780);
            this.MaaltijdTab.TabIndex = 1;
            this.MaaltijdTab.Text = "Maaltijden";
            this.MaaltijdTab.UseVisualStyleBackColor = true;
            // 
            // BestellingenTab
            // 
            this.BestellingenTab.Controls.Add(this.BestelAButton3);
            this.BestellingenTab.Controls.Add(this.BestelAButton2);
            this.BestellingenTab.Controls.Add(this.BestelAButton1);
            this.BestellingenTab.Controls.Add(this.BestelAListView1);
            this.BestellingenTab.Controls.Add(this.BestelACombobox1);
            this.BestellingenTab.Controls.Add(this.BestelATextbox4);
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
            this.BestellingenTab.Size = new System.Drawing.Size(986, 513);
            this.BestellingenTab.TabIndex = 2;
            this.BestellingenTab.Text = "Bestellingen";
            this.BestellingenTab.UseVisualStyleBackColor = true;
            // 
            // BestelAButton3
            // 
            this.BestelAButton3.AutoSize = false;
            this.BestelAButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BestelAButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BestelAButton3.Depth = 0;
            this.BestelAButton3.HighEmphasis = true;
            this.BestelAButton3.Icon = null;
            this.BestelAButton3.Location = new System.Drawing.Point(158, 392);
            this.BestelAButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BestelAButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelAButton3.Name = "BestelAButton3";
            this.BestelAButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelAButton3.Size = new System.Drawing.Size(94, 29);
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
            this.BestelAButton2.Location = new System.Drawing.Point(57, 392);
            this.BestelAButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BestelAButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelAButton2.Name = "BestelAButton2";
            this.BestelAButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelAButton2.Size = new System.Drawing.Size(95, 29);
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
            this.BestelAButton1.Location = new System.Drawing.Point(57, 342);
            this.BestelAButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BestelAButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelAButton1.Name = "BestelAButton1";
            this.BestelAButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BestelAButton1.Size = new System.Drawing.Size(195, 29);
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
            this.BestelAListView1.Location = new System.Drawing.Point(291, 20);
            this.BestelAListView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelAListView1.MinimumSize = new System.Drawing.Size(750, 650);
            this.BestelAListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BestelAListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelAListView1.Name = "BestelAListView1";
            this.BestelAListView1.OwnerDraw = true;
            this.BestelAListView1.Size = new System.Drawing.Size(1125, 752);
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
            this.BestelACombobox1.Location = new System.Drawing.Point(57, 288);
            this.BestelACombobox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelACombobox1.MaxDropDownItems = 4;
            this.BestelACombobox1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelACombobox1.Name = "BestelACombobox1";
            this.BestelACombobox1.Size = new System.Drawing.Size(196, 35);
            this.BestelACombobox1.StartIndex = 0;
            this.BestelACombobox1.TabIndex = 9;
            this.BestelACombobox1.UseTallSize = false;
            // 
            // BestelATextbox4
            // 
            this.BestelATextbox4.AnimateReadOnly = false;
            this.BestelATextbox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelATextbox4.Depth = 0;
            this.BestelATextbox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelATextbox4.LeadingIcon = null;
            this.BestelATextbox4.Location = new System.Drawing.Point(57, 227);
            this.BestelATextbox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelATextbox4.MaxLength = 50;
            this.BestelATextbox4.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox4.Multiline = false;
            this.BestelATextbox4.Name = "BestelATextbox4";
            this.BestelATextbox4.Size = new System.Drawing.Size(195, 36);
            this.BestelATextbox4.TabIndex = 8;
            this.BestelATextbox4.Text = "";
            this.BestelATextbox4.TrailingIcon = null;
            this.BestelATextbox4.UseTallSize = false;
            // 
            // BestelATextbox3
            // 
            this.BestelATextbox3.AnimateReadOnly = false;
            this.BestelATextbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BestelATextbox3.Depth = 0;
            this.BestelATextbox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BestelATextbox3.LeadingIcon = null;
            this.BestelATextbox3.Location = new System.Drawing.Point(57, 162);
            this.BestelATextbox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelATextbox3.MaxLength = 50;
            this.BestelATextbox3.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox3.Multiline = false;
            this.BestelATextbox3.Name = "BestelATextbox3";
            this.BestelATextbox3.Size = new System.Drawing.Size(195, 36);
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
            this.BestelATextbox2.Location = new System.Drawing.Point(57, 101);
            this.BestelATextbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelATextbox2.MaxLength = 50;
            this.BestelATextbox2.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox2.Multiline = false;
            this.BestelATextbox2.Name = "BestelATextbox2";
            this.BestelATextbox2.Size = new System.Drawing.Size(195, 36);
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
            this.BestelATextbox1.Location = new System.Drawing.Point(57, 37);
            this.BestelATextbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestelATextbox1.MaxLength = 50;
            this.BestelATextbox1.MouseState = MaterialSkin.MouseState.OUT;
            this.BestelATextbox1.Multiline = false;
            this.BestelATextbox1.Name = "BestelATextbox1";
            this.BestelATextbox1.Size = new System.Drawing.Size(195, 36);
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
            this.BestelALabel5.Location = new System.Drawing.Point(55, 269);
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
            this.BestelALabel4.Location = new System.Drawing.Point(55, 209);
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
            this.BestelALabel3.Location = new System.Drawing.Point(55, 145);
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
            this.BestelALabel2.Location = new System.Drawing.Point(55, 83);
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
            this.BestelALabel1.Location = new System.Drawing.Point(55, 19);
            this.BestelALabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BestelALabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BestelALabel1.Name = "BestelALabel1";
            this.BestelALabel1.Size = new System.Drawing.Size(143, 19);
            this.BestelALabel1.TabIndex = 0;
            this.BestelALabel1.Text = "Bestellings Nummer";
            // 
            // BestellingenGebruikerTab
            // 
            this.BestellingenGebruikerTab.ImageKey = "truck-32.png";
            this.BestellingenGebruikerTab.Location = new System.Drawing.Point(4, 39);
            this.BestellingenGebruikerTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestellingenGebruikerTab.Name = "BestellingenGebruikerTab";
            this.BestellingenGebruikerTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestellingenGebruikerTab.Size = new System.Drawing.Size(1428, 780);
            this.BestellingenGebruikerTab.TabIndex = 4;
            this.BestellingenGebruikerTab.Text = "GBestellingen";
            this.BestellingenGebruikerTab.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(1000, 623);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.BestellingenTab.ResumeLayout(false);
            this.BestellingenTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage GebruikersTab;
        private System.Windows.Forms.TabPage MaaltijdTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage BestellingenTab;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage BestellingenGebruikerTab;
        private MaterialSkin.Controls.MaterialLabel BestelALabel5;
        private MaterialSkin.Controls.MaterialLabel BestelALabel4;
        private MaterialSkin.Controls.MaterialLabel BestelALabel3;
        private MaterialSkin.Controls.MaterialLabel BestelALabel2;
        private MaterialSkin.Controls.MaterialLabel BestelALabel1;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox4;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox3;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox2;
        private MaterialSkin.Controls.MaterialTextBox BestelATextbox1;
        private MaterialSkin.Controls.MaterialComboBox BestelACombobox1;
        private MaterialSkin.Controls.MaterialListView BestelAListView1;
        private System.Windows.Forms.ColumnHeader BestelAHeader1;
        private System.Windows.Forms.ColumnHeader BestelAHeader2;
        private System.Windows.Forms.ColumnHeader BestelAHeader3;
        private System.Windows.Forms.ColumnHeader BestelAHeader4;
        private System.Windows.Forms.ColumnHeader BestelAHeader5;
        private MaterialSkin.Controls.MaterialButton BestelAButton3;
        private MaterialSkin.Controls.MaterialButton BestelAButton2;
        private MaterialSkin.Controls.MaterialButton BestelAButton1;
    }
}


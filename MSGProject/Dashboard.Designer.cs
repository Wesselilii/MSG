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
            this.GebruikersTab = new System.Windows.Forms.TabPage();
            this.MaaltijdTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BestellingenTab = new System.Windows.Forms.TabPage();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
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
            // GebruikersTab
            // 
            this.GebruikersTab.ImageKey = "user-32.png";
            this.GebruikersTab.Location = new System.Drawing.Point(4, 39);
            this.GebruikersTab.Name = "GebruikersTab";
            this.GebruikersTab.Padding = new System.Windows.Forms.Padding(3);
            this.GebruikersTab.Size = new System.Drawing.Size(986, 390);
            this.GebruikersTab.TabIndex = 0;
            this.GebruikersTab.Text = "Gebruikers";
            this.GebruikersTab.UseVisualStyleBackColor = true;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rice-32.png");
            this.imageList1.Images.SetKeyName(1, "truck-32.png");
            this.imageList1.Images.SetKeyName(2, "user-32.png");
            this.imageList1.Images.SetKeyName(3, "home-32.png");
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
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage GebruikersTab;
        private System.Windows.Forms.TabPage MaaltijdTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage BestellingenTab;
        private System.Windows.Forms.TabPage HomeTab;
    }
}


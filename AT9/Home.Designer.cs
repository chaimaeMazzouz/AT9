namespace AT9
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navugationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutVirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionVirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comptesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.opérationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.ajoutCompteToolStripMenuItem,
            this.modificationCompteToolStripMenuItem,
            this.suppressionCompteToolStripMenuItem});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // ajoutCompteToolStripMenuItem
            // 
            this.ajoutCompteToolStripMenuItem.Name = "ajoutCompteToolStripMenuItem";
            this.ajoutCompteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ajoutCompteToolStripMenuItem.Text = "Ajout Compte";
            this.ajoutCompteToolStripMenuItem.Click += new System.EventHandler(this.ajoutCompteToolStripMenuItem_Click);
            // 
            // modificationCompteToolStripMenuItem
            // 
            this.modificationCompteToolStripMenuItem.Name = "modificationCompteToolStripMenuItem";
            this.modificationCompteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modificationCompteToolStripMenuItem.Text = "Modification Compte";
            this.modificationCompteToolStripMenuItem.Click += new System.EventHandler(this.modificationCompteToolStripMenuItem_Click);
            // 
            // suppressionCompteToolStripMenuItem
            // 
            this.suppressionCompteToolStripMenuItem.Name = "suppressionCompteToolStripMenuItem";
            this.suppressionCompteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.suppressionCompteToolStripMenuItem.Text = "Suppression Compte";
            this.suppressionCompteToolStripMenuItem.Click += new System.EventHandler(this.suppressionCompteToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navugationToolStripMenuItem,
            this.ajoutClientToolStripMenuItem,
            this.modificationClientToolStripMenuItem,
            this.suppressionClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // navugationToolStripMenuItem
            // 
            this.navugationToolStripMenuItem.Name = "navugationToolStripMenuItem";
            this.navugationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.navugationToolStripMenuItem.Text = "Recherche Comptes Client";
            this.navugationToolStripMenuItem.Click += new System.EventHandler(this.navugationToolStripMenuItem_Click);
            // 
            // ajoutClientToolStripMenuItem
            // 
            this.ajoutClientToolStripMenuItem.Name = "ajoutClientToolStripMenuItem";
            this.ajoutClientToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ajoutClientToolStripMenuItem.Text = "Ajout Client";
            this.ajoutClientToolStripMenuItem.Click += new System.EventHandler(this.ajoutClientToolStripMenuItem_Click);
            // 
            // modificationClientToolStripMenuItem
            // 
            this.modificationClientToolStripMenuItem.Name = "modificationClientToolStripMenuItem";
            this.modificationClientToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.modificationClientToolStripMenuItem.Text = "Modification Client";
            this.modificationClientToolStripMenuItem.Click += new System.EventHandler(this.modificationClientToolStripMenuItem_Click);
            // 
            // suppressionClientToolStripMenuItem
            // 
            this.suppressionClientToolStripMenuItem.Name = "suppressionClientToolStripMenuItem";
            this.suppressionClientToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.suppressionClientToolStripMenuItem.Text = "Suppression Client";
            this.suppressionClientToolStripMenuItem.Click += new System.EventHandler(this.suppressionClientToolStripMenuItem_Click);
            // 
            // opérationsToolStripMenuItem
            // 
            this.opérationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouvementToolStripMenuItem,
            this.virementsToolStripMenuItem});
            this.opérationsToolStripMenuItem.Name = "opérationsToolStripMenuItem";
            this.opérationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.opérationsToolStripMenuItem.Text = "Opérations";
            // 
            // mouvementToolStripMenuItem
            // 
            this.mouvementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutMouvementToolStripMenuItem,
            this.suppressionMouvementToolStripMenuItem});
            this.mouvementToolStripMenuItem.Name = "mouvementToolStripMenuItem";
            this.mouvementToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mouvementToolStripMenuItem.Text = "Mouvements";
            // 
            // ajoutMouvementToolStripMenuItem
            // 
            this.ajoutMouvementToolStripMenuItem.Name = "ajoutMouvementToolStripMenuItem";
            this.ajoutMouvementToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ajoutMouvementToolStripMenuItem.Text = "Ajout Mouvement";
            // 
            // suppressionMouvementToolStripMenuItem
            // 
            this.suppressionMouvementToolStripMenuItem.Name = "suppressionMouvementToolStripMenuItem";
            this.suppressionMouvementToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.suppressionMouvementToolStripMenuItem.Text = "Suppression Mouvement";
            // 
            // virementsToolStripMenuItem
            // 
            this.virementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutVirementToolStripMenuItem,
            this.suppressionVirementToolStripMenuItem});
            this.virementsToolStripMenuItem.Name = "virementsToolStripMenuItem";
            this.virementsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.virementsToolStripMenuItem.Text = "Virements";
            // 
            // ajoutVirementToolStripMenuItem
            // 
            this.ajoutVirementToolStripMenuItem.Name = "ajoutVirementToolStripMenuItem";
            this.ajoutVirementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ajoutVirementToolStripMenuItem.Text = "Ajout Virement";
            // 
            // suppressionVirementToolStripMenuItem
            // 
            this.suppressionVirementToolStripMenuItem.Name = "suppressionVirementToolStripMenuItem";
            this.suppressionVirementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.suppressionVirementToolStripMenuItem.Text = "Suppression Virement";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 495);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Banque mode déconnecté";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navugationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opérationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutMouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionMouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutVirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionVirementToolStripMenuItem;
    }
}


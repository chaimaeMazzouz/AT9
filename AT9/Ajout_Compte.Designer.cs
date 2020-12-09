namespace AT9
{
    partial class Ajout_Compte
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.textNumCompt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboNum_Client = new System.Windows.Forms.ComboBox();
            this.comboTypeCompte = new System.Windows.Forms.ComboBox();
            this.btnAjouterCompte = new System.Windows.Forms.Button();
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Solde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Type Compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Num Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Num Compte";
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(524, 134);
            this.textSolde.Name = "textSolde";
            this.textSolde.Size = new System.Drawing.Size(100, 20);
            this.textSolde.TabIndex = 17;
            // 
            // textNumCompt
            // 
            this.textNumCompt.Location = new System.Drawing.Point(89, 134);
            this.textNumCompt.Name = "textNumCompt";
            this.textNumCompt.Size = new System.Drawing.Size(100, 20);
            this.textNumCompt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(304, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ajout Compte";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // comboNum_Client
            // 
            this.comboNum_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNum_Client.FormattingEnabled = true;
            this.comboNum_Client.Location = new System.Drawing.Point(216, 134);
            this.comboNum_Client.Name = "comboNum_Client";
            this.comboNum_Client.Size = new System.Drawing.Size(121, 21);
            this.comboNum_Client.TabIndex = 27;
            // 
            // comboTypeCompte
            // 
            this.comboTypeCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeCompte.FormattingEnabled = true;
            this.comboTypeCompte.Items.AddRange(new object[] {
            "Chèque",
            "Camet",
            "Education",
            "Age d\'or",
            "Entreprise",
            "Epagne"});
            this.comboTypeCompte.Location = new System.Drawing.Point(363, 134);
            this.comboTypeCompte.Name = "comboTypeCompte";
            this.comboTypeCompte.Size = new System.Drawing.Size(121, 21);
            this.comboTypeCompte.TabIndex = 28;
            // 
            // btnAjouterCompte
            // 
            this.btnAjouterCompte.Location = new System.Drawing.Point(687, 36);
            this.btnAjouterCompte.Name = "btnAjouterCompte";
            this.btnAjouterCompte.Size = new System.Drawing.Size(75, 36);
            this.btnAjouterCompte.TabIndex = 29;
            this.btnAjouterCompte.Text = "Ajouter Compte";
            this.btnAjouterCompte.UseVisualStyleBackColor = true;
            this.btnAjouterCompte.Click += new System.EventHandler(this.btnAjouterCompte_Click);
            // 
            // btnEnregistrerQuiter
            // 
            this.btnEnregistrerQuiter.Location = new System.Drawing.Point(687, 91);
            this.btnEnregistrerQuiter.Name = "btnEnregistrerQuiter";
            this.btnEnregistrerQuiter.Size = new System.Drawing.Size(75, 35);
            this.btnEnregistrerQuiter.TabIndex = 30;
            this.btnEnregistrerQuiter.Text = "Enregistrer et Quiter";
            this.btnEnregistrerQuiter.UseVisualStyleBackColor = true;
            this.btnEnregistrerQuiter.Click += new System.EventHandler(this.btnEnregistrerQuiter_Click);
            // 
            // Ajout_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrerQuiter);
            this.Controls.Add(this.btnAjouterCompte);
            this.Controls.Add(this.comboTypeCompte);
            this.Controls.Add(this.comboNum_Client);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.textNumCompt);
            this.Name = "Ajout_Compte";
            this.Text = "Ajout_Compte";
            this.Load += new System.EventHandler(this.Ajout_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.TextBox textNumCompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboNum_Client;
        private System.Windows.Forms.ComboBox comboTypeCompte;
        private System.Windows.Forms.Button btnAjouterCompte;
        private System.Windows.Forms.Button btnEnregistrerQuiter;
    }
}
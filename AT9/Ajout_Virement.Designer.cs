namespace AT9
{
    partial class Ajout_Virement
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textMontantVirement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_Num_Compte = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            this.btnAjouterVirement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.radioDebiteur = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioCrediteur = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(78, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Comptes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(54, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Mouvements";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(180, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(436, 150);
            this.dataGridView2.TabIndex = 83;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 82;
            // 
            // textMontantVirement
            // 
            this.textMontantVirement.Location = new System.Drawing.Point(514, 76);
            this.textMontantVirement.Name = "textMontantVirement";
            this.textMontantVirement.Size = new System.Drawing.Size(100, 20);
            this.textMontantVirement.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Montant Virement";
            // 
            // combo_Num_Compte
            // 
            this.combo_Num_Compte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Num_Compte.FormattingEnabled = true;
            this.combo_Num_Compte.Location = new System.Drawing.Point(54, 76);
            this.combo_Num_Compte.Name = "combo_Num_Compte";
            this.combo_Num_Compte.Size = new System.Drawing.Size(121, 21);
            this.combo_Num_Compte.TabIndex = 74;
            this.combo_Num_Compte.SelectedIndexChanged += new System.EventHandler(this.combo_Num_Compte_SelectedIndexChanged);
            // 
            // btnEnregistrerQuiter
            // 
            this.btnEnregistrerQuiter.Location = new System.Drawing.Point(671, 76);
            this.btnEnregistrerQuiter.Name = "btnEnregistrerQuiter";
            this.btnEnregistrerQuiter.Size = new System.Drawing.Size(75, 35);
            this.btnEnregistrerQuiter.TabIndex = 72;
            this.btnEnregistrerQuiter.Text = "Enregistrer et Quiter";
            this.btnEnregistrerQuiter.UseVisualStyleBackColor = true;
            this.btnEnregistrerQuiter.Click += new System.EventHandler(this.btnEnregistrerQuiter_Click);
            // 
            // btnAjouterVirement
            // 
            this.btnAjouterVirement.Location = new System.Drawing.Point(671, 21);
            this.btnAjouterVirement.Name = "btnAjouterVirement";
            this.btnAjouterVirement.Size = new System.Drawing.Size(75, 36);
            this.btnAjouterVirement.TabIndex = 71;
            this.btnAjouterVirement.Text = "Ajouter Virement";
            this.btnAjouterVirement.UseVisualStyleBackColor = true;
            this.btnAjouterVirement.Click += new System.EventHandler(this.btnAjouterVirement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(297, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ajout Virement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Num Compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Solde";
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(203, 76);
            this.textSolde.Name = "textSolde";
            this.textSolde.ReadOnly = true;
            this.textSolde.Size = new System.Drawing.Size(100, 20);
            this.textSolde.TabIndex = 75;
            // 
            // radioDebiteur
            // 
            this.radioDebiteur.AutoSize = true;
            this.radioDebiteur.Location = new System.Drawing.Point(345, 79);
            this.radioDebiteur.Name = "radioDebiteur";
            this.radioDebiteur.Size = new System.Drawing.Size(65, 17);
            this.radioDebiteur.TabIndex = 77;
            this.radioDebiteur.TabStop = true;
            this.radioDebiteur.Text = "Debiteur";
            this.radioDebiteur.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Type Virement";
            // 
            // radioCrediteur
            // 
            this.radioCrediteur.AutoSize = true;
            this.radioCrediteur.Location = new System.Drawing.Point(426, 77);
            this.radioCrediteur.Name = "radioCrediteur";
            this.radioCrediteur.Size = new System.Drawing.Size(67, 17);
            this.radioCrediteur.TabIndex = 78;
            this.radioCrediteur.TabStop = true;
            this.radioCrediteur.Text = "Crediteur";
            this.radioCrediteur.UseVisualStyleBackColor = true;
            // 
            // Ajout_Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textMontantVirement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioCrediteur);
            this.Controls.Add(this.radioDebiteur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.combo_Num_Compte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnregistrerQuiter);
            this.Controls.Add(this.btnAjouterVirement);
            this.Controls.Add(this.label1);
            this.Name = "Ajout_Virement";
            this.Text = "Ajout_Virement";
            this.Load += new System.EventHandler(this.Ajout_Virement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textMontantVirement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_Num_Compte;
        private System.Windows.Forms.Button btnEnregistrerQuiter;
        private System.Windows.Forms.Button btnAjouterVirement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.RadioButton radioDebiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioCrediteur;
    }
}
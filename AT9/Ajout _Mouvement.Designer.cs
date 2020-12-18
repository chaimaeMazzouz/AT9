namespace AT9
{
    partial class Ajout__Mouvement
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            this.btnAjouterMouvement = new System.Windows.Forms.Button();
            this.combo_Num_Compte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.radioVersement = new System.Windows.Forms.RadioButton();
            this.radioRetrait = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMontantMouvement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(255, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ajout Mouvement";
            // 
            // btnEnregistrerQuiter
            // 
            this.btnEnregistrerQuiter.Location = new System.Drawing.Point(629, 87);
            this.btnEnregistrerQuiter.Name = "btnEnregistrerQuiter";
            this.btnEnregistrerQuiter.Size = new System.Drawing.Size(75, 35);
            this.btnEnregistrerQuiter.TabIndex = 55;
            this.btnEnregistrerQuiter.Text = "Enregistrer et Quiter";
            this.btnEnregistrerQuiter.UseVisualStyleBackColor = true;
            this.btnEnregistrerQuiter.Click += new System.EventHandler(this.btnEnregistrerQuiter_Click);
            // 
            // btnAjouterMouvement
            // 
            this.btnAjouterMouvement.Location = new System.Drawing.Point(629, 32);
            this.btnAjouterMouvement.Name = "btnAjouterMouvement";
            this.btnAjouterMouvement.Size = new System.Drawing.Size(75, 36);
            this.btnAjouterMouvement.TabIndex = 54;
            this.btnAjouterMouvement.Text = "Ajouter Mouvement";
            this.btnAjouterMouvement.UseVisualStyleBackColor = true;
            this.btnAjouterMouvement.Click += new System.EventHandler(this.btnAjouterMouvement_Click);
            // 
            // combo_Num_Compte
            // 
            this.combo_Num_Compte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Num_Compte.FormattingEnabled = true;
            this.combo_Num_Compte.Location = new System.Drawing.Point(12, 87);
            this.combo_Num_Compte.Name = "combo_Num_Compte";
            this.combo_Num_Compte.Size = new System.Drawing.Size(121, 21);
            this.combo_Num_Compte.TabIndex = 57;
            this.combo_Num_Compte.SelectedIndexChanged += new System.EventHandler(this.combo_Num_Compte_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Num Compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Solde";
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(161, 87);
            this.textSolde.Name = "textSolde";
            this.textSolde.ReadOnly = true;
            this.textSolde.Size = new System.Drawing.Size(100, 20);
            this.textSolde.TabIndex = 58;
            // 
            // radioVersement
            // 
            this.radioVersement.AutoSize = true;
            this.radioVersement.Location = new System.Drawing.Point(303, 90);
            this.radioVersement.Name = "radioVersement";
            this.radioVersement.Size = new System.Drawing.Size(75, 17);
            this.radioVersement.TabIndex = 61;
            this.radioVersement.TabStop = true;
            this.radioVersement.Text = "Versement";
            this.radioVersement.UseVisualStyleBackColor = true;
            // 
            // radioRetrait
            // 
            this.radioRetrait.AutoSize = true;
            this.radioRetrait.Location = new System.Drawing.Point(384, 88);
            this.radioRetrait.Name = "radioRetrait";
            this.radioRetrait.Size = new System.Drawing.Size(56, 17);
            this.radioRetrait.TabIndex = 62;
            this.radioRetrait.TabStop = true;
            this.radioRetrait.Text = "Retrait";
            this.radioRetrait.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Montant Mouvement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Type Mouvement";
            // 
            // textMontantMouvement
            // 
            this.textMontantMouvement.Location = new System.Drawing.Point(472, 87);
            this.textMontantMouvement.Name = "textMontantMouvement";
            this.textMontantMouvement.Size = new System.Drawing.Size(100, 20);
            this.textMontantMouvement.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(36, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Comptes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Mouvements";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(138, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(436, 150);
            this.dataGridView2.TabIndex = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 66;
            // 
            // Ajout__Mouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textMontantMouvement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioRetrait);
            this.Controls.Add(this.radioVersement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.combo_Num_Compte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnregistrerQuiter);
            this.Controls.Add(this.btnAjouterMouvement);
            this.Controls.Add(this.label1);
            this.Name = "Ajout__Mouvement";
            this.Text = "Ajout__Mouvement";
            this.Load += new System.EventHandler(this.Ajout__Mouvement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrerQuiter;
        private System.Windows.Forms.Button btnAjouterMouvement;
        private System.Windows.Forms.ComboBox combo_Num_Compte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.RadioButton radioVersement;
        private System.Windows.Forms.RadioButton radioRetrait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMontantMouvement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
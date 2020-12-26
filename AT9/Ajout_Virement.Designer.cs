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
            this.combo_Num_Debiteur = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            this.btnAjouterVirement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCrediteur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoldeDeb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textSoldeCrediteur = new System.Windows.Forms.TextBox();
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
            this.textMontantVirement.Location = new System.Drawing.Point(538, 76);
            this.textMontantVirement.Name = "textMontantVirement";
            this.textMontantVirement.Size = new System.Drawing.Size(100, 20);
            this.textMontantVirement.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Montant Virement";
            // 
            // combo_Num_Debiteur
            // 
            this.combo_Num_Debiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Num_Debiteur.FormattingEnabled = true;
            this.combo_Num_Debiteur.Location = new System.Drawing.Point(12, 76);
            this.combo_Num_Debiteur.Name = "combo_Num_Debiteur";
            this.combo_Num_Debiteur.Size = new System.Drawing.Size(121, 21);
            this.combo_Num_Debiteur.TabIndex = 74;
            this.combo_Num_Debiteur.SelectedIndexChanged += new System.EventHandler(this.combo_Num_Debiteur_SelectedIndexChanged);
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
            this.label3.Location = new System.Drawing.Point(32, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Num Debiteur";
            // 
            // comboCrediteur
            // 
            this.comboCrediteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCrediteur.FormattingEnabled = true;
            this.comboCrediteur.Location = new System.Drawing.Point(278, 76);
            this.comboCrediteur.Name = "comboCrediteur";
            this.comboCrediteur.Size = new System.Drawing.Size(121, 21);
            this.comboCrediteur.TabIndex = 87;
            this.comboCrediteur.SelectedIndexChanged += new System.EventHandler(this.comboCrediteur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Num Crediteur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Solde Debiteur";
            // 
            // textSoldeDeb
            // 
            this.textSoldeDeb.Location = new System.Drawing.Point(152, 76);
            this.textSoldeDeb.Name = "textSoldeDeb";
            this.textSoldeDeb.ReadOnly = true;
            this.textSoldeDeb.Size = new System.Drawing.Size(100, 20);
            this.textSoldeDeb.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Solde Crediteur";
            // 
            // textSoldeCrediteur
            // 
            this.textSoldeCrediteur.Location = new System.Drawing.Point(414, 76);
            this.textSoldeCrediteur.Name = "textSoldeCrediteur";
            this.textSoldeCrediteur.ReadOnly = true;
            this.textSoldeCrediteur.Size = new System.Drawing.Size(100, 20);
            this.textSoldeCrediteur.TabIndex = 90;
            // 
            // Ajout_Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSoldeCrediteur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSoldeDeb);
            this.Controls.Add(this.comboCrediteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textMontantVirement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_Num_Debiteur);
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
        private System.Windows.Forms.ComboBox combo_Num_Debiteur;
        private System.Windows.Forms.Button btnEnregistrerQuiter;
        private System.Windows.Forms.Button btnAjouterVirement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCrediteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoldeDeb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSoldeCrediteur;
    }
}
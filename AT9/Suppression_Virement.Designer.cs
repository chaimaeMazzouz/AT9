namespace AT9
{
    partial class Suppression_Virement
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
            this.combo_Num_Ver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            this.btnSupprimerViremen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textSoldeCrediteur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSoldeDeb = new System.Windows.Forms.TextBox();
            this.textMontantVirement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(44, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Comptes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(20, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Tous les Virements";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(244, 297);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(436, 150);
            this.dataGridView2.TabIndex = 95;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 94;
            // 
            // combo_Num_Ver
            // 
            this.combo_Num_Ver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Num_Ver.FormattingEnabled = true;
            this.combo_Num_Ver.Location = new System.Drawing.Point(20, 70);
            this.combo_Num_Ver.Name = "combo_Num_Ver";
            this.combo_Num_Ver.Size = new System.Drawing.Size(121, 21);
            this.combo_Num_Ver.TabIndex = 91;
            this.combo_Num_Ver.SelectedIndexChanged += new System.EventHandler(this.combo_Num_Ver_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Num Virement";
            // 
            // btnEnregistrerQuiter
            // 
            this.btnEnregistrerQuiter.Location = new System.Drawing.Point(637, 70);
            this.btnEnregistrerQuiter.Name = "btnEnregistrerQuiter";
            this.btnEnregistrerQuiter.Size = new System.Drawing.Size(75, 35);
            this.btnEnregistrerQuiter.TabIndex = 89;
            this.btnEnregistrerQuiter.Text = "Enregistrer et Quiter";
            this.btnEnregistrerQuiter.UseVisualStyleBackColor = true;
            this.btnEnregistrerQuiter.Click += new System.EventHandler(this.btnEnregistrerQuiter_Click);
            // 
            // btnSupprimerViremen
            // 
            this.btnSupprimerViremen.Location = new System.Drawing.Point(637, 15);
            this.btnSupprimerViremen.Name = "btnSupprimerViremen";
            this.btnSupprimerViremen.Size = new System.Drawing.Size(75, 36);
            this.btnSupprimerViremen.TabIndex = 88;
            this.btnSupprimerViremen.Text = "Supprimer Virement";
            this.btnSupprimerViremen.UseVisualStyleBackColor = true;
            this.btnSupprimerViremen.Click += new System.EventHandler(this.btnSupprimerViremen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(263, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Suppressipon Mouvement";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(244, 477);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(436, 150);
            this.dataGridView3.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "les Verments supprimée";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "Solde Crediteur";
            // 
            // textSoldeCrediteur
            // 
            this.textSoldeCrediteur.Location = new System.Drawing.Point(294, 70);
            this.textSoldeCrediteur.Name = "textSoldeCrediteur";
            this.textSoldeCrediteur.ReadOnly = true;
            this.textSoldeCrediteur.Size = new System.Drawing.Size(100, 20);
            this.textSoldeCrediteur.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Solde Debiteur";
            // 
            // textSoldeDeb
            // 
            this.textSoldeDeb.Location = new System.Drawing.Point(172, 70);
            this.textSoldeDeb.Name = "textSoldeDeb";
            this.textSoldeDeb.ReadOnly = true;
            this.textSoldeDeb.Size = new System.Drawing.Size(100, 20);
            this.textSoldeDeb.TabIndex = 102;
            // 
            // textMontantVirement
            // 
            this.textMontantVirement.Location = new System.Drawing.Point(428, 67);
            this.textMontantVirement.Name = "textMontantVirement";
            this.textMontantVirement.ReadOnly = true;
            this.textMontantVirement.Size = new System.Drawing.Size(100, 20);
            this.textMontantVirement.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Montant Virement";
            // 
            // Suppression_Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 639);
            this.Controls.Add(this.textMontantVirement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textSoldeCrediteur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSoldeDeb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_Num_Ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnregistrerQuiter);
            this.Controls.Add(this.btnSupprimerViremen);
            this.Controls.Add(this.label1);
            this.Name = "Suppression_Virement";
            this.Text = "Suppression_Virement";
            this.Load += new System.EventHandler(this.Suppression_Virement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_Num_Ver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrerQuiter;
        private System.Windows.Forms.Button btnSupprimerViremen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSoldeCrediteur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSoldeDeb;
        private System.Windows.Forms.TextBox textMontantVirement;
        private System.Windows.Forms.Label label4;
    }
}
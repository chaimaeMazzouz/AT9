namespace AT9
{
    partial class Suppression_Mouvement
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
            this.combo_Num_Mouvement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            this.btnSupprimerMouvement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label5.Location = new System.Drawing.Point(73, 466);
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
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Tous les Mouvements";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(278, 288);
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
            this.dataGridView1.Location = new System.Drawing.Point(278, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 82;
            // 
            // combo_Num_Mouvement
            // 
            this.combo_Num_Mouvement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Num_Mouvement.FormattingEnabled = true;
            this.combo_Num_Mouvement.Location = new System.Drawing.Point(54, 76);
            this.combo_Num_Mouvement.Name = "combo_Num_Mouvement";
            this.combo_Num_Mouvement.Size = new System.Drawing.Size(121, 21);
            this.combo_Num_Mouvement.TabIndex = 74;
            this.combo_Num_Mouvement.SelectedIndexChanged += new System.EventHandler(this.combo_Num_Mouvement_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Num Mouvement";
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
            // btnSupprimerMouvement
            // 
            this.btnSupprimerMouvement.Location = new System.Drawing.Point(671, 21);
            this.btnSupprimerMouvement.Name = "btnSupprimerMouvement";
            this.btnSupprimerMouvement.Size = new System.Drawing.Size(75, 36);
            this.btnSupprimerMouvement.TabIndex = 71;
            this.btnSupprimerMouvement.Text = "Supprimer Mouvement";
            this.btnSupprimerMouvement.UseVisualStyleBackColor = true;
            this.btnSupprimerMouvement.Click += new System.EventHandler(this.btnSupprimerMouvement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(297, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Suppressipon Mouvement";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(278, 444);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(436, 150);
            this.dataGridView3.TabIndex = 86;
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(203, 76);
            this.textSolde.Name = "textSolde";
            this.textSolde.ReadOnly = true;
            this.textSolde.Size = new System.Drawing.Size(100, 20);
            this.textSolde.TabIndex = 75;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(28, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "les Mouvements supprimée";
            // 
            // Suppression_Mouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.combo_Num_Mouvement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnregistrerQuiter);
            this.Controls.Add(this.btnSupprimerMouvement);
            this.Controls.Add(this.label1);
            this.Name = "Suppression_Mouvement";
            this.Text = "Suppression_Mouvement";
            this.Load += new System.EventHandler(this.Suppression_Mouvement_Load);
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
        private System.Windows.Forms.ComboBox combo_Num_Mouvement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrerQuiter;
        private System.Windows.Forms.Button btnSupprimerMouvement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}
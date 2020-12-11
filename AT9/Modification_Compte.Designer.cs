namespace AT9
{
    partial class Modification_Compte
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
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnModifierCompte = new System.Windows.Forms.Button();
            this.comboTypeCompte = new System.Windows.Forms.ComboBox();
            this.combo_Num_Compte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSolde = new System.Windows.Forms.TextBox();
            this.textNumClient = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(662, 74);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(75, 35);
            this.btnQuiter.TabIndex = 41;
            this.btnQuiter.Text = " Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // btnModifierCompte
            // 
            this.btnModifierCompte.Location = new System.Drawing.Point(662, 19);
            this.btnModifierCompte.Name = "btnModifierCompte";
            this.btnModifierCompte.Size = new System.Drawing.Size(75, 36);
            this.btnModifierCompte.TabIndex = 40;
            this.btnModifierCompte.Text = "Modifier Compte";
            this.btnModifierCompte.UseVisualStyleBackColor = true;
            this.btnModifierCompte.Click += new System.EventHandler(this.btnModifierCompte_Click);
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
            this.comboTypeCompte.Location = new System.Drawing.Point(338, 117);
            this.comboTypeCompte.Name = "comboTypeCompte";
            this.comboTypeCompte.Size = new System.Drawing.Size(121, 21);
            this.comboTypeCompte.TabIndex = 39;
            // 
            // combo_Num_Compte
            // 
            this.combo_Num_Compte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Num_Compte.FormattingEnabled = true;
            this.combo_Num_Compte.Location = new System.Drawing.Point(41, 117);
            this.combo_Num_Compte.Name = "combo_Num_Compte";
            this.combo_Num_Compte.Size = new System.Drawing.Size(121, 21);
            this.combo_Num_Compte.TabIndex = 38;
            this.combo_Num_Compte.SelectedIndexChanged += new System.EventHandler(this.combo_Num_Compte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Modification Compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Solde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Type Compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Num Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Num Compte";
            // 
            // textSolde
            // 
            this.textSolde.Location = new System.Drawing.Point(499, 117);
            this.textSolde.Name = "textSolde";
            this.textSolde.ReadOnly = true;
            this.textSolde.Size = new System.Drawing.Size(100, 20);
            this.textSolde.TabIndex = 32;
            // 
            // textNumClient
            // 
            this.textNumClient.Location = new System.Drawing.Point(193, 117);
            this.textNumClient.Name = "textNumClient";
            this.textNumClient.Size = new System.Drawing.Size(100, 20);
            this.textNumClient.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 42;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(301, 338);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(436, 150);
            this.dataGridView2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tous les enregistements";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(12, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "les enregistements modifiés";
            // 
            // Modification_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnModifierCompte);
            this.Controls.Add(this.comboTypeCompte);
            this.Controls.Add(this.combo_Num_Compte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSolde);
            this.Controls.Add(this.textNumClient);
            this.Name = "Modification_Compte";
            this.Text = "Modification_Compte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modification_Compte_FormClosing);
            this.Load += new System.EventHandler(this.Modification_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Button btnModifierCompte;
        private System.Windows.Forms.ComboBox comboTypeCompte;
        private System.Windows.Forms.ComboBox combo_Num_Compte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSolde;
        private System.Windows.Forms.TextBox textNumClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}
namespace AT9
{
    partial class Ajout_Client
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
            this.btnEnregistrerQuiter = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textNumClient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrerQuiter
            // 
            this.btnEnregistrerQuiter.Location = new System.Drawing.Point(599, 135);
            this.btnEnregistrerQuiter.Name = "btnEnregistrerQuiter";
            this.btnEnregistrerQuiter.Size = new System.Drawing.Size(75, 35);
            this.btnEnregistrerQuiter.TabIndex = 42;
            this.btnEnregistrerQuiter.Text = "Enregistrer et Quiter";
            this.btnEnregistrerQuiter.UseVisualStyleBackColor = true;
            this.btnEnregistrerQuiter.Click += new System.EventHandler(this.btnEnregistrerQuiter_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(599, 80);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 36);
            this.btnAjouterClient.TabIndex = 41;
            this.btnAjouterClient.Text = "Ajouter Client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(280, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ajout Client";
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(370, 153);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(72, 13);
            this.lblPrenomClient.TabIndex = 36;
            this.lblPrenomClient.Text = "Prénom Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Num Client";
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(373, 174);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(138, 20);
            this.textPrenom.TabIndex = 32;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(234, 153);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(58, 13);
            this.lblNomClient.TabIndex = 44;
            this.lblNomClient.Text = "Nom Client";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(214, 174);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(130, 20);
            this.textNom.TabIndex = 43;
            // 
            // textNumClient
            // 
            this.textNumClient.Location = new System.Drawing.Point(69, 174);
            this.textNumClient.Name = "textNumClient";
            this.textNumClient.Size = new System.Drawing.Size(100, 20);
            this.textNumClient.TabIndex = 45;
            // 
            // Ajout_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.textNumClient);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.btnEnregistrerQuiter);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrenom);
            this.Name = "Ajout_Client";
            this.Text = "Ajout_Client";
            this.Load += new System.EventHandler(this.Ajout_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrerQuiter;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textNumClient;
    }
}
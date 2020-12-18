using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT9
{
    public partial class Ajout_Client : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Clients = new SqlDataAdapter("select * from Client", g1.banque_connexion);
        public Ajout_Client()
        {
            InitializeComponent();
        }

        private void Ajout_Client_Load(object sender, EventArgs e)
        {
            try
            {
                Adp_Clients.Fill(Ds_Banque, "MesClients");
                dataGridView1.DataSource = Ds_Banque.Tables["MesClients"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (textNumClient.Text != "" && textPrenom.Text != "" && textNom.Text != "" )
            {
                try
                {
                    DataRow ligne = Ds_Banque.Tables["MesClients"].NewRow();
                    ligne[0] = textNumClient.Text;
                    ligne[1] = textNom.Text;
                    ligne[2] = textPrenom.Text;
                    Ds_Banque.Tables["MesClients"].Rows.Add(ligne);
                    textNumClient.Clear();
                    textPrenom.Clear();
                    textNom.Clear();
                    MessageBox.Show("Ajout effectué");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEnregistrerQuiter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder blBanque = new SqlCommandBuilder(Adp_Clients);
                Adp_Clients.Update(Ds_Banque, "MesClients");
                MessageBox.Show("Sauvgarde effectué!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

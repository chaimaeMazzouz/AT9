using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AT9
{
    public partial class Recherche_Clients : Form
    {
        Global g1 = new Global();
        DataSet Ds_Clients = new DataSet();
        SqlDataAdapter Adp_Banque;
        public Recherche_Clients()
        {
            InitializeComponent();
          
        }

        private void Recherche_Clients_Load(object sender, EventArgs e)
        {
            Adp_Banque = new SqlDataAdapter("", g1.banque_connexion);
            Adp_Banque.SelectCommand.CommandText = "SELECT Num_Client,(Nom_Client+' '+Prenom_Client) as Nom from Client";
            Ds_Clients.Clear();
            Adp_Banque.Fill(Ds_Clients, "MesClients");

            string Stcom = "select * from Compte"; 
            Adp_Banque.SelectCommand.CommandText = Stcom;
            Adp_Banque.Fill(Ds_Clients, "MesComptes");

            comboNumClient.DisplayMember = "Num_Client";
            comboNumClient.ValueMember = "Num_Client";
            comboNumClient.DataSource = Ds_Clients.Tables["MesClients"];
        }

        private void comboNumClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView vue_Client = Ds_Clients.Tables["MesClients"].DefaultView;
            DataView Vue_Compte = Ds_Clients.Tables["MesComptes"].DefaultView;
            try
            {
                
                Vue_Compte.RowFilter = "Num_Client= '" + comboNumClient.SelectedValue + "'";
                Vue_Compte.Sort = "Solde ASC";
                textNomClient.Text = vue_Client[comboNumClient.SelectedIndex].Row["Nom"].ToString();
                dataGridView1.DataSource = Ds_Clients.Tables["MesComptes"];
                dataGridView1.Columns["Num_Client"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

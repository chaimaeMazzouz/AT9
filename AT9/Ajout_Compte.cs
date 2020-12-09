using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Ajout_Compte : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("select * from Compte", g1.banque_connexion);
        SqlDataAdapter Adp_Clients = new SqlDataAdapter("select * from Client", g1.banque_connexion);
        public Ajout_Compte()
        {
            InitializeComponent();
        }

        private void Ajout_Compte_Load(object sender, EventArgs e)
        {
            try
            {
                Adp_Clients.Fill(Ds_Banque, "MesClients");
                Adp_Comptes.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesComptes"];

                comboTypeCompte.SelectedIndex = 0;
                comboNum_Client.DisplayMember = "Num_Client";
                comboNum_Client.ValueMember = "Num_Client";
                comboNum_Client.DataSource = Ds_Banque.Tables["MesClients"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterCompte_Click(object sender, EventArgs e)
        {
            if (textNumCompt.Text !="" && textSolde.Text!="" && comboNum_Client.Text !="" && comboTypeCompte.Text !="")
            {
                try
                {
                    DataRow ligne = Ds_Banque.Tables["MesComptes"].NewRow();
                    ligne[0] = textNumCompt.Text;
                    ligne[1] = comboNum_Client.Text;
                    ligne[2] = textSolde.Text;
                    ligne[3] = comboTypeCompte.Text;
                    Ds_Banque.Tables["MesComptes"].Rows.Add(ligne);
                    textNumCompt.Clear();
                    textSolde.Clear();
                    comboNum_Client.SelectedIndex = 0;
                    comboTypeCompte.SelectedIndex = 0;
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
                SqlCommandBuilder blBanque = new SqlCommandBuilder(Adp_Comptes);
                Adp_Comptes.Update(Ds_Banque, "MesComptes");
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

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Navigation_Comptes : Form
    {
        Global g1 = new Global();
        DataSet Ds_Comptes = new DataSet();
        SqlDataAdapter Adp_Banque;
        int i;
        void remplir()
        {
            textNum.Text = Ds_Comptes.Tables["MesComptes"].Rows[i].ItemArray[0].ToString();
            textNom.Text = Ds_Comptes.Tables["MesComptes"].Rows[i].ItemArray[5].ToString();
            textPrenom.Text = Ds_Comptes.Tables["MesComptes"].Rows[i].ItemArray[6].ToString();
            textSolde.Text = Ds_Comptes.Tables["MesComptes"].Rows[i].ItemArray[2].ToString();
            textTypeCompte.Text = Ds_Comptes.Tables["MesComptes"].Rows[i].ItemArray[3].ToString();
        }
        public Navigation_Comptes()
        {
            InitializeComponent();
        }

        private void Navigation_Comptes_Load(object sender, EventArgs e)
        {
            i = 0;
            Adp_Banque = new SqlDataAdapter("", g1.banque_connexion);
            Adp_Banque.SelectCommand.CommandText = "select * from Compte join Client on Compte.Num_Client =Client.Num_Client";
            try
            {
                Adp_Banque.Fill(Ds_Comptes, "MesComptes");
                nbreComptesLbl.Text = Ds_Comptes.Tables["MesComptes"].Rows.Count.ToString();
                remplir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            remplir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < Ds_Comptes.Tables["MesComptes"].Rows.Count - 1)
            {
                i++;
                remplir();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (i > 0)
            {
                i--;
                remplir();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = Ds_Comptes.Tables["MesComptes"].Rows.Count - 1;
            remplir();
        }
    }
}

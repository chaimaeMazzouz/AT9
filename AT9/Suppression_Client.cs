using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Suppression_Client : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("SELECT * from Client", g1.banque_connexion);
        DataView Dv_Delete = new DataView();
        DataView Dv_Courant = new DataView();
        public Suppression_Client()
        {
            InitializeComponent();
        }

        private void Suppression_Client_Load(object sender, EventArgs e)
        {
            try
            {

                Adp_Comptes.Fill(Ds_Banque, "MesClients");

                dataGridView1.DataSource = Ds_Banque.Tables["MesClients"];

                combo_Num_Client.DisplayMember = "Num_Client";
                combo_Num_Client.ValueMember = "Num_Client";
                combo_Num_Client.DataSource = Ds_Banque.Tables["MesClients"];

                Dv_Delete = new DataView(Ds_Banque.Tables["MesClients"], "", "", DataViewRowState.Deleted);
                dataGridView2.DataSource = Dv_Delete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combo_Num_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dv_Courant = new DataView(Ds_Banque.Tables["MesClients"], "Num_Client =" + combo_Num_Client.SelectedValue, "",
               DataViewRowState.CurrentRows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            try
            {
                Dv_Courant[0].Delete();
                MessageBox.Show("Suppression effectué");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suppression_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dv_Delete.Count != 0)
            {
                DialogResult res = MessageBox.Show("Voulez vous Appliquer les Suppressions?",
                    "Comfirmation Suppressions", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommandBuilder bldBanque = new SqlCommandBuilder(Adp_Comptes);
                        Adp_Comptes.Update(Ds_Banque, "MesClients");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

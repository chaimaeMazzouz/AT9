using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Suppression_Compte : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("select * from Compte", g1.banque_connexion);
        DataView Dv_Delete = new DataView();
        DataView Dv_Courant = new DataView();
        public Suppression_Compte()
        {
            InitializeComponent();
        }

        private void Suppression_Compte_Load(object sender, EventArgs e)
        {
            try
            {

                Adp_Comptes.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesComptes"];

                combo_Num_Compte.DisplayMember = "Num_Compte";
                combo_Num_Compte.ValueMember = "Num_Compte";
                combo_Num_Compte.DataSource = Ds_Banque.Tables["MesComptes"];

                Dv_Delete = new DataView(Ds_Banque.Tables["MesComptes"], "", "", DataViewRowState.Deleted);
                dataGridView2.DataSource = Dv_Delete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combo_Num_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dv_Courant = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + combo_Num_Compte.SelectedValue, "",
               DataViewRowState.CurrentRows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimerCompte_Click(object sender, EventArgs e)
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

        private void Suppression_Compte_FormClosing(object sender, FormClosingEventArgs e)
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
                        Adp_Comptes.Update(Ds_Banque, "MesComptes");
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

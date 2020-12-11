using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Modification_Compte : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Comptes = new SqlDataAdapter("select * from Compte", g1.banque_connexion);
        DataView Dv_Modifier = new DataView();
        DataView Dv_Courant = new DataView();
        public Modification_Compte()
        {
            InitializeComponent();
        }

        private void Modification_Compte_Load(object sender, EventArgs e)
        {
            try
            {
               
                Adp_Comptes.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesComptes"];

                combo_Num_Compte.DisplayMember = "Num_Compte";
                combo_Num_Compte.ValueMember = "Num_Compte";
                combo_Num_Compte.DataSource = Ds_Banque.Tables["MesComptes"];

                Dv_Modifier = new DataView(Ds_Banque.Tables["MesComptes"], "", "", DataViewRowState.ModifiedOriginal);
                dataGridView2.DataSource = Dv_Modifier;
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
                textNumClient.Text = Dv_Courant[0].Row["Num_Client"].ToString();
                textSolde.Text = Dv_Courant[0].Row["Solde"].ToString();
                comboTypeCompte.Text = Dv_Courant[0].Row["TypeC"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnModifierCompte_Click(object sender, EventArgs e)
        {
            try
            {
                Dv_Courant = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + combo_Num_Compte.SelectedValue, "",
               DataViewRowState.CurrentRows);
                Dv_Courant[0].BeginEdit();
                Dv_Courant[0]["Num_Client"] = textNumClient.Text;
                Dv_Courant[0]["TypeC"]= comboTypeCompte.Text;
                Dv_Courant[0].EndEdit();
                MessageBox.Show("Modification effectué");
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

        private void Modification_Compte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dv_Modifier.Count !=0)
            {
                DialogResult res = MessageBox.Show("Voulez vous Appliquer les Modifications?",
                    "Comfirmation Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
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

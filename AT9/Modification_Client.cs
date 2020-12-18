using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Modification_Client : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Clients = new SqlDataAdapter("select * from Client", g1.banque_connexion);
        DataView Dv_Modifier = new DataView();
        DataView Dv_Courant = new DataView();
        public Modification_Client()
        {
            InitializeComponent();
        }

        private void Modification_Client_Load(object sender, EventArgs e)
        {
            try
            {

                Adp_Clients.Fill(Ds_Banque, "MesClients");

                dataGridView1.DataSource = Ds_Banque.Tables["MesClients"];

                combo_Num_Client.DisplayMember = "Num_client";
                combo_Num_Client.ValueMember = "Num_client";
                combo_Num_Client.DataSource = Ds_Banque.Tables["MesClients"];

                Dv_Modifier = new DataView(Ds_Banque.Tables["MesClients"], "", "", DataViewRowState.ModifiedOriginal);
                dataGridView2.DataSource = Dv_Modifier;
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
                Dv_Courant = new DataView(Ds_Banque.Tables["MesClients"], "Num_client =" + combo_Num_Client.SelectedValue, "",
               DataViewRowState.CurrentRows);
                textNom.Text = Dv_Courant[0].Row["Nom_Client"].ToString();
                textPrenom.Text = Dv_Courant[0].Row["Prenom_Client"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            try
            {
                Dv_Courant = new DataView(Ds_Banque.Tables["MesClients"], "Num_client =" + combo_Num_Client.SelectedValue, "",
               DataViewRowState.CurrentRows);
                Dv_Courant[0].BeginEdit();
                Dv_Courant[0]["Nom_Client"] = textNom.Text;
                Dv_Courant[0]["Prenom_Client"] = textPrenom.Text;
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

        private void Modification_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dv_Modifier.Count != 0)
            {
                DialogResult res = MessageBox.Show("Voulez vous Appliquer les Modifications?",
                    "Comfirmation Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommandBuilder bldBanque = new SqlCommandBuilder(Adp_Clients);
                        Adp_Clients.Update(Ds_Banque, "MesClients");
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

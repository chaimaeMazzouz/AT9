using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Ajout__Mouvement : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Banque = new SqlDataAdapter("SELECT * from Mouvement", g1.banque_connexion);
        SqlDataAdapter Adp_Banque1 = new SqlDataAdapter("SELECT * from Compte", g1.banque_connexion);
        public Ajout__Mouvement()
        {
            InitializeComponent();
        }

        private void Ajout__Mouvement_Load(object sender, EventArgs e)
        {
            try
            {
                Adp_Banque.Fill(Ds_Banque, "MesMouvements");
                Adp_Banque1.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesMouvements"];
                dataGridView2.DataSource = Ds_Banque.Tables["MesComptes"];

                combo_Num_Compte.DisplayMember = "Num_Compte";
                combo_Num_Compte.ValueMember = "Num_Compte";
                combo_Num_Compte.DataSource = Ds_Banque.Tables["MesComptes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterMouvement_Click(object sender, EventArgs e)
        {
            if (textMontantMouvement.Text != "" && textSolde.Text != "" && combo_Num_Compte.Text != "")
            {
                if (radioVersement.Checked && Convert.ToDecimal(textSolde.Text)<= Convert.ToDecimal(textMontantMouvement.Text))
                {
                    MessageBox.Show("Solde inssuffissant");
                }
                else {
                    try
                    {
                        DataRow ligne = Ds_Banque.Tables["MesMouvements"].NewRow();
                        
                        ligne[1] = combo_Num_Compte.Text;
                        ligne[2] = textSolde.Text;
                        ligne[4] = DateTime.Now;
                        Ds_Banque.Tables["MesMouvements"].Rows.Add(ligne);
                        if (radioRetrait.Checked)
                        {
                            ligne[3] = "Retrait";
                            Dv_Compte[0]["Solde"] = Convert.ToDecimal(textSolde.Text) - Convert.ToDecimal(textMontantMouvement.Text);
                        }
                        else
                        {
                            ligne[3] = "Dépôt";
                            Dv_Compte[0]["Solde"] = Convert.ToDecimal(textSolde.Text) + Convert.ToDecimal(textMontantMouvement.Text);
                        }
                        textMontantMouvement.Clear();
                        combo_Num_Compte.SelectedIndex = 0;
                        MessageBox.Show("Ajout effectué");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
               
        }
        DataView Dv_Compte;
        private void combo_Num_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dv_Compte = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte=" +
                combo_Num_Compte.SelectedValue, "", DataViewRowState.CurrentRows);
            textSolde.Text = Dv_Compte[0].Row["Solde"].ToString();
        }

        private void btnEnregistrerQuiter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder blBanque = new SqlCommandBuilder(Adp_Banque);
                SqlCommandBuilder blBanque1 = new SqlCommandBuilder(Adp_Banque1);
                Adp_Banque.Update(Ds_Banque, "MesMouvements");
                Adp_Banque1.Update(Ds_Banque, "MesComptes");
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

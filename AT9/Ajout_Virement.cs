using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace AT9
{
    public partial class Ajout_Virement : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Banque = new SqlDataAdapter("SELECT * from Virement", g1.banque_connexion);
        SqlDataAdapter Adp_Banque1 = new SqlDataAdapter("SELECT * from Compte", g1.banque_connexion);

        public Ajout_Virement()
        {
            InitializeComponent();
        }

        private void Ajout_Virement_Load(object sender, EventArgs e)
        {
            try
            {
                Adp_Banque.Fill(Ds_Banque, "MesVirements");
                Adp_Banque1.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesVirements"];
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
        DataView Dv_Compte;
        private void btnAjouterVirement_Click(object sender, EventArgs e)
        {
            if (textMontantVirement.Text != "" && textSolde.Text != "" && combo_Num_Compte.Text != "")
            {
                if (radioDebiteur.Checked && Convert.ToDecimal(textSolde.Text) <= Convert.ToDecimal(textMontantVirement.Text))
                {
                    MessageBox.Show("Solde inssuffissant");
                }
                else
                {
                    try
                    {
                        DataRow ligne = Ds_Banque.Tables["MesVirements"].NewRow();

                        ligne[4] = DateTime.Now;
                        Ds_Banque.Tables["MesVirements"].Rows.Add(ligne);
                        if (radioCrediteur.Checked)
                        {
                            ligne[2] = combo_Num_Compte.Text;
                            Dv_Compte[0]["Solde"] = Convert.ToDecimal(textSolde.Text) + Convert.ToDecimal(textMontantVirement.Text);
                        }
                        else if (radioDebiteur.Checked)
                        {
                            ligne[1] = combo_Num_Compte.Text;
                            Dv_Compte[0]["Solde"] = Convert.ToDecimal(textSolde.Text) - Convert.ToDecimal(textMontantVirement.Text);
                        }
                        textMontantVirement.Clear();
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
                Adp_Banque.Update(Ds_Banque, "MesVirements");
                Adp_Banque1.Update(Ds_Banque, "MesVirements");
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

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
        DataView Dv_Virement;
        DataView Dv_Compte;

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

                combo_Num_Debiteur.DisplayMember = "Num_Compte";
                combo_Num_Debiteur.ValueMember = "Num_Compte";
                combo_Num_Debiteur.DataSource = Ds_Banque.Tables["MesComptes"];

                comboCrediteur.DisplayMember = "Num_Compte";
                comboCrediteur.ValueMember = "Num_Compte";
                comboCrediteur.DataSource = Ds_Banque.Tables["MesComptes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        decimal soldeDebiteur;
        decimal soldeCrediteur;
        private void btnAjouterVirement_Click(object sender, EventArgs e)
        {
            
            
            if (textMontantVirement.Text != "" && comboCrediteur.Text != "" && combo_Num_Debiteur.Text != "")
            {
                if (soldeDebiteur < Convert.ToDecimal(textMontantVirement.Text))
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

                        Dv_Compte[0]["Solde"] = soldeDebiteur + Convert.ToDecimal(textMontantVirement.Text);
                        ligne[1] = combo_Num_Debiteur.Text;

                        DataView dt = new DataView(Ds_Banque.Tables["MesComptes"]);
                        dt.RowFilter = "Num_Compte = '" + comboCrediteur.SelectedValue + "'";
                        Dv_Compte[0]["Solde"] = soldeCrediteur - Convert.ToDecimal(textMontantVirement.Text);
                        ligne[2] = comboCrediteur.Text;

                        textMontantVirement.Clear();
                        combo_Num_Debiteur.SelectedIndex = 0;
                        comboCrediteur.SelectedIndex = 0;
                        MessageBox.Show("Ajout effectué");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

       

        private void btnEnregistrerQuiter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder blBanque = new SqlCommandBuilder(Adp_Banque);
                SqlCommandBuilder blBanque1 = new SqlCommandBuilder(Adp_Banque1);
                Adp_Banque.Update(Ds_Banque, "MesVirements");
                Adp_Banque1.Update(Ds_Banque, "MesComptes");
                MessageBox.Show("Sauvgarde effectué!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void combo_Num_Debiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dv_Compte = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + combo_Num_Debiteur.SelectedValue, "", DataViewRowState.CurrentRows);

            soldeDebiteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
        }

        private void comboCrediteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dv_Compte = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + comboCrediteur.SelectedValue, "", DataViewRowState.CurrentRows);

            soldeCrediteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
        }
    }
}

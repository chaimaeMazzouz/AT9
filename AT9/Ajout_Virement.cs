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
                DataTable dtDebiteur = Ds_Banque.Tables["MesComptes"].Copy();
                combo_Num_Debiteur.DataSource = dtDebiteur;

                comboCrediteur.DisplayMember = "Num_Compte";
                comboCrediteur.ValueMember = "Num_Compte";
                DataTable dtCrediteur = Ds_Banque.Tables["MesComptes"].Copy();
                comboCrediteur.DataSource = dtCrediteur;
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
                        ligne[3] = textMontantVirement.Text;
                        Ds_Banque.Tables["MesVirements"].Rows.Add(ligne); 
                        Dv_Compte[0]["Solde"] = soldeDebiteur - Convert.ToDecimal(textMontantVirement.Text);
                        ligne[1] = combo_Num_Debiteur.Text;
                        textSoldeDeb.Text = Dv_Compte[0]["Solde"].ToString();
                        Dv_Compte = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + comboCrediteur.SelectedValue, "", DataViewRowState.CurrentRows);

                        soldeCrediteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
                        Dv_Compte[0]["Solde"] = soldeCrediteur + Convert.ToDecimal(textMontantVirement.Text);
                        ligne[2] = comboCrediteur.Text;
                        textSoldeCrediteur.Text = Dv_Compte[0]["Solde"].ToString();
                        //textMontantVirement.Clear();
                        //combo_Num_Debiteur.SelectedIndex = 0;
                        //comboCrediteur.SelectedIndex = 0;
                        MessageBox.Show("Ajout effectué");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("remplir les champs!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            textSoldeDeb.Text = soldeDebiteur.ToString();
        }

        
        private void comboCrediteur_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataView Dv_CompteCr = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + comboCrediteur.SelectedValue, "", DataViewRowState.CurrentRows);

            soldeCrediteur = Convert.ToDecimal(Dv_CompteCr[0]["Solde"]);
            textSoldeCrediteur.Text = soldeCrediteur.ToString();
        }
    }
}

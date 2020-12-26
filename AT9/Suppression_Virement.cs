using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace AT9
{
    public partial class Suppression_Virement : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Banque = new SqlDataAdapter("SELECT * from Virement", g1.banque_connexion);
        SqlDataAdapter Adp_Banque1 = new SqlDataAdapter("SELECT * from Compte", g1.banque_connexion);
        DataView Dv_Virement;
        DataView Dv_Vir_delete;
        DataView Dv_Compte;
        public Suppression_Virement()
        {
            InitializeComponent();
        }

        private void Suppression_Virement_Load(object sender, EventArgs e)
        {
            try
            {
                Adp_Banque.Fill(Ds_Banque, "MesVirements");
                Adp_Banque1.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesVirements"];
                dataGridView3.DataSource = Ds_Banque.Tables["MesComptes"];

                combo_Num_Ver.DisplayMember = "Num_Virement";
                combo_Num_Ver.ValueMember = "Num_Virement";
                combo_Num_Ver.DataSource = Ds_Banque.Tables["MesVirements"];


                Dv_Vir_delete = new DataView(Ds_Banque.Tables["MesVirements"], "", "", DataViewRowState.Deleted);
                dataGridView2.DataSource = Dv_Vir_delete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        int numDebiteur;
        int numCrediteur;
        decimal soldeDebiteur;
        decimal soldeCrediteur;
        private void combo_Num_Ver_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dv_Virement = new DataView(Ds_Banque.Tables["MesVirements"], "Num_Virement =" + combo_Num_Ver.SelectedValue, "",
             DataViewRowState.CurrentRows);
            numDebiteur = Convert.ToInt32(Dv_Virement[0]["Num_Debiteur"]);
           numCrediteur = Convert.ToInt32(Dv_Virement[0]["Num_Crediteur"]);
            Dv_Compte = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + numDebiteur, "", DataViewRowState.CurrentRows);
            soldeDebiteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
            textSoldeDeb.Text = soldeDebiteur.ToString();
           DataView Dv_CompteCre = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + numCrediteur, "", DataViewRowState.CurrentRows);
            soldeCrediteur = Convert.ToDecimal(Dv_CompteCre[0]["Solde"]);
            textSoldeCrediteur.Text = soldeCrediteur.ToString();
            textMontantVirement.Text = Dv_Virement[0]["Montant_Vr"].ToString();


        }

        private void btnSupprimerViremen_Click(object sender, EventArgs e)
        {
            if (soldeCrediteur < Convert.ToDecimal(Dv_Virement[0]["Montant_Vr"]))
            {
                MessageBox.Show("Solde inssuffissant");
            }
            else
            {
                try
                {
                   
                   Dv_Compte[0]["Solde"] = soldeDebiteur + Convert.ToDecimal(Dv_Virement[0]["Montant_Vr"]);
                    textSoldeDeb.Text = Dv_Compte[0]["Solde"].ToString();
                    Dv_Compte = new DataView(Ds_Banque.Tables["MesComptes"], "Num_Compte =" + numCrediteur, "", DataViewRowState.CurrentRows);
                    soldeCrediteur = Convert.ToDecimal(Dv_Compte[0]["Solde"]);
                    Dv_Compte[0]["Solde"] = soldeCrediteur - Convert.ToDecimal(Dv_Virement[0]["Montant_Vr"]);
                    textSoldeCrediteur.Text = Dv_Compte[0]["Solde"].ToString();

                    Dv_Virement[0].Delete();
                    MessageBox.Show("Suppression effectué");
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
    }
}

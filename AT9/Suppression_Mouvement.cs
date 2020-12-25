using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AT9
{
    public partial class Suppression_Mouvement : Form
    {
        static Global g1 = new Global();
        DataSet Ds_Banque = new DataSet();
        SqlDataAdapter Adp_Banque = new SqlDataAdapter("SELECT * FROM Mouvement ", g1.banque_connexion);
        SqlDataAdapter Adp_Banque1 = new SqlDataAdapter("SELECT * FROM Compte ", g1.banque_connexion);
        DataView Dv_Mvts = new DataView();
        DataView Dv_Mvts_delete = new DataView();
        DataView Dv_Comptes = new DataView();
        public Suppression_Mouvement()
        {
            InitializeComponent();
        }

        private void Suppression_Mouvement_Load(object sender, EventArgs e)
        {
            try
            {

                Adp_Banque.Fill(Ds_Banque, "MesMouvements");
                Adp_Banque1.Fill(Ds_Banque, "MesComptes");

                dataGridView1.DataSource = Ds_Banque.Tables["MesMouvements"];
                dataGridView3.DataSource = Ds_Banque.Tables["MesComptes"];
                combo_Num_Mouvement.DisplayMember = "Num_Mouvement";
                combo_Num_Mouvement.ValueMember = "Num_Mouvement";
                combo_Num_Mouvement.DataSource = Ds_Banque.Tables["MesMouvements"];
                Dv_Mvts_delete = new DataView(Ds_Banque.Tables["MesMouvements"], "", "", DataViewRowState.Deleted);
                dataGridView2.DataSource = Dv_Mvts_delete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int i;
        private void combo_Num_Mouvement_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
              
                Dv_Mvts = new DataView(Ds_Banque.Tables["MesMouvements"], "Num_Mouvement =" + combo_Num_Mouvement.SelectedValue, "",
               DataViewRowState.CurrentRows);
                Dv_Comptes = new DataView(Ds_Banque.Tables["MesComptes"],"","Num_Compte", DataViewRowState.CurrentRows);
                int numCompte = Convert.ToInt32(Dv_Mvts[combo_Num_Mouvement.SelectedIndex].Row["Num_Compte"]);
                int index = Dv_Comptes.Find(numCompte);

                 MessageBox.Show(""+numCompte);
                //i = combo_Num_Mouvement.SelectedIndex;
                //textSolde.Text = Dv_Comptes[index]["Solde"].ToString();



                //DataRelation dtRelation;
                //DataColumn MouvCol = Ds_Banque.Tables["MesMouvements"].Columns["Num_Compte"];
                //DataColumn CompCol = Ds_Banque.Tables["MesComptes"].Columns["Num_Compte"];

                //dtRelation = new DataRelation("ComptMouveRelation", CompCol, MouvCol);
                //Ds_Banque.Tables["MesMouvements"].ParentRelations.Add(dtRelation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSupprimerMouvement_Click(object sender, EventArgs e)
        {

          
           
                if (Dv_Mvts[0].Row["TypeM"].ToString() == "Dépôt" && Convert.ToDecimal(Dv_Comptes[0].Row["solde"]) <= Convert.ToDecimal(Dv_Mvts[0].Row["Montant"]))
                {
                    MessageBox.Show("Solde inssuffissant");
                }
                else
                {
                try
                {

                    switch (Dv_Mvts[0].Row["TypeM"])
                    {
                        case "Retrait":
                            Dv_Comptes[0].Row["solde"] = Convert.ToDecimal(Dv_Comptes[0].Row["solde"]) + Convert.ToDecimal(Dv_Mvts[0].Row["Montant"]);
                            break;
                        case "Dépôt":
                            Dv_Comptes[0].Row["solde"] = Convert.ToDecimal(Dv_Comptes[0].Row["solde"]) - Convert.ToDecimal(Dv_Mvts[0].Row["Montant"]);
                            break;
                    }
                    Dv_Mvts[0].Delete();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT9
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Navigation_Comptes());
        }

        private void ajoutCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Ajout_Compte());
        }

        private void modificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Modification_Compte());
        }

        private void suppressionCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Suppression_Compte());
        }

        private void navugationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Recherche_Clients());
        }

        private void ajoutClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Ajout_Client());
        }

        private void modificationClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new Modification_Client());
        }
    }
}

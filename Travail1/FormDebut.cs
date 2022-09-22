using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail1
{
    public partial class FormDebut : Form
    {
        public FormDebut()
        {
            InitializeComponent();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            if (txtJoueur1.Text != "" && txtJoueur2.Text != "")
            {
                string joueur1 = txtJoueur1.Text;
                string joueur2 = txtJoueur2.Text;
                Program.menuValidation(joueur1, joueur2);
                this.Close();
            }
            else
            {
                if (txtJoueur1.Text == "")
                {
                    error.SetError(txtJoueur1, "nom de joueur est requis");
                }
                if (txtJoueur2.Text == "")
                {
                    error.SetError(txtJoueur2, "nom de joueur est requis");
                }
            }
        }

        private void txtJoueur_TextChanged(object sender, EventArgs e) => error.Clear();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travail1.Controllers;
using Travail1.Models;
using Travail1.Models.de;

namespace Travail1.Controls
{
    public partial class JoueursUi : UserControl
    {
        private Joueur[] joueurs;
        public JoueursUi()
        {
            InitializeComponent();
        }

        public Joueur[] Joueurs { get => joueurs; set => SetJoueur(value); }

        private void SetJoueur(Joueur[]? joueurs)
        {
            if (joueurs is null)
            {
                lblNomJoueur1.Text = " ";
                lblNomJoueur2.Text = " ";
            }
            else
            {
                Desabonner();
            }
            this.joueurs = joueurs;
            if (joueurs is not null)
            {
               InitAffichage();
            }
        }
        private void Desabonner()
        {
            if (joueurs is not null)
            {
                foreach (Joueur joueur in joueurs)
                {
                    // add a eventhandeler in joueur
                }
            }
        }
        private void rafraichirePointJoueur(Joueur[]? joueurs)
        {
            if (joueurs is null)
            {
                lblPointJoueur1.Text = " ";
                lblPointJoueur2.Text = " ";
            }
        }
        private void InitAffichage()
        {
            lblNomJoueur1.Text = joueurs[0].Nom;
            lblNomJoueur2.Text= joueurs[1].Nom;
        }
    }
}

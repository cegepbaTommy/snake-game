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
                lblPointJoueur1.Text = "0";
                lblPointJoueur2.Text = "0";
            }
            else
            {
                Desabonner();
            }
            this.joueurs = joueurs;
            if (joueurs is not null)
            {
                InitAffichage();
                Abonner();
            }
        }
        private void Desabonner()
        {
            if (joueurs is not null)
            {
                foreach (Joueur joueur in joueurs)
                {
                    joueur.PointChanged -= RafraichirePointJoueur;
                }
            }
        }
        private void Abonner()
        {
            if (joueurs is not null)
            {
                foreach (Joueur joueur in joueurs)
                {
                    joueur.PointChanged += RafraichirePointJoueur;
                }
            }
        }
        private void RafraichireTourJoueur(object? sender, int point)
        {

        }
        private void RafraichirePointJoueur(object? sender, int point)
        {
            if (sender is not null)
            {
                Joueur joueur = (Joueur)sender;
                if (joueur.Id == 0)
                {
                    lblPointJoueur1.Text = point.ToString();
                }
                if (joueur.Id == 1)
                {
                    lblPointJoueur2.Text = point.ToString();
                }
            }

        }
        private void JoueurCourant(int joueurId)
        {
            lblTourJoueur.Text = joueurs[joueurId].Nom;
        }
        private void InitAffichage()
        {
            lblNomJoueur1.Text = joueurs[0].Nom;
            lblNomJoueur2.Text = joueurs[1].Nom;
            lblTourJoueur.Text = joueurs[0].Nom;
        }
    }
}

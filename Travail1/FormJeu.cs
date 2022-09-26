using Travail1.Controllers;
using Travail1.Controls;
using Travail1.Models;

namespace Travail1
{
    public partial class FormJeu : Form
    {
        private Controleur controleur;
        private AffichageJoueur[] affichageJoueurs;

        public FormJeu(string joueur1, string joueur2)
        {
            InitializeComponent();
            controleur = new Controleur(joueur1, joueur2);
            picPlancheJeu.Image = controleur.DessinerPlancheJeu();
            InitAffichageJoueurs();
            foreach (Joueur joueur in controleur.Joueurs)
            {
                joueur.ABouger += Joueur_ABouger;
            }
        }

        private void Joueur_ABouger(object? sender, int e)
        {
            affichageJoueurs[controleur.TourJoueur].reload();
        }

        private void InitAffichageJoueurs()
        {
            affichageJoueurs = new AffichageJoueur[controleur.Joueurs.Length];
            for (int i = 0; i < controleur.Joueurs.Length; ++i)
            {
                affichageJoueurs[i] = new AffichageJoueur(controleur.Joueurs[i]);
            }
            picPlancheJeu.Controls.Add(affichageJoueurs[0]);
            for (int i = 1; i < affichageJoueurs.Length; ++i)
            {
                affichageJoueurs[i - 1].Controls.Add(affichageJoueurs[i]);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            controleur.avancerJoueurDe();
        }
    }
}

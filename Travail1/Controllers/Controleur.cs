using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Controls;
using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.de;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;
        private int tourJoueur;

        public Joueur[] Joueurs { get => joueurs; }
        public int TourJoueur { get => tourJoueur; set => tourJoueur = value; }

        public Controleur(string joueur1, string joueur2)
        {
            InitialiserCases();
            InitialiserJoueurs(joueur1, joueur2);
            TourJoueur = 0;
        }

        private void InitialiserCases()
        {
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(0), i);
            }
        }

        private void InitialiserJoueurs(string joueur1, string joueur2)
        {
            joueurs = new Joueur[2];
            joueurs[0] = new Joueur(0, joueur1, Color.Blue);
            joueurs[1] = new Joueur(1, joueur2, Color.Red);
        }

        public Bitmap DessinerPlancheJeu()
        {
            Bitmap bitmap = new Bitmap(801, 801);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                foreach (var uneCase in cases)
                {
                    uneCase.Dessiner(graphics);
                }
            }
            return bitmap;
        }
        public void avancerJoueurDe()
        {
            De de6 = new De(6);
            int resultat = de6.brasser();
            joueurs[TourJoueur].bouger(resultat);
            if (TourJoueur < joueurs.Length - 1)
            {
                TourJoueur += 1;
            }
            else
            {
                TourJoueur = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;

        public Joueur[] Joueurs { get => joueurs; }

        public Controleur()
        {
            InitialiserCases();
            InitialiserJoueurs();
        }

        private void InitialiserCases()
        {
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(0), i);
            }
        }

        private void InitialiserJoueurs()
        {
            joueurs = new Joueur[2];
            joueurs[0] = new Joueur(0, "joueur1", Color.Blue);
            joueurs[1] = new Joueur(1, "joueur2", Color.Red);
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
    }
}

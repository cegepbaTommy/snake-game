using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models;
using Travail1.Models.CaseAbstract;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        int memoire;
        private CaseAbstract[] cases;
        //private Case[] cases;
        private Joueur[] joueurs;

        public Joueur[] Joueurs { get => joueurs; }

        public Controleur(string joueur1, string joueur2)
        {
            InitialiserCases();
            InitialiserJoueurs(joueur1, joueur2);
        }

        private void InitialiserCases()
        {
            cases = new CaseAbstract[64];
            int z = 0;
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(0), i);

            }
            for (int x = z; x < 3; x++)
            {
                Thread.Sleep(200);
                Random rand = new Random();
                int noCase = rand.Next(1, 57);

                if (memoire == noCase)
                {
                    z = z - 1;
                }
                else
                {

                    cases[noCase] = new CaseEchelle(new Points(0), noCase);
                    //cases[i] = new Case(new Points(0), i);
                    memoire = noCase;
                    
                }

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
    }
}

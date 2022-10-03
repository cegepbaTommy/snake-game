using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Case
{
    class CaseAbstract
    {
        public abstract class CaseAbstract
        {
            protected Points points;
            protected int position;
            private int largeur;

            public int Points { get => points.ObtenirPoints(); }

            public CaseAbstract(Points points, int position)
            {
                this.points = points;
                this.position = position;
                this.largeur = 100;
            }
            public abstract void Dessiner(Graphics graphics);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.de;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    internal class CaseSaut : CaseAbstract
    {
        protected Points points;
        protected int position;
        private int largeur;
        public int Points { get => points.ObtenirPoints(); }
        public CaseSerpent(Points points, int position) : base(points, position)
        {
            this.points = points;
            this.position = position;
            this.largeur = 100;
        }
        public int sautPosition()
        {

            De de3 = new De(3);
            position = position + de3.brasser();
            return position;
        }
        protected PointF ObtenirCoordonees()
        {
            int y = (7 - (position / 8));
            int x = (position % 8);
            if ((position / 8) % 2 == 1)
            {
                x = 7 - x;
            }
            return new PointF { X = x * largeur, Y = y * largeur };
        }
        public override void Dessiner(Graphics graphics)
        {
            var coordonees = ObtenirCoordonees();
            var font = new Font("Calibri", 20);
            graphics.DrawRectangle(Pens.yellow, coordonees.X, coordonees.Y, largeur, largeur);
            graphics.DrawString((position + 1).ToString(), font, Brushes.Blue, coordonees.X + 30, coordonees.Y + 30);
        }
    }
}

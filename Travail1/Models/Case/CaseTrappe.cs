using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    internal class CaseTrappe : Case
    {
        public CaseTrappe(Points points, int position) : base(points, position)
        {
            this.position = position;
        }
        public void diminunerPosition()
        {
            Random rand = new Random();
            int nbreCaseADiminuer;
            nbreCaseADiminuer = rand.Next(5, 11);
            position = position - nbreCaseADiminuer;
        }
        public override string ToString()
        {
            return position.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    internal class CaseEchelle : Case
    {

        public CaseEchelle(Points points, int position) : base(points, position)
        {
            this.position = position;
        }
        public void genererCaseEchelle()
        {
            int positionInitial = position;
            int positionFinal = position + 10;// modifier le 10 par la variable qui va indiquer la fin de l'échelle
            position = position + (positionFinal - positionInitial);

        }
        public override string ToString()
        {
            return position.ToString();
        }
    }
}

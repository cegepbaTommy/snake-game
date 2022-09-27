using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    internal class CaseSerpent : Case
    {
        public CaseSerpent(Points points, int position) : base(points, position)
        {
            this.position = position;
        }
        public void genererCaseSerpent()
        {
            int positionInitial = position;
            int positionFinal = position - 10;// modifier le 10 par la variable qui va indiquer la fin du serpent
            position = position - (positionFinal - positionInitial);

        }
    }
}

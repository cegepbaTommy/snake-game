using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    public class Points
    {
        private int valeur;

        public Points(int valeur)
        {
            this.valeur = valeur;
        }

        public int ObtenirPoints() 
        {
            return valeur;
        }
    }
}

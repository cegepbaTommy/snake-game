using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.de
{
    public class De
    {
        private readonly int NombreDeFace;

        public int NombreDeFace1 => NombreDeFace;
        public De(int face)
        {
            NombreDeFace = face;
        }
        public int brasser()
        {
            Random random = new Random();
            int valeur = random.Next(1, NombreDeFace + 1);
            return valeur;
        }
    }
}

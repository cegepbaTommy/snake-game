using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.de;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    internal class CaseSaut : Case
    {
        public CaseSaut(Points points, int position) : base(points, position)
        {
            this.position = position;
        }
        public int sautPosition()
        {
            
            De de3 = new De(3);
            position = position + de3.brasser();
            return position;
        }
    }
}

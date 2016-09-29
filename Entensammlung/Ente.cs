using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entensammlung
{
    class Ente : IComparable<Ente>
    {
        public int Größe;
        public EntenArt Art;

        public int CompareTo(Ente vergleichsEnte)
        {
            if (this.Größe > vergleichsEnte.Größe)
                return 1;
            else if (this.Größe < vergleichsEnte.Größe)
                return -1;
            else
                return 0;
        }
    }
}

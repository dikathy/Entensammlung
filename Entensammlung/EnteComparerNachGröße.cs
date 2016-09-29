using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entensammlung
{
    class EnteComparerNachGröße : IComparer<Ente>
    {
        public int Compare(Ente x, Ente y)
        {
            if (x.Größe < y.Größe)
                return -1;
            else if (x.Größe > y.Größe)
                return 1;
            else
                return 0;
        }
    }
}

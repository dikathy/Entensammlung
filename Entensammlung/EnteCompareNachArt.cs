using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entensammlung
{
    class EnteCompareNachArt : IComparer<Ente>
    {
        public int Compare(Ente x, Ente y)
        {
            if (x.Art < y.Art)
                return 1;
            else if (x.Art > y.Art)
                return -1;
            else
                return 0;
        }
    }
}

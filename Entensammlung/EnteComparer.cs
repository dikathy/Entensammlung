using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entensammlung
{
    enum Sortierung
    {
        GrößeDannArt,
        ArtDannGröße
    }

    class EnteComparer : IComparer<Ente>
    {
        public Sortierung SortierenNach = Sortierung.GrößeDannArt;

        public int Compare(Ente x, Ente y)
        {
           if(SortierenNach == Sortierung.GrößeDannArt)
            {
                if (x.Größe < y.Größe)
                    return -1;
                else if (x.Größe > y.Größe)
                    return 1;
                else
                    if (x.Art < y.Art)
                            return -1;
                        else if (x.Art > y.Art)
                            return 1;
                        else
                            return 0;
            }
           else
            {
                if (x.Art < y.Art)
                    return -1;
                else if (x.Art > y.Art)
                    return 1;
                else
                    if (x.Größe < y.Größe)
                        return -1;
                    else if (x.Größe > y.Größe)
                        return 1;
                    else
                        return 0;
            }
        }
    }
}

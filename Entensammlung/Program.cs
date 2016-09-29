using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entensammlung
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ente> enten = new List<Ente>()
            {
                new Ente() {Art = EntenArt.Stockente, Größe = 40 },
                new Ente() {Art = EntenArt.Moschusente, Größe = 42 },
                new Ente() {Art = EntenArt.Lockente, Größe = 35 },
                new Ente() {Art = EntenArt.Moschusente, Größe = 28 },
                new Ente() {Art = EntenArt.Stockente, Größe = 37 },
                new Ente() {Art = EntenArt.Lockente, Größe = 36 },

            };

            EnteComparer ec = new EnteComparer();

            ec.SortierenNach = Sortierung.GrößeDannArt;
            enten.Sort(ec);
            EntenAusgeben(enten);

            ec.SortierenNach = Sortierung.ArtDannGröße;
            enten.Sort(ec);
            EntenAusgeben(enten);

            Console.ReadKey();
        }

        public static void EntenAusgeben(List<Ente> enten)
        {
            foreach(Ente ente in enten)
            {
                Console.WriteLine(ente.Größe.ToString() + "-cm " + ente.Art.ToString());
            }
            Console.WriteLine("Enten-Ende!");
        }
    }
}

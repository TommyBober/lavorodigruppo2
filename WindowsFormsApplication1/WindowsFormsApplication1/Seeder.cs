using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   static class Seeder
    {
        private static string[] nomi = { "Luca", "Paolo", "Matteo", "angelo", "Federico", "Tommaso", "Nicolo'", "Giovanni", "Andrea", "Maurizio" };

        private static string[] cognomi = { "De Luca", "Barbieri", "Ricci", "Verdi", "Russo", "Costanzo", "Padoin", "Bianchi", "Rossi", "Ferrari" };

        private static string[] codicefiscale = { "DZMRCC54E55F937I", "DQZGRM45C51B741O", "NWLRHY68S44A302I" };

        private static string[] titoli = { "Il Codice Da Vinci", "1984", "Le memorie di Adriano", "Lo Hobbit", "Dieci Piccoli Indiani", "Harry Potter", "Il Piccolo Principe", "Cent'Anni di solitudine" };

        private static string[] autori = { "Umberto Eco", "Charles Dickens", "Osho", "Agatha Christie" };

        private static string[] isbn = { "99-6832-775-1", "13-4563-283-1", "67-3172-645-4" };

        private static string[] genere = { "commedia", "tragedia", "giallo" };

        private static Random rnd = new Random();

        public static User generateUser()
        {
            DateTime d = new DateTime(rnd.Next(1950, 2005), rnd.Next(1, 12), rnd.Next(1, 30)); 
            User u = new User(nomi[rnd.Next(0, 10)], cognomi[rnd.Next(0, 10)], codicefiscale[rnd.Next(0, 3)], d);
            return u;

        }

        public static Libro generateLibri()

        {
            Libro l = new Libro(titoli[rnd.Next(0, 8)], autori[rnd.Next(0, 3)], genere[rnd.Next(0, 3)], isbn[rnd.Next(0, 3)]);
            return l;

        }
    }
}

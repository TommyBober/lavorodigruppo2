using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   static class Seeder
    {
        private static string[] nomi = { "Tizio", "Caio", "Sempronio", "angelo", "matteo", "breel", "donald", "Bello", "boh", "maurizio" };

        private static string[] cognomi = { "F1go", "Ogbonna", "Salveenee", "EMBOLO", "Trump", "costanzo", "padoin", "boh", "Maria", "eh" };

        private static string[] codicefiscale = { "dnsa", "Csaasd", "grguen" };

        private static string[] titoli = { "24 centimetri(metri)", "il suro", "il segreto del bug", "Il mio nome e' salveenee", "Scherzo epico finito male", "call of salveenee", "non pago afito", "buonatera a tutti" };

        private static string[] autori = { "salvini quello vero", "io", "me", "me stesso" };

        private static string[] isbn = { "1234", "4567", "6789" };

        private static string[] genere = { "commedia", "tragedia", "giallo" };

        private static Random rnd = new Random();

        public static User generateUser()//no input, output user
        {
            DateTime d = new DateTime(rnd.Next(1950, 2005), rnd.Next(1, 12), rnd.Next(1, 30)); // fede genious 
            User u = new User(nomi[rnd.Next(0, 10)], cognomi[rnd.Next(0, 10)], codicefiscale[rnd.Next(0, 3)], d);
            return u;

        }

        public static Libro generateLibri()//no input, output libro

        {
            Libro l = new Libro(titoli[rnd.Next(0, 8)], autori[rnd.Next(0, 3)], genere[rnd.Next(0, 3)], isbn[rnd.Next(0, 3)], false);
            return l;

        }
    }
}

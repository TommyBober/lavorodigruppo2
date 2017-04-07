using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms; // importato per potere richiamare elementi form 1

namespace WindowsFormsApplication1
{
    class Libro
    {

        public string titolo { get; set; }

        public string autore { get; set; }

        public string genere { get; set; }

        public string isbn { get; set; }

        public Boolean prestato { get; set; }

        public override string ToString()
        {
            return  titolo + ", "  + autore;
            
        }

        public string Describe()
        {
            return "titolo: " + titolo + ", genere: " + genere + Environment.NewLine + 
                "Autore: " + autore + ", isbn: " + isbn;
        }

        public bool Presta(User u)
        { 
            if ((!prestato) && (u.listaLibri.Count < 6))
            {
                u.listaLibri.Add(this);
                prestato = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Libro(string titolo, string autore, string genere, string isbn) //costruttore
        {
            this.titolo = titolo;
            this.autore = autore;
            this.genere = genere;
            this.isbn = isbn;
        }
    }
}

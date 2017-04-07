using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Libro
    {

        public string titolo { get; set; }

        public string autore { get; set; }

        public string genere { get; set; }

        public string isbn { get; set; }

        public Boolean prestato { get; set; }

        public User possessore { get; set; }

        public override string ToString()
        {
            return  titolo + ", "  + autore;
            
        }

        public string Describe()
        {
            string output;
            output = "Titolo: " + titolo + ", Genere: " + genere + Environment.NewLine +
                "Autore: " + autore + ", ISBN: " + isbn + Environment.NewLine;
            if (prestato)
            {
                output += "Questo Libro e' gia' stato prestato a " + possessore.ToString();
            }
            else
            {
                output += "Questo Libro e' disponibile per il prestito.";
            }
            return output;
        }

        public bool Presta(User u)
        {
            possessore = u;
            if ((!prestato) && (u.listaLibri.Count < 6))
            {
                possessore.listaLibri.Add(this);
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

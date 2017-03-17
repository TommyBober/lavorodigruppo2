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
        private string _titolo;
        public string titolo { get { return _titolo; } }

        private string _autore;
        public string autore { get { return _autore; } }

        private string _genere;
        public string genere { get { return _genere; } }

        private string _isbn;
        public string isbn { get { return _isbn; } }

        private Boolean _prestato; //sola lettura dice se è prestato o no 
        public Boolean prestato { set { } get { return _prestato; } }

        public override string ToString()  //no input, output string
        {
            string output = titolo + " " + isbn;
            return output;
        }

        public string Describe() //no input, output string
        {
            string output = titolo + " " + genere + " " + autore + " " + isbn;
            return output;
        }

        public string Presta(User ricevitore) //input user , output string
        {
            string output;
            if (prestato)
            {
                output = "questo libro e' gia' stato prestato.";
                return output;
            }
            else
            {
               // ricevitore.libriPrestati.Add(this);
                prestato = true;
                output = "questo libro e' stato presato a " + ricevitore.ToString();
                return output;
            }
        }

        public Libro(string titolo, string autore, string genere, string isbn, bool prestato) //costruttore
        {
            _titolo = titolo;
            _autore = autore;
            _genere = genere;
            _isbn = isbn;
            _prestato = prestato;
        }
    }
}

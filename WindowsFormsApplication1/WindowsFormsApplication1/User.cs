using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms; // importato per potere richiamare elementi form 1

namespace WindowsFormsApplication1
{
    class User
    {
        public List<Libro> libriPrestati;
        string _nome;
        string nome { get { return _nome; } set { } }

        string _cognome;
        string cognome { get { return _cognome; } set { } }

        string _CodiceF;
        string CodiceF { get { return _CodiceF; } set { } }

        private DateTime _dataNascita;
        public DateTime dataNascita { get { return _dataNascita; } set { } }

        public override string ToString()  //no input, output string
        {
            return nome + " " + cognome;
        }

        public string Describe() //no input, output string
        {
            string output = nome + " " + cognome + " " + dataNascita + " " + CodiceF + " " + libriPrestati.Count;
            return output;
        }

        public string DescribeBook() //no input, output string 
        {
            string output = "";
            if (libriPrestati.Count == 0)
            {
                output = "questo utente non possiede libri in prestito.";
            }
            else
            {
                foreach (Libro l in libriPrestati)
                {
                    output = l.Describe() + "\r\n";
                }
            }
            return output;
        }

        public User(string nome, string cognome, string codiceF, DateTime dataNascita) //costruttore
        {
            _nome = nome;
            _cognome = cognome;
            _CodiceF = codiceF;
            _dataNascita = dataNascita;
        }
    }
}

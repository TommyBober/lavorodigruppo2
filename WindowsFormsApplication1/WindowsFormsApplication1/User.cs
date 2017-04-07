using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class User
    {
        public List<Libro> listaLibri = new List<Libro>();

        public string nome { get; set; }

        public string cognome { get; set; }

        public string codiceFiscale { get; set; }

        public DateTime dataNascita { get; set; }

        public override string ToString()
        {
            return nome + " " + cognome;
        }

        public string Describe()
        {
            return nome + " " + cognome + ", Data di nascita: " + dataNascita.ToShortDateString() + Environment.NewLine
                + "L'utente possiede " + listaLibri.Count + " libri: " + Environment.NewLine
                + DescribeBook();
        }

        public string DescribeBook()
        {
            string output = "" ;
            
            foreach (Libro l in listaLibri)
            {
                 output += l.ToString() + Environment.NewLine;
            }
            
            return output;
        }

        public User(string nome, string cognome, string codiceF, DateTime dataNascita) 
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
            this.dataNascita = dataNascita;
        }
    }
}

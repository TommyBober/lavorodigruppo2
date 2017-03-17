using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                listNomi.Items.Add(Seeder.generateUser() as User);
                listLibri.Items.Add(Seeder.generateLibri() as Libro); // sostituito titolo con to string 
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listNomi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            User u = listNomi.SelectedItem as User;
            textBoxNome.Text = u.Describe();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void libroButton_Click(object sender, EventArgs e)
        {
            Libro l = listLibri.SelectedItem as Libro;
            textBoxLibro.Text = l.Describe();
        }

        private void prestaButton_Click(object sender, EventArgs e)
        {
            Libro l = listLibri.SelectedItem as Libro;
            User u = listNomi.SelectedItem as User;
            l.Presta(u);
            textBoxPresta.Text = "Il libro " + l.titolo + " e' stato prestato a " + u.nome;
        }
    }
}


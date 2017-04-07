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
            for (int i = 0; i < 30; i++)
            {
                listNomi.Items.Add(Seeder.generateUser());
                listLibri.Items.Add(Seeder.generateLibri());
            }
            listLibri.SelectedIndex = 0;
            listNomi.SelectedIndex = 0;
            
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
            textBox.Text = u.Describe();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void libroButton_Click(object sender, EventArgs e)
        {
            Libro l = listLibri.SelectedItem as Libro;
            textBox.Text = l.Describe();
        }

        private void prestaButton_Click(object sender, EventArgs e)
        {
            Libro l = listLibri.SelectedItem as Libro;
            User u = listNomi.SelectedItem as User;
            if (l.Presta(u))
            {
                textBox.Text = "Il libro " + l.titolo + " e' stato prestato a " + u.ToString();
            }
            else
            {
                textBox.Text = "Il libro " + l.titolo + " e' gia' stato prestato";
            }
            
        }
    }
}


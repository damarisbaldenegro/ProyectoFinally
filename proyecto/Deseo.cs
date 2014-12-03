using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Deseo : Form
    {
        public Deseo()
        {
            InitializeComponent();
        }
        public Contactos contactoActual {get; set;}
        private void Buscar_Click(object sender, EventArgs e)
        {
            MainForm main  =new  MainForm();
            main.Show();
            this.Hide();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
				
				
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Agenda
{
	
	public partial class Buscar : Form
	{
		public Buscar()
		{
			InitializeComponent();
		}
		
		public Contactos contactoSeleccionado {set; get;}
		
		
		
		
		
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			
			
			dvgTodos.DataSource=Metodos.Buscar(txtNom.Text);
			
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if (dvgTodos.SelectedRows.Count==1)
			
			{
				int id=Convert.ToInt32(dvgTodos.CurrentRow.Cells[0].Value);
				contactoSeleccionado=Metodos.ObtenerContactos(id);
				this.Close();
			}
			else MessageBox.Show("Debe escoger una fila");			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			MainForm abrir = new MainForm();
			abrir.Show();
			this.Hide();			
		}

        private void dvgTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
	}
}

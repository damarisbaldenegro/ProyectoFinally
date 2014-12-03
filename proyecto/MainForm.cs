
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Agenda
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Contactos contactoActual {get; set;}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
            try
            {
                Contactos contactos = new Contactos();

                contactos.nombre = txtnom.Text.Trim();
                contactos.domicilio = txtDom.Text.Trim();
                contactos.email = txtEma.Text.Trim();
                contactos.tel = txtTel.Text.Trim();
                contactos.Celular = txtCel.Text.Trim();


                int resultado = Metodos.Agregar(contactos);
                if (resultado > 0)
                {
                    MessageBox.Show("Contacto guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar el contacto", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch{
                if (txtnom.Text == "" && txtDom.Text == "" && txtCel.Text == "" && txtEma.Text == "" && txtTel.Text == "")

                    MessageBox.Show("Introduce todos los datos por favor", "ERROR");
            }
			
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
          
            try
            {
                Contactos contactos = new Contactos();

                contactos.nombre = txtnom.Text.Trim();
                contactos.domicilio = txtDom.Text.Trim();
                contactos.email = txtEma.Text.Trim();
                contactos.tel = txtTel.Text.Trim();
                contactos.Celular = txtCel.Text.Trim();

                contactos.id = contactoActual.id;

                if (Metodos.Editar(contactos) > 0)
                {
                    MessageBox.Show("Contacto editado", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Introduce todos los datos por favor", "ERROR");
               
            }
            
		}
	
		void BtnEliminarClick(object sender, EventArgs e)
		{
            try{
                if (txtnom.Text=="" && txtDom.Text=="" && txtCel.Text==""  && txtEma.Text=="" && txtTel.Text=="")
                
                    MessageBox.Show("Introduce todos los datos por favor", "ERROR"); 
                
                
                }
            catch{
			if (MessageBox.Show ("¿Desea continuar?","¿Estás seguro?",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
			{
				if (Metodos.Eliminar(contactoActual.id)>0)
				{
					MessageBox.Show("Eliminado correctamente","Eliminado",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("no se puso eliminar","no se eliminó", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
            
                MessageBox.Show ("No se encontro  contacto que Eliminar", "Falló",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

	
		
		public void BtnBuscarClick(object sender, EventArgs e)
		{
			Buscar _buscar = new Buscar();
			_buscar.ShowDialog();
			
			
			if (_buscar.contactoSeleccionado != null)
			{
				
				contactoActual = _buscar.contactoSeleccionado;
				
				txtnom.Text=_buscar.contactoSeleccionado.nombre;
				txtDom.Text=_buscar.contactoSeleccionado.domicilio;
				txtEma.Text=_buscar.contactoSeleccionado.email;
				txtTel.Text=_buscar.contactoSeleccionado.tel;
				txtCel.Text=_buscar.contactoSeleccionado.Celular;
				
				
				
			}
		}
		
		void TxtEmaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void TxtCelTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void NombreClick(object sender, EventArgs e)
		{
			
		}
		
		void Label8Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}

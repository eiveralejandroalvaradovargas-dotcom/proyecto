using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace proyecto1
{
	
	public partial class FormConsultarUsuarios : Form
	{
		public FormConsultarUsuarios()
		{
			InitializeComponent();
			Actualizacion();
		}
		
		public void Actualizacion()
		{
			dataUsuario.DataSource = null;
			dataUsuario.DataSource = MainForm.ListaUsuario;
			
			cmbID.DataSource = null;
			cmbID.DataSource = MainForm.ListaUsuario;
			cmbID.DisplayMember = "Id";
			cmbID.ValueMember = "Id";
		}
		


		
		void CmbRolSelectedIndexChanged(object sender, EventArgs e)
		{
			string Seleccion = cmbRol.SelectedItem.ToString();
			if(Seleccion == "Todos")
			{
				Actualizacion();
			}
			else
			{
				dataUsuario.DataSource = null;
				var filtro = MainForm.ListaUsuario.Where(x => x.Rol == Seleccion).ToList();
				dataUsuario.DataSource = filtro;
			}
		}
		
		void CmbIDSelectedIndexChanged(object sender, EventArgs e)
		{
			Usuarios seleccionado = (Usuarios)cmbID.SelectedItem;
	        if (seleccionado != null)
	        {
	            textNombre.Text = seleccionado.Username;
	            textContraseña.Text = seleccionado.Password;
	        }
	        else
	        {
	            textNombre.Text = "";
	            textContraseña.Text = "";
	        }
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			Usuarios modificar = (Usuarios)cmbID.SelectedItem;
	        if (modificar == null)
	        {
	            MessageBox.Show("Selecciona un usuario de la lista.");
	            return;
	        }

	        if (modificar.Rol == "Admin")
	        {
	            MessageBox.Show("No se puede modificar un usuario con rol Admin.");
	            return;
	        }

	        modificar.Username = textNombre.Text;
	        modificar.Password = textContraseña.Text;
	        
	        Actualizacion();
	        MessageBox.Show("Usuario modificado correctamente.");
	    }
		
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			Usuarios Eliminer = (Usuarios)cmbID.SelectedItem;
			MainForm.ListaUsuario.Remove(Eliminer);
			Actualizacion();
			MessageBox.Show("Usuario eliminado.");
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			FormRegistrarAdmin pantallaRegistrarAdmin = new FormRegistrarAdmin();
			pantallaRegistrarAdmin.Show();
			Actualizacion();
		}
		

	}
}

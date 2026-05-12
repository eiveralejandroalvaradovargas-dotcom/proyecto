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
			
			foreach(Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
			Verificar();
		}
		
		public void Actualizacion()
		{
			cmbRol.Items.Clear();
			if (proyecto1.Modelos.Idiomas.English)
			{
				cmbRol.Items.Add("All");
				cmbRol.Items.Add("Player");
				cmbRol.Items.Add("Administrator");
			}
			else
			{
				cmbRol.Items.Add("Todos");
				cmbRol.Items.Add("Jugador");
				cmbRol.Items.Add("Administrador");
			}
			
			cmbRol.SelectedIndex = 0;
			
			dataUsuario.DataSource = null;
			dataUsuario.DataSource = MainForm.ListaUsuario;
			
			cmbID.DataSource = null;
			cmbID.DataSource = MainForm.ListaUsuario;
			cmbID.DisplayMember = "Id";
			cmbID.ValueMember = "Id";
		}
		


		
		void CmbRolSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbRol.SelectedIndex == 0)
			{
				dataUsuario.DataSource = null;
				dataUsuario.DataSource = MainForm.ListaUsuario;
			}
			else
			{
				string Seleccion = cmbRol.SelectedItem.ToString();
				
				if (Seleccion == "Player") 
				{
					Seleccion = "Jugador";
				}
				if(Seleccion == "Administrator")
				{
					Seleccion = "Admin";
				}
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
	        	string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Select a user in the list"
					: "Selecciona un usuario de la lista";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);return;
	        }

	        if (modificar.Rol == "Admin")
	        {
	        	string Mensaje = proyecto1.Modelos.Idiomas.English
					? "A user with admin rol can´t be edit"
					: "No se puede modificar un usuario con rol Admin.";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
	            MessageBox.Show(Mensaje, Title);
	            return;
	        }

	        modificar.Username = textNombre.Text;
	        modificar.Password = textContraseña.Text;
	        
	        Actualizacion();
	        
	        string Message = proyecto1.Modelos.Idiomas.English
					? "Sucessfully User edited"
					: "Usuario modificado correctamente.";
				
				string Titlee = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
	            MessageBox.Show(Message, Titlee);
	            return;
	 
	    }
		
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			Usuarios Eliminer = (Usuarios)cmbID.SelectedItem;
			MainForm.ListaUsuario.Remove(Eliminer);
			Actualizacion();
			
			string Mensaje = proyecto1.Modelos.Idiomas.English
					? "User deleted"
					: "Usuario eliminado.";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
	            MessageBox.Show(Mensaje, Title);
		
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			FormRegistrarAdmin pantallaRegistrarAdmin = new FormRegistrarAdmin();
			pantallaRegistrarAdmin.Show();
			Actualizacion();
		}
		
		void Btn_VolverClick(object sender, EventArgs e)
		{
			if (this.Owner != null)
			{
				this.Owner.Show();
			}
			this.Close();
		}
		
		void Verificar()
		{
			
				if (proyecto1.Modelos.Idiomas.English == true)
				{
					lbl_Title.Text = "User Management";
					lbl_Usuario.Text = "Username";
					lbl_Contraseña.Text = "Password";
					lbl_Ver.Text = "Show";
					
					btnRegistrar.Text = "Sign up";
					btnModificar.Text = "Edit";
					btnEliminar.Text = "Delete";
					btn_Volver.Text = "Back";
				}
				else
				{
					lbl_Title.Text = lbl_Title.Tag.ToString();
					lbl_Usuario.Text = lbl_Usuario.Tag.ToString();
					lbl_Contraseña.Text = lbl_Contraseña.Tag.ToString();
					lbl_Ver.Text = lbl_Ver.Tag.ToString();
					
					btnRegistrar.Text = btnRegistrar.Tag.ToString();
					btnModificar.Text = btnModificar.Tag.ToString();
					btnEliminar.Text = btnEliminar.Tag.ToString();
					btn_Volver.Text = btn_Volver.Tag.ToString();
				}
				
				Actualizacion();
				
		}
	}
}

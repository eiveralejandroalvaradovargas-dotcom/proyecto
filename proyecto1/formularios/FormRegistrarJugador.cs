using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
	
namespace proyecto1
{

	public partial class FormRegistrarJugador : Form
	{
		public FormRegistrarJugador()
		{
			InitializeComponent();
			
			foreach(Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
			Verificar();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			
			
			string user = textUsuario.Text.Trim();
			string pass = textContraseña.Text.Trim();
			
			if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
			{
				MessageBox.Show("Complete todos los campos", "Aviso");
				return;
			}
			
			var usuarios = BaseDatos.ObtenerUsuarios();
			if(usuarios.Exists(u => u.Username == user))
			{
				MessageBox.Show("Ese nombre de usuario ya está registrado", "Registro fallido");
				return;
			}
			
			Usuarios nuevo = new Usuarios(0, user, pass, "Jugador");
			BaseDatos.AgregarUsuario(nuevo);
			MessageBox.Show("Jugador registrado exitosamente", "Registro terminado");
			this.Close();
		}
			void Verificar()
			{
				if (proyecto1.Modelos.Idiomas.English == true)
				{
					lbl_Title.Text = "Sign up";
					lbl_Usuario.Text = "Username";
					lbl_Contraseña.Text = "Password";
					
					btnRegistrar.Text = "Done";
				}
				else
				{
					lbl_Title.Text = lbl_Title.Tag.ToString();
					lbl_Usuario.Text = lbl_Usuario.Tag.ToString();
					lbl_Contraseña.Text = lbl_Contraseña.Tag.ToString();
					
					btnRegistrar.Text = btnRegistrar.Tag.ToString();
				}
			}
		
	}
}

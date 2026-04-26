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
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			
			
			string user = textUsuario.Text;
			string pass = textContraseña.Text;
			string rol = "Jugador";
			
			if(user != "" && pass!= "")
			{
				bool Encontrado = false;
				foreach(Usuarios Objeto in MainForm.ListaUsuario)
				{
					if (Objeto.Username == user && Objeto.Password == pass)
					{
						Encontrado = true;
						break;
					}
				}
				if(Encontrado)
				{
					MessageBox.Show("Estos datos le pertenecen a una cuenta existente", "Registro fallido", MessageBoxButtons.RetryCancel);
				}
				else
				{
				int nuevoId = MainForm.ListaUsuario.Count + 1;
                MainForm.ListaUsuario.Add(new Usuarios(nuevoId, user, pass, rol));
                MessageBox.Show("Jugador registrado exitosamente");
                this.Close();
				}
			}
			else
			{
				MessageBox.Show("Complete todos los campos", "Error en el registro");
			}
			
			
		}
	}
}

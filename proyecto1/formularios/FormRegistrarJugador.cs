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
					string Mensaje = proyecto1.Modelos.Idiomas.English
						? "This information belows to a exist account"
						: "Estos datos le pertenecen a una cuenta existente";
						
					string Title = proyecto1.Modelos.Idiomas.English
						? "Registration failed"
						: "Registro fallido";
					
					MessageBox.Show(Mensaje,Title,MessageBoxButtons.RetryCancel);
				}
				else
				{
				int nuevoId = MainForm.ListaUsuario.Count + 1;
                MainForm.ListaUsuario.Add(new Usuarios(nuevoId, user, pass, rol));
                
                string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Player signed up sucessfully!"
					: "Jugador registrado exitosamente";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Registration done"
					: "Registro terminado";
                
                MessageBox.Show(Mensaje, Title);
                this.Close();
				}
			}
			else
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Please, complete all the fields"
					: "Complete todos los campos";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
			}
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


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace proyecto1
{
	public partial class FormRegistrarAdmin : Form
	{
		public FormRegistrarAdmin()
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
			
			if(user != "" && pass != "")
			{
				bool Encontradol = false;
				foreach (Usuarios Objeto in MainForm.ListaUsuario)
				{
					if(Objeto.Username == user && Objeto.Password == pass)
					{
						Encontradol = true;
						break;
					}
				}
				if(Encontradol)
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
                MainForm.ListaUsuario.Add(new Usuarios(nuevoId, user, pass, "Admin"));
                
                string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Administrator signed up sucessfully!"
					: "Administrador registrado exitosamente!";
				
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
					lbl_Title.Text = "Sign up Administrator";
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

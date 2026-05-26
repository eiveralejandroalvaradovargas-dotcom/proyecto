using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace proyecto1
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();			
			foreach (Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
			Verificar();
		}

		void BtnAccederClick(object sender, EventArgs e)
		{
			string Username = textUsuario.Text;
			string Password = textContraseña.Text;
			
			if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
			{
				MessageBox.Show("Complete todos los campos","Aviso");
				return;
			}
			
			List<Usuarios> usuarios = BaseDatos.ObtenerUsuarios();
			Usuarios encontrar = usuarios.Find(u => u.Username == Username && u.Password == Password);
			if(textUsuario.Text != "" && textContraseña.Text != "")
			{
				if(encontrar != null)
					{
					if(encontrar.Rol == "Admin")
						{
							string Mensaje = proyecto1.Modelos.Idiomas.English
							? "Well howdy, Administrator"
							: "Bienvenido Administrador";
						
						string Title = proyecto1.Modelos.Idiomas.English
							? "Login sucessfully"
							: "Inicio de sesion exitoso";
						
						MessageBox.Show(Mensaje, Title);
							FormMenuAdmin MenuAdmin = new FormMenuAdmin();
							MenuAdmin.Owner = this;
							MenuAdmin.Show();
							this.Hide();
							
						}
					else
						{
						
						string Mensaje = proyecto1.Modelos.Idiomas.English
							? "Well howdy, player"
							: "Bienvenido Jugador";
						
						string Title = proyecto1.Modelos.Idiomas.English
							? "Login sucessfully"
							: "Inicio de sesion exitoso";
						
						MessageBox.Show(Mensaje, Title);
						
							FormMenuJugador Menu_Jugador = new FormMenuJugador(encontrar.Username, encontrar.Id);
							Menu_Jugador.Owner = this;
							Menu_Jugador.Show();
							
							this.Hide();
						}
					Limpiar_Casillas();
					}
				else
					{
						string Mensaje = proyecto1.Modelos.Idiomas.English
							? "Wrong username or password"
							: "Usuario o contraseña incorrectos";
						
						string Title = proyecto1.Modelos.Idiomas.English
							? "Failed to sign in"
							: "Fallo al iniciar";
						
						MessageBox.Show(Mensaje, Title);
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

		public void BtnRegistrarClick(object sender, EventArgs e)
		{
			FormRegistrarJugador Registro = new FormRegistrarJugador();
			Registro.ShowDialog();
		}
		

		
		void Btn_Cambiar_IdiomaClick(object sender, EventArgs e)
		{
			proyecto1.Modelos.Idiomas.English = !proyecto1.Modelos.Idiomas.English;
			Verificar();
		}
		
		void Verificar()
		{
			if(proyecto1.Modelos.Idiomas.English == true)
			{
				lblTitulo.Text = "Login";
				lblUsuario.Text = "Username";
				lblContraseña.Text = "Password";
				lblDesc_shift_btn.Text = "Wanna shifts the language?";
				
				btn_Cambiar_Idioma.Text = "Shifts Language";
				btnAcceder.Text = "Log in";
				btnRegistrar.Text = "Sign up";
			}
			else
			{
				lblTitulo.Text = lblTitulo.Tag.ToString();
				lblUsuario.Text = lblUsuario.Tag.ToString();
				lblContraseña.Text = lblContraseña.Tag.ToString();
				lblDesc_shift_btn.Text = lblDesc_shift_btn.Tag.ToString();
				
				btn_Cambiar_Idioma.Text = btn_Cambiar_Idioma.Tag.ToString();
				btnAcceder.Text = btnAcceder.Tag.ToString();
				btnRegistrar.Text = btnRegistrar.Tag.ToString();
			}
		}
		
		void MainFormActivated(object sender, EventArgs e)
		{
			Verificar();
		}
		
		void Limpiar_Casillas()
		{
			textUsuario.Clear();
			textContraseña.Clear();
		}
	}
}
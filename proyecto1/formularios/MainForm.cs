using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto1
{

	public partial class MainForm : Form
	{
		public static List<Usuarios> ListaUsuario = new List<Usuarios>();
		public static List<ModuloEducativo> ListaModulos = new List<ModuloEducativo>();
		public static List<Pregunta> ListaPreguntas = new List<Pregunta>();
		public static List<PuntuacionJugador> PuntuacionesGlobales = new List<PuntuacionJugador>();
	
		public MainForm()
		{
			InitializeComponent();
			CargarDatosIniciales();
			
			foreach (Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
		}
		
		 private void CargarDatosIniciales()
        {
            //Usuarios de prueba
            ListaUsuario.Add(new Usuarios(1, "Eiver", "12345", "Admin"));
            ListaUsuario.Add(new Usuarios(2, "Juan", "123", "Jugador"));
            
            //Módulos
            ListaModulos.Add(new ModuloEducativo(1, "Arquitectura del computador", "Hardware y componentes"));
            ListaModulos.Add(new ModuloEducativo(2, "Antropología", "Estudio del ser humano"));
            ListaModulos.Add(new ModuloEducativo(3, "Cálculo", "Derivadas e integrales"));
            ListaModulos.Add(new ModuloEducativo(4, "Deporte", "Actividad física"));
            
            //ANTROPOLOGÍA
            Pregunta p1 = new Pregunta(1, 2, "¿Qué estudia la antropología?", "What does anthropology study?", "");
            p1.opciones.Add(new opcion(1, "Cultura humana", "Human culture", true));
            p1.opciones.Add(new opcion(2, "Matemáticas", "Mathematics", false));
            p1.opciones.Add(new opcion(3, "Computadoras", "Computers", false));
            p1.opciones.Add(new opcion(4, "Física", "Physics", false));
            ListaPreguntas.Add(p1);
            
            //CÁLCULO
            Pregunta p2 = new Pregunta(2, 3, "¿Cuál es la derivada de x²?", "What is the derivative of x²?", "");
            p2.opciones.Add(new opcion(1, "2x", "2x", true));
            p2.opciones.Add(new opcion(2, "x", "x", false));
            p2.opciones.Add(new opcion(3, "x²", "x²", false));
            p2.opciones.Add(new opcion(4, "2", "2", false));
            ListaPreguntas.Add(p2);
            
            //ARQUITECTURA
            Pregunta p3 = new Pregunta(3, 1, "¿Qué significa CPU?", "What does CPU stand for?", "imagenes/cpu.jpg");
            p3.opciones.Add(new opcion(1, "Unidad Central de Procesamiento", "Central Processing Unit", true));
            p3.opciones.Add(new opcion(2, "Memoria RAM", "RAM memory", false));
            p3.opciones.Add(new opcion(3, "Disco duro", "Hard drive", false));
            p3.opciones.Add(new opcion(4, "Tarjeta gráfica", "Graphics card", false));
            ListaPreguntas.Add(p3);
            
            //DEPORTE
            Pregunta p4 = new Pregunta(4, 4, "¿Cuántos jugadores tiene un equipo de fútbol en el campo?", "How many players on a soccer field?", "");
            p4.opciones.Add(new opcion(1, "11", "11", true));
            p4.opciones.Add(new opcion(2, "10", "10", false));
            p4.opciones.Add(new opcion(3, "12", "12", false));
            p4.opciones.Add(new opcion(4, "9", "9", false));
            ListaPreguntas.Add(p4);
            
            
            ///temporal///
            
        }

		void BtnAccederClick(object sender, EventArgs e)
		{
			string Username = textUsuario.Text;
			string Password = textContraseña.Text;
			
			Usuarios encontrar = ListaUsuario.Find(x => x.Username == Username && x.Password == Password);
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
							Limpiar_Casillas();
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
							Menu_Jugador.Show();
							this.Hide();
						}
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
				lblDesc_shift_btn.Text = "Wanna shifts the language?, just press here :D";
				lblDesc_shift_btn_2.Text = "This option can´t be change after";
				
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
				lblDesc_shift_btn_2.Text = lblDesc_shift_btn_2.Tag.ToString();
				
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
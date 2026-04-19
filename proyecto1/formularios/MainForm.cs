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
							MessageBox.Show("Bienvenido Administrador");
							FormMenuAdmin MenuAdmin = new FormMenuAdmin();
							MenuAdmin.Show();
							this.Hide();
						}
					else
						{
							MessageBox.Show("Bienvenido Jugador");
							FormJuego juego = new FormJuego(encontrar.Id);
							juego.Show();
							this.Hide();
						}
					}
				else
					{
						MessageBox.Show("Usuario o contraseña incorrectos");
					}
			}
			else
			{
				MessageBox.Show("por favor, complete ambos campos");
			}
		}

		public void BtnRegistrarClick(object sender, EventArgs e)
		{
			FormRegistrarJugador Registro = new FormRegistrarJugador();
			Registro.ShowDialog();
		}
		

	}
}
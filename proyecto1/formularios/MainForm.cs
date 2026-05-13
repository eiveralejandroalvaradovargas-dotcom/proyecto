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
             Pregunta p5 = new Pregunta(5, 2, "¿A que se refiere el proceso de hominizacion?", "What does the process of hominization?", "");
            p5.opciones.Add(new opcion(1, "Al desarrollo de la cultura, el lenguaje y las creencias religiosas", "The development of culture, language, and religious beliefs.", false));
            p5.opciones.Add(new opcion(2, "A la evolución biológica y física que dio origen a la especie humana.", "The biological and physical evolution that gave rise to the human species.", true));
            p5.opciones.Add(new opcion(3, "Al aprendizaje de normas sociales dentro de una comunidad.", "The learning of social norms within a community.", false));
            p5.opciones.Add(new opcion(4, "A la creación de herramientas tecnológicas avanzadas.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p5);
 			
			Pregunta p6 = new Pregunta(6, 2, "¿Cuál es la principal característica del proceso de humanización?", "What does the process of hominization?", "");
            p6.opciones.Add(new opcion(1, "La bipedestación y el aumento de la capacidad craneal.", "The development of culture, language, and religious beliefs.", false));
            p6.opciones.Add(new opcion(2, "La adaptación genética al medio ambiente natural.", "The biological and physical evolution that gave rise to the human species.", false));
            p6.opciones.Add(new opcion(3, "El surgimiento de la cultura, el pensamiento simbólico y la técnica.", "The learning of social norms within a community.", true));
            p6.opciones.Add(new opcion(4, "El estudio de los fósiles en yacimientos arqueológicos.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p6);
            
            Pregunta p7 = new Pregunta(7, 2, "Según la antropología filosófica, ¿cómo se define la relación entre el hombre y la cultura?", "What does the process of hominization?", "");
            p7.opciones.Add(new opcion(1, "El hombre es un ser puramente biológico que no necesita de la cultura.", "The development of culture, language, and religious beliefs.", false));
            p7.opciones.Add(new opcion(2, "La cultura es un accesorio opcional que no afecta la esencia humana.", "The biological and physical evolution that gave rise to the human species.", false));
            p7.opciones.Add(new opcion(3, "El hombre es un ser cultural por naturaleza, con características biológicas especiales.", "The learning of social norms within a community.", true));
            p7.opciones.Add(new opcion(4, "La cultura es únicamente el conjunto de artes plásticas de una sociedad.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p7);
            
            Pregunta p8 = new Pregunta(8, 2, "¿Qué aspecto analiza la antropología cuando se enfoca en el pensamiento y la trascendencia?", "What does the process of hominization?", "");
            p8.opciones.Add(new opcion(1, "La capacidad del ser humano para realizar cálculos matemáticos complejos.", "The development of culture, language, and religious beliefs.", false));
            p8.opciones.Add(new opcion(2, "La dimensión espiritual y la búsqueda de sentido más allá de la existencia material.", "The biological and physical evolution that gave rise to the human species.", true));
            p8.opciones.Add(new opcion(3, "El funcionamiento neuronal durante el sueño profundo.", "The learning of social norms within a community.", false));
            p8.opciones.Add(new opcion(4, "La historia de las instituciones políticas en el siglo XX.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p8);
            
            Pregunta p9 = new Pregunta(9, 2, "En el contexto del estudio antropológico, ¿qué busca comprender la antropología de la muerte", "What does the process of hominization?", "");
            p9.opciones.Add(new opcion(1, "Los procesos biológicos de descomposición celular.", "The development of culture, language, and religious beliefs.", false));
            p9.opciones.Add(new opcion(2, "El costo económico de los servicios funerarios en la actualidad.", "The biological and physical evolution that gave rise to the human species.", false));
            p9.opciones.Add(new opcion(3, "Cómo las distintas culturas significan, ritualizan y trascienden el fin de la vida.", "The learning of social norms within a community.", true));
            p9.opciones.Add(new opcion(4, "La esperanza de vida estadística de una población determinada.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p9);
            
            Pregunta p10 = new Pregunta(10, 2, "¿Cuál es el enfoque principal de la tecnoantropología?", "What does the process of hominization?", "");
            p10.opciones.Add(new opcion(1, "El estudio exclusivo de las herramientas de piedra de la prehistoria.", "The development of culture, language, and religious beliefs.", false));
            p10.opciones.Add(new opcion(2, "La relación e impacto mutuo entre el ser humano y las nuevas tecnologías.", "The biological and physical evolution that gave rise to the human species.", true));
            p10.opciones.Add(new opcion(3, "La reparación de equipos informáticos en entornos industriales.", "The learning of social norms within a community.", false));
            p10.opciones.Add(new opcion(4, "La historia de la Revolución Industrial en Europa.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p10);
            
            Pregunta p11 = new Pregunta(11, 2, "¿Qué método es característico de la etnografía para el estudio de los grupos humanos?", "What does the process of hominization?", "");
            p11.opciones.Add(new opcion(1, "El análisis de laboratorio de muestras de ADN.", "The development of culture, language, and religious beliefs.", false));
            p11.opciones.Add(new opcion(2, "El trabajo de campo basado en la observación directa y la convivencia.", "The biological and physical evolution that gave rise to the human species.", true));
            p11.opciones.Add(new opcion(3, "La realización de encuestas telefónicas masivas.", "The learning of social norms within a community.", false));
            p11.opciones.Add(new opcion(4, "El estudio de documentos contables históricos.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p11);
            
            Pregunta p12 = new Pregunta(12, 2, "¿Qué área de la antropología se encarga de estudiar las ideologías y las estructuras de poder?", "What does the process of hominization?", "");
            p12.opciones.Add(new opcion(1, "Antropología económica.", "The development of culture, language, and religious beliefs.", false));
            p12.opciones.Add(new opcion(2, "Antropología política.", "The biological and physical evolution that gave rise to the human species.", true));
            p12.opciones.Add(new opcion(3, "Antropología biológica.", "The learning of social norms within a community.", false));
            p12.opciones.Add(new opcion(4, "Antropología lingüística.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p12);
            
            Pregunta p13 = new Pregunta(13, 2, "¿Cual es el enfoque de la antropologia venezolana?", "What does the process of hominization?", "");
            p13.opciones.Add(new opcion(1, "Planetas.", "The development of culture, language, and religious beliefs.", false));
            p13.opciones.Add(new opcion(2, "Identidad y tradiciones.", "The biological and physical evolution that gave rise to the human species.", true));
            p13.opciones.Add(new opcion(3, "Antropología biológica.", "The learning of social norms within a community.", false));
            p13.opciones.Add(new opcion(4, "Clima del pais.", "The creation of advanced technological tools.", false));
            ListaPreguntas.Add(p13);

            
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
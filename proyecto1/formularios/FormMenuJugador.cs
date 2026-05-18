using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto1
{
	public partial class FormMenuJugador : Form
	{
		public string Name_Ingresado;
		public int ID_Ingresado;
		
		public FormMenuJugador(string Name_Recibido, int ID_Recibido)
		{
			InitializeComponent();
			this.Name_Ingresado = Name_Recibido;
			this.ID_Ingresado = ID_Recibido;
			
			if (proyecto1.Modelos.Idiomas.English == true)
			{
				Bienvenida.Text = "Welcome, " + Name_Ingresado + "!";
				
				Modulos_Menu.Text = "Show Modules";
			}
			else
			{
				Bienvenida.Text = "Bienvenido, " + Name_Ingresado + "!";
				Modulos_Menu.Text = "Ver Modulos";
			}
			
			
			Seleccion_Modulo_Pts.DataSource = BaseDatos.ObtenerModulos();
		    Seleccion_Modulo_Pts.DisplayMember = "Nombre";
		    Seleccion_Modulo_Pts.ValueMember = "Id";
		    
		}
		
		void Seleccion_Modulo_PtsSelectedIndexChanged(object sender, EventArgs e)
		{
			if(Seleccion_Modulo_Pts.SelectedItem != null)
			{
				int idModulo = (int)Seleccion_Modulo_Pts.SelectedValue;
				int puntos = BaseDatos.ObtenerPuntuacion(ID_Ingresado, idModulo);
				Puntuacion_Modulo.Text = "puntuacion: "+puntos;
			}
		}
		
		void Modulos_MenuClick(object sender, EventArgs e)
		{
			FormJuego Juego = new FormJuego (this.ID_Ingresado, this.Name_Ingresado);
			Juego.Show();
			this.Hide();
		}
	}
}

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
				
			Bienvenida.Text = "Bienvenido, " + Name_Ingresado + "!";
			
			
			Seleccion_Modulo_Pts.DataSource = MainForm.ListaModulos;
		    Seleccion_Modulo_Pts.DisplayMember = "Nombre";
		    
		}
		
		void Seleccion_Modulo_PtsSelectedIndexChanged(object sender, EventArgs e)
		{
			//ModuloEducativo Modulo_Elegidoc (ModuloEducativo) Seleccion_Modulo_Pts.SelectedItem;
		}
		
		void Modulos_MenuClick(object sender, EventArgs e)
		{
			FormJuego Juego = new FormJuego (this.ID_Ingresado, this.Name_Ingresado);
			Juego.Show();
			this.Hide();
		}
	}
}

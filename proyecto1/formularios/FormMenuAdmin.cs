using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto1
{

	public partial class FormMenuAdmin : Form
	{
		
		public FormMenuAdmin()
		{
			InitializeComponent();
			
			foreach (Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
			Verificar();
		}

		

		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			FormConsultarUsuarios pantallaConsultaUsuarios = new FormConsultarUsuarios();
			pantallaConsultaUsuarios.Owner = this;
			pantallaConsultaUsuarios.Show();
			this.Hide();
		}
		
		void BtnGestionarPreguntasClick(object sender, EventArgs e)
		{
			FormGestionPreguntas pantallaPregunta = new FormGestionPreguntas();
			pantallaPregunta.Owner = this;
			pantallaPregunta.Show();
			this.Hide();
		}
		
		void BtnGestionarModulosClick(object sender, EventArgs e)
		{
			FormModulos pantallaModulos = new FormModulos();
			pantallaModulos.Owner = this;
			pantallaModulos.Show();
			this.Hide();
		}
		
		void Btn_Cerrar_SesionClick(object sender, EventArgs e)
		{
			proyecto1.Modelos.Idiomas.English = false;
			
			
			if (this.Owner != null)
			{
				this.Owner.Show();
			}
			this.Close();
		}
		
		void Verificar()
		{
			if (proyecto1.Modelos.Idiomas.English == true)
			{
				lb_Titulo.Text = "Admin´s Menu";
				BtnGestionarPreguntas.Text = "To manage questions";
				btnGestionarModulos.Text = "To manage modules";
				btnConsultar.Text = "To manage users";
				btn_Cerrar_Sesion.Text = "Log out";
				btnOpciones.Text= "Options";
			}
			else
			{
				lb_Titulo.Text = lb_Titulo.Tag.ToString();
				BtnGestionarPreguntas.Text = BtnGestionarPreguntas.Tag.ToString();
				btnGestionarModulos.Text = btnGestionarModulos.Tag.ToString();
				btnConsultar.Text = btnConsultar.Tag.ToString();
				btn_Cerrar_Sesion.Text = btn_Cerrar_Sesion.Tag.ToString();
				btnOpciones.Text = btnOpciones.Tag.ToString();
			}
		}
		
		void BtnOpcionesClick(object sender, EventArgs e)
		{
			FormOpciones PantallaOpciones = new FormOpciones();
			PantallaOpciones.Owner = this;
			PantallaOpciones.Show();
			this.Hide();
		}
	}
}

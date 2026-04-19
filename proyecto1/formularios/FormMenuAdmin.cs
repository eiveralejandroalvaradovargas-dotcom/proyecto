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
		}

		

		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			FormConsultarUsuarios pantallaConsultaUsuarios = new FormConsultarUsuarios();
			pantallaConsultaUsuarios.Show();
			this.Hide();
		}
		
		void BtnGestionarPreguntasClick(object sender, EventArgs e)
		{
			FormGestionPreguntas pantallaPregunta = new FormGestionPreguntas();
			pantallaPregunta.Show();
			this.Hide();
		}
		
		void BtnGestionarModulosClick(object sender, EventArgs e)
		{
			FormModulos pantallaModulos = new FormModulos();
			pantallaModulos.Show();
			this.Hide();
		}
	}
}

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

<<<<<<< HEAD
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

        // ESTE ERA EL MÉTODO QUE FALTABA Y HACÍA COLAPSAR AL DISEÑADOR
        void Añadir_preguntasClick(object sender, EventArgs e)
        {
            // Puedes poner aquí el código para abrir la pantalla de añadir preguntas, por ejemplo:
            // FormAñadirPreguntas pantallaAñadir = new FormAñadirPreguntas();
            // pantallaAñadir.Show();
            // this.Hide();
            MessageBox.Show("Abriendo añadir preguntas..."); 
        }
    }
=======
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
			}
			else
			{
				lb_Titulo.Text = lb_Titulo.Tag.ToString();
					
				BtnGestionarPreguntas.Text = BtnGestionarPreguntas.Tag.ToString();
				btnGestionarModulos.Text = btnGestionarModulos.Tag.ToString();
				btnConsultar.Text = btnConsultar.Tag.ToString();
				btn_Cerrar_Sesion.Text = btn_Cerrar_Sesion.Tag.ToString();
			}
		}
	}
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
}

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
}

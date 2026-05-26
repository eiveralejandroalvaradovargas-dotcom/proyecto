using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace proyecto1
{
    public partial class FormMenuJugador : Form
    {
        public string Name_Ingresado;
        public int ID_Ingresado;
        private int moduloSeleccionado;
        
        public FormMenuJugador(string Name_Recibido, int ID_Recibido)
        {
            InitializeComponent();
            
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Region = new Region(path);
            
            this.Name_Ingresado = Name_Recibido;
            this.ID_Ingresado = ID_Recibido;
            
            
            var modulos = BaseDatos.ObtenerModulos();
            
            
            if (modulos == null || modulos.Count == 0)
            {
            	if (proyecto1.Modelos.Idiomas.English)
            	{
            		MessageBox.Show("No modules available. Please contact the administrator.");
            	}
            	else
            	{
            		MessageBox.Show("No hay módulos disponibles. Contacte al administrador.");
            	}
                return;
            }
            
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
            
         
            Seleccion_Modulo_Pts.DataSource = modulos;
            Seleccion_Modulo_Pts.DisplayMember = "NombreEs";
            Seleccion_Modulo_Pts.ValueMember = "Id";
            
            
            if (modulos.Count > 0)
            {
                
                Seleccion_Modulo_Pts.SelectedIndex = 0;
                
                
                var primerModulo = modulos[0];
                moduloSeleccionado = primerModulo.Id;
                
                
                int puntos = BaseDatos.ObtenerPuntuacion(ID_Ingresado, moduloSeleccionado);
                Puntuacion_Modulo.Text = "Puntuación: " + puntos;
                
                
                System.Diagnostics.Debug.WriteLine("Módulo inicial seleccionado: " + moduloSeleccionado);
            }
        }
        
        void Seleccion_Modulo_PtsSelectedIndexChanged(object sender, EventArgs e)
        {
            if(Seleccion_Modulo_Pts.SelectedItem != null)
            {
                try
                {
                    int idModulo = (int)Seleccion_Modulo_Pts.SelectedValue;
                    moduloSeleccionado = idModulo;
                    
                    int puntos = BaseDatos.ObtenerPuntuacion(ID_Ingresado, idModulo);
                    Puntuacion_Modulo.Text = "Puntuación: " + puntos;
                    
                    System.Diagnostics.Debug.WriteLine("Módulo seleccionado: " + idModulo);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error al seleccionar módulo: " + ex.Message);
                    Puntuacion_Modulo.Text = "Puntuación: Error";
                }
            }
        }
        
        void Modulos_MenuClick(object sender, EventArgs e)
        {
            if (moduloSeleccionado != 0)
            {
                FormJuego Juego = new FormJuego(this.ID_Ingresado, this.Name_Ingresado, moduloSeleccionado);
                Juego.Owner = this;
                Juego.Show();
                this.Hide();
            }
            else
            {
            	if (proyecto1.Modelos.Idiomas.English)
            	{
            		MessageBox.Show("Please select a module before starting the game.");
            	}
            	else
            	{
            		MessageBox.Show("Por favor, seleccione un módulo antes de comenzar el juego.");
            	}
            }
        }
        
        void Btn_Cerrar_SesionClick(object sender, EventArgs e)
        {
            proyecto1.Modelos.Idiomas.English = false;
            
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Hide();
        }
    }
}

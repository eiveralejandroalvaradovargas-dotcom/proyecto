using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace proyecto1
{
    public partial class FormJuego : Form
    {
        private int idUsuario;
        private string Nombre_de_Usuario;
        private int idModuloSeleccionado;
        private LogicaJuego logica;
        private List<Pregunta> preguntasActuales;
        private int indicePregunta;
        
        public FormJuego(int idUsuario, string Nombre_de_Usuario, int idModulo)
        {
            this.idUsuario = idUsuario;
            this.Nombre_de_Usuario = Nombre_de_Usuario;
            this.idModuloSeleccionado = idModulo;
            logica = new LogicaJuego();
            InitializeComponent();
            
            cmbModulo.Visible = false;
            this.Text = "Juego - " + ObtenerNombreModulo(idModulo);
            
            CargarIdiomas();
            CargarPreguntasDelModulo(idModulo);
        }
        
        private string ObtenerNombreModulo(int idModulo)
        {
            var modulos = BaseDatos.ObtenerModulos();
            var modulo = modulos.FirstOrDefault(m => m.Id == idModulo);
            if (modulo != null)
                return modulo.NombreEs;
            else
                return "Módulo " + idModulo;
        }
        
        private void CargarPreguntasDelModulo(int idModulo)
        {
            preguntasActuales = BaseDatos.ObtenerPreguntas()
                .Where(p => p.IdModulo == idModulo).ToList();
            indicePregunta = 0;
            logica.ResetearJuego();
            ActualizarPuntuacion();
            
            if (preguntasActuales.Count == 0)
            {
                if (logica.IdiomaActual == "ES")
                    MessageBox.Show("No hay preguntas para este modulo.");
                else
                    MessageBox.Show("There are no questions for this module.");
                    
                btnResponder.Enabled = false;
            }
            else
            {
                btnResponder.Enabled = true;
                MostrarPregunta();
            }
        }
        
        private void CargarIdiomas()
        {
            cmbIdioma.Items.Clear();
            cmbIdioma.Items.Add("Español");
            cmbIdioma.Items.Add("Ingles");
            cmbIdioma.SelectedIndex = 0;
            logica.IdiomaActual = "ES";
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        void CmbIdiomaSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedIndex == 0)
                logica.IdiomaActual = "ES";
            else
                logica.IdiomaActual = "EN";
            
            MostrarPregunta();
        }
        
        private void MostrarPregunta()
        {
            if(preguntasActuales == null || preguntasActuales.Count == 0)
            {
                if (logica.IdiomaActual == "ES")
                    lblPregunta.Text = "No hay preguntas para este modulo.";
                else
                    lblPregunta.Text = "There are no questions for this module.";
                    
                LimpiarOpciones();
                LimpiarImagen();
                return;
            }
            
            if(indicePregunta >= preguntasActuales.Count)
            {
                string mensajeFinal;
                string tituloFinal;
                
                if (logica.IdiomaActual == "ES")
                {
                    mensajeFinal = "Modulo completado!\nPuntuacion final: " + logica.PuntajeActual;
                    tituloFinal = "Completado";
                }
                else
                {
                    mensajeFinal = "Module completed!\nFinal score: " + logica.PuntajeActual;
                    tituloFinal = "Completed";
                }
                
                MessageBox.Show(mensajeFinal, tituloFinal, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GuardarPuntuacion();
                btnResponder.Enabled = false;
                return;
            }
            
            Pregunta p = preguntasActuales[indicePregunta];
            
            if (logica.IdiomaActual == "ES")
                lblPregunta.Text = p.TextoEs;
            else
                lblPregunta.Text = p.TextoEn;
            
            List<opcion> ops = p.opciones;
            if(ops.Count >= 1)
            {
                if (logica.IdiomaActual == "ES")
                    rbOpcion1.Text = ops[0].TextoEs;
                else
                    rbOpcion1.Text = ops[0].TextoEn;
            }
            if(ops.Count >= 2)
            {
                if (logica.IdiomaActual == "ES")
                    rbOpcion2.Text = ops[1].TextoEs;
                else
                    rbOpcion2.Text = ops[1].TextoEn;
            }
            if(ops.Count >= 3)
            {
                if (logica.IdiomaActual == "ES")
                    rbOpcion3.Text = ops[2].TextoEs;
                else
                    rbOpcion3.Text = ops[2].TextoEn;
            }
            if(ops.Count >= 4)
            {
                if (logica.IdiomaActual == "ES")
                    rbOpcion4.Text = ops[3].TextoEs;
                else
                    rbOpcion4.Text = ops[3].TextoEn;
            }
            
            MostrarImagenPorModulo(p);
        }
        
        private void MostrarImagenPorModulo(Pregunta p)
        {
            try
            {
                LimpiarImagen();
                
                string rutaImagen = ObtenerRutaImagen(p);
                
                if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
                {
                    picImagen.Image = Image.FromFile(rutaImagen);
                    picImagen.SizeMode = PictureBoxSizeMode.Zoom;
                    picImagen.Visible = true;
                }
                else
                {
                    picImagen.Image = null;
                    picImagen.Visible = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al cargar imagen: " + ex.Message);
                picImagen.Image = null;
            }
        }
        
        private string ObtenerRutaImagen(Pregunta p)
        {
            string rutaBase = @"C:\Users\Usuario\Documents\proyecto\proyecto1\imagenes\";
            
            int idModulo = p.IdModulo;
            int numeroPregunta = indicePregunta + 1;
            
            switch (idModulo)
            {
                case 1:
                    string rutaArquitectura = Path.Combine(rutaBase, "arquitectura", "pregunta" + numeroPregunta + ".jpg");
                    if (File.Exists(rutaArquitectura))
                        return rutaArquitectura;
                    break;
                    
                case 2:
                    string rutaAntropologia = Path.Combine(rutaBase, "antropologia", "modulo2.jpg");
                    if (File.Exists(rutaAntropologia))
                        return rutaAntropologia;
                    break;
                    
                case 3:
                    string rutaCalculo = Path.Combine(rutaBase, "calculo", "modulo3.jpg");
                    if (File.Exists(rutaCalculo))
                        return rutaCalculo;
                    break;
                    
                case 4:
                    string rutaDeporte = Path.Combine(rutaBase, "deporte", "modulo4.jpg");
                    if (File.Exists(rutaDeporte))
                        return rutaDeporte;
                    break;
            }
            
            return string.Empty;
        }
        
        private void LimpiarImagen()
        {
            if (picImagen.Image != null)
            {
                picImagen.Image.Dispose();
                picImagen.Image = null;
            }
        }
        
        void BtnResponderClick(object sender, EventArgs e)
        {
            if(preguntasActuales == null || preguntasActuales.Count == 0)
            {
            	if (logica.IdiomaActual == "ES")
            	{
            		MessageBox.Show("Seleccione un modulo primero.");
            	}
                else
                {
            		MessageBox.Show("Select a module first.");
                }
                return;
            }
            if(indicePregunta >= preguntasActuales.Count)
            {
                if (logica.IdiomaActual == "ES")
                    MessageBox.Show("Ya completo este modulo.");
                else
                    MessageBox.Show("You already completed this module.");
                return;
            }
            
            RadioButton seleccionado = null;
            if(rbOpcion1.Checked) seleccionado = rbOpcion1;
            else if(rbOpcion2.Checked) seleccionado = rbOpcion2;
            else if(rbOpcion3.Checked) seleccionado = rbOpcion3;
            else if(rbOpcion4.Checked) seleccionado = rbOpcion4;
            
            if(seleccionado == null)
            {
            	if (logica.IdiomaActual == "ES")
            	{
            		MessageBox.Show("Seleccione una respuesta.");
            	}
            	else
            	{
            		MessageBox.Show("Select an answer.");
            	}
                return;
            }
            
            int indiceOpcion = -1;
            if(seleccionado == rbOpcion1) indiceOpcion = 0;
            else if(seleccionado == rbOpcion2) indiceOpcion = 1;
            else if(seleccionado == rbOpcion3) indiceOpcion = 2;
            else if(seleccionado == rbOpcion4) indiceOpcion = 3;
            
            Pregunta p = preguntasActuales[indicePregunta];
            bool esCorrecta = p.opciones[indiceOpcion].EsCorrecta;
            
            if (esCorrecta)
            {
            	if (logica.IdiomaActual == "ES")
            	{
            		MessageBox.Show("+" + logica.PuntosPorRespuesta + " puntos");
            	}
            	else
            	{
            		MessageBox.Show("+" + logica.PuntosPorRespuesta + " points");
            	}
            }
            else
            {
            	if (logica.IdiomaActual == "ES")
            	{
            		MessageBox.Show("-5 puntos");
            	}
            	else
            	{
            		MessageBox.Show("-5 points");
            	}
            }
            
            logica.ProcesarRespuesta(esCorrecta);
            ActualizarPuntuacion();
            
            indicePregunta++;
            MostrarPregunta();
            
            rbOpcion1.Checked = false;
            rbOpcion2.Checked = false;
            rbOpcion3.Checked = false;
            rbOpcion4.Checked = false;
        }
        
        private void ActualizarPuntuacion()
        {
        	if (logica.IdiomaActual == "ES")
        	{
        		lblPuntuacion.Text = "Puntuacion: " + logica.PuntajeActual;
        	}
        	else
        	{
        		lblPuntuacion.Text = "Score: " + logica.PuntajeActual;
        	}
        }
        
        private void LimpiarOpciones()
        {
            rbOpcion1.Text = "";
            rbOpcion2.Text = "";
            rbOpcion3.Text = "";
            rbOpcion4.Text = "";
            rbOpcion1.Checked = false;
            rbOpcion2.Checked = false;
            rbOpcion3.Checked = false;
            rbOpcion4.Checked = false;
        }
        
        private void GuardarPuntuacion()
        {
            BaseDatos.GuardarPuntuacion(idUsuario, idModuloSeleccionado, logica.PuntajeActual);
        }
        
        void VolverClick(object sender, EventArgs e)
        {
            FormMenuJugador Menu_Jugador = new FormMenuJugador(this.Nombre_de_Usuario, this.idUsuario);                
            Menu_Jugador.Show();
            this.Close();
        }
    }
}
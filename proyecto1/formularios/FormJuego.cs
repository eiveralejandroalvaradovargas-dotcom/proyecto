using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace proyecto1
{

	public partial class FormJuego : Form
	{
		private int idUsuario;
		private string Nombre_de_Usuario;
		private LogicaJuego logica;
		private List<Pregunta> preguntasActuales;
		private int indicePregunta;
		
		
		public FormJuego(int idUsuario, string Nombre_de_Usuario)
		{
			this.idUsuario = idUsuario;
			this.Nombre_de_Usuario = Nombre_de_Usuario;
			logica = new LogicaJuego();
			InitializeComponent();
			CargarModulos();
			CargarIdiomas();
		}
		
		private void CargarModulos()
		{
			cmbModulo.DataSource = null;
			cmbModulo.DataSource = MainForm.ListaModulos;
			cmbModulo.DisplayMember = "Nombre";
			cmbModulo.ValueMember = "Id";
			cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
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
		
		
		
		void CmbModuloSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbModulo.SelectedItem == null) return;
			int idModulo = (int)cmbModulo.SelectedValue;
			preguntasActuales = MainForm.ListaPreguntas.Where(p => p.IdModulo == idModulo).ToList();
			indicePregunta = 0;
			logica.ResetearJuego();
			ActualizarPuntuacion();
			MostrarPregunta();
		}
		
		void CmbIdiomaSelectedIndexChanged(object sender, EventArgs e)
		{
			logica.IdiomaActual = (cmbIdioma.SelectedIndex == 0) ? "ES" : "EN";
			MostrarPregunta();
		}
		
		private void MostrarPregunta()
		{
			if(preguntasActuales == null || preguntasActuales.Count == 0)
			{
				lblPregunta.Text = "No hay preguntas para este módulo.";
				LimpiarOpciones();
				picImagen.Image = null;
				return;
			}
			if(indicePregunta >= preguntasActuales.Count)
			{
				MessageBox.Show("¡Módulo completado! Puntuación final: "+ logica.PuntajeActual);
				GuardarPuntuacion();
				return;
			}
			
			
			Pregunta p = preguntasActuales[indicePregunta];
			
			lblPregunta.Text = (logica.IdiomaActual == "ES") ? p.TextoEs : p.TextoEn;
			
			List<opcion> ops = p.opciones;
			if(ops.Count >= 1) rbOpcion1.Text = (logica.IdiomaActual == "ES") ? ops[0].TextoEs : ops[0].TextoEn;
			if(ops.Count >= 2) rbOpcion2.Text = (logica.IdiomaActual == "ES") ? ops[1].TextoEs : ops[1].TextoEn;
			if(ops.Count >= 3) rbOpcion3.Text = (logica.IdiomaActual == "ES") ? ops[2].TextoEs : ops[2].TextoEn;
			if(ops.Count >= 4) rbOpcion4.Text = (logica.IdiomaActual == "ES") ? ops[3].TextoEs : ops[3].TextoEn;
		    
		    
		    if(p.IdModulo == 1 && !string.IsNullOrEmpty(p.ImagenRuta) && System.IO.File.Exists(p.ImagenRuta))
		    	picImagen.Image = Image.FromFile(p.ImagenRuta);
		    else
		    	picImagen.Image = null;
		}
		
		
		void BtnResponderClick(object sender, EventArgs e)
		{
			if(preguntasActuales == null || preguntasActuales.Count == 0)
			{
				MessageBox.Show("Seleccione un módulo primero.");
				return;
			}
			if(indicePregunta >= preguntasActuales.Count)
			{
				MessageBox.Show("Ya completó este módulo. Seleccione otro.");
				return;
			}
			
			
			RadioButton seleccionado = null;
			if(rbOpcion1.Checked) seleccionado = rbOpcion1;
			else if(rbOpcion2.Checked) seleccionado = rbOpcion2;
			else if(rbOpcion3.Checked) seleccionado = rbOpcion3;
			else if(rbOpcion4.Checked) seleccionado = rbOpcion4;
			
			if(seleccionado == null)
			{
				MessageBox.Show("Por favor, seleccione una respuesta.");
				return;
			}
			
			int indiceOpcion = -1;
			if(seleccionado == rbOpcion1) indiceOpcion = 0;
			else if(seleccionado == rbOpcion2) indiceOpcion = 1;
			else if(seleccionado == rbOpcion3) indiceOpcion = 2;
            else if(seleccionado == rbOpcion4) indiceOpcion = 3;
            
            
            Pregunta p = preguntasActuales[indicePregunta];
            bool esCorrecta = p.opciones[indiceOpcion].EsCorrecta;
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
			lblPuntuacion.Text = "puntuacion: "+logica.PuntajeActual;
		}
		
		
		private void LimpiarOpciones()
		{
			rbOpcion1.Text = "";
			rbOpcion2.Text = "";
			rbOpcion3.Text = "";
			rbOpcion4.Text = "";
		}
		
		
		private void GuardarPuntuacion()
		{
			int idModulo = (int)cmbModulo.SelectedValue;
			var existente = MainForm.PuntuacionesGlobales.FirstOrDefault(p => p.IdUsuario == idUsuario && p.IdModulo == idModulo);
			if(existente != null)
				existente.Puntos = logica.PuntajeActual;
			else
				MainForm.PuntuacionesGlobales.Add(new PuntuacionJugador(idUsuario,idModulo,logica.PuntajeActual));
		}
		
		
		void VolverClick(object sender, EventArgs e)
		{
			FormMenuJugador Menu_Jugador = new FormMenuJugador(this.Nombre_de_Usuario, this.idUsuario);				
			Menu_Jugador.Show();
			this.Close();
		}
	}
}

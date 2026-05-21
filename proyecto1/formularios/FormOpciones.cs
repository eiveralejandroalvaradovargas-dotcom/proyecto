using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormOpciones : Form
    {
        private int preguntaSeleccionadaId = -1;
        
        public FormOpciones()
        {
            InitializeComponent();
            dataOpciones.AutoGenerateColumns = true;
            dataOpciones.AllowUserToAddRows = false;
            dataOpciones.ReadOnly = true;
            dataOpciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            CargarPreguntas();
            cmbPreguntas.SelectedIndexChanged += cmbPreguntas_SelectedIndexChanged;
            
            foreach (Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
			Verificar();
        }
        
        private void CargarPreguntas()
        {
            try
            {
                var preguntas = BaseDatos.ObtenerPreguntas();
                if (preguntas == null || preguntas.Count == 0)
                {
                    MessageBox.Show("No hay preguntas disponibles. Cree una pregunta primero.", "Aviso");
                    return;
                }
                cmbPreguntas.DataSource = preguntas;
                cmbPreguntas.DisplayMember = "TextoEs";
                cmbPreguntas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar preguntas: " + ex.Message, "Error");
            }
        }
        
        private void LimpiarCampos()
        {
            textNombreEs1.Clear(); textNombreEs2.Clear(); textNombreEs3.Clear(); textNombreEs4.Clear();
            textNombreEn1.Clear(); textNombreEn2.Clear(); textNombreEn3.Clear(); textNombreEn4.Clear();
            rob1.Checked = false; rob2.Checked = false; rob3.Checked = false; rob4.Checked = false;
        }
        
        private void LlenarTextBoxDesdeOpciones(System.Collections.Generic.List<opcion> opciones)
        {
            LimpiarCampos();
            if (opciones == null || opciones.Count == 0) return;
            
            for (int i = 0; i < opciones.Count && i < 4; i++)
            {
                var op = opciones[i];
                switch (i)
                {
                    case 0:
                        textNombreEs1.Text = op.TextoEs;
                        textNombreEn1.Text = op.TextoEn;
                        rob1.Checked = op.EsCorrecta;
                        break;
                    case 1:
                        textNombreEs2.Text = op.TextoEs;
                        textNombreEn2.Text = op.TextoEn;
                        rob2.Checked = op.EsCorrecta;
                        break;
                    case 2:
                        textNombreEs3.Text = op.TextoEs;
                        textNombreEn3.Text = op.TextoEn;
                        rob3.Checked = op.EsCorrecta;
                        break;
                    case 3:
                        textNombreEs4.Text = op.TextoEs;
                        textNombreEn4.Text = op.TextoEn;
                        rob4.Checked = op.EsCorrecta;
                        break;
                }
            }
        }
        
        private void cmbPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPreguntas.SelectedItem == null) return;
            Pregunta p = cmbPreguntas.SelectedItem as Pregunta;
            if (p != null)
            {
                preguntaSeleccionadaId = p.Id;
                dataOpciones.DataSource = null;
                dataOpciones.DataSource = p.opciones;
                dataOpciones.Refresh();
                LlenarTextBoxDesdeOpciones(p.opciones);
            }
        }
        
        private void BtnAgregarClick(object sender, EventArgs e)
        {
            if (preguntaSeleccionadaId == -1)
            {
                MessageBox.Show("Seleccione una pregunta primero.");
                return;
            }
            
            var pregunta = BaseDatos.ObtenerPreguntas().FirstOrDefault(p => p.Id == preguntaSeleccionadaId);
            if (pregunta == null) return;
            
            string textoEs1 = textNombreEs1.Text.Trim();
            string textoEs2 = textNombreEs2.Text.Trim();
            string textoEs3 = textNombreEs3.Text.Trim();
            string textoEs4 = textNombreEs4.Text.Trim();
            
            string textoEn1 = textNombreEn1.Text.Trim();
            string textoEn2 = textNombreEn2.Text.Trim();
            string textoEn3 = textNombreEn3.Text.Trim();
            string textoEn4 = textNombreEn4.Text.Trim();
            
            bool corr1 = rob1.Checked;
            bool corr2 = rob2.Checked;
            bool corr3 = rob3.Checked;
            bool corr4 = rob4.Checked;
            
            pregunta.opciones.Clear();
            int nuevas = 0;
            
            if (!string.IsNullOrEmpty(textoEs1) && !string.IsNullOrEmpty(textoEn1))
            {
                nuevas++;
                pregunta.opciones.Add(new opcion(0, pregunta.Id, textoEs1, textoEn1, corr1));
            }
            if (!string.IsNullOrEmpty(textoEs2) && !string.IsNullOrEmpty(textoEn2))
            {
                nuevas++;
                pregunta.opciones.Add(new opcion(0, pregunta.Id, textoEs2, textoEn2, corr2));
            }
            if (!string.IsNullOrEmpty(textoEs3) && !string.IsNullOrEmpty(textoEn3))
            {
                nuevas++;
                pregunta.opciones.Add(new opcion(0, pregunta.Id, textoEs3, textoEn3, corr3));
            }
            if (!string.IsNullOrEmpty(textoEs4) && !string.IsNullOrEmpty(textoEn4))
            {
                nuevas++;
                pregunta.opciones.Add(new opcion(0, pregunta.Id, textoEs4, textoEn4, corr4));
            }
            
            if (nuevas == 0)
            {
                MessageBox.Show("Complete al menos una opción en ambos idiomas.");
                return;
            }
            if (!pregunta.opciones.Any(o => o.EsCorrecta))
            {
                MessageBox.Show("Debe marcar al menos una opción como correcta.");
                return;
            }
            
            try
            {
                BaseDatos.ActualizarPregunta(pregunta);
                MessageBox.Show("Opciones guardadas correctamente.");
                var preguntaActualizada = BaseDatos.ObtenerPreguntas().FirstOrDefault(p => p.Id == preguntaSeleccionadaId);
                if (preguntaActualizada != null)
                {
                    int idx = cmbPreguntas.SelectedIndex;
                    var lista = (System.Collections.Generic.List<Pregunta>)cmbPreguntas.DataSource;
                    lista[lista.FindIndex(p => p.Id == preguntaSeleccionadaId)] = preguntaActualizada;
                    cmbPreguntas.DataSource = null;
                    cmbPreguntas.DataSource = lista;
                    cmbPreguntas.SelectedIndex = idx;
                    
                    dataOpciones.DataSource = null;
                    dataOpciones.DataSource = preguntaActualizada.opciones;
                    LlenarTextBoxDesdeOpciones(preguntaActualizada.opciones);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error");
            }
        }
        
        private void BtnEliminarClick(object sender, EventArgs e)
        {
            if (dataOpciones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una opción para eliminar.");
                return;
            }
            opcion seleccionada = dataOpciones.CurrentRow.DataBoundItem as opcion;
            if (seleccionada == null) return;
            
            var pregunta = BaseDatos.ObtenerPreguntas().FirstOrDefault(p => p.Id == preguntaSeleccionadaId);
            if (pregunta != null)
            {
                pregunta.opciones.Remove(seleccionada);
                try
                {
                    BaseDatos.ActualizarPregunta(pregunta);
                    dataOpciones.DataSource = null;
                    dataOpciones.DataSource = pregunta.opciones;
                    LlenarTextBoxDesdeOpciones(pregunta.opciones);
                    MessageBox.Show("Opción eliminada.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error");
                }
            }
        }
        
        void Verificar()
		{
			if (proyecto1.Modelos.Idiomas.English == true)
			{
				btnAgregar.Text = "Save Options";
				btnEliminar.Text = "Delete";
				btn_Salir.Text = "Log out";
				
			}
			else
			{
				btnAgregar.Text = btnAgregar.Tag.ToString();
				btnEliminar.Text = btnEliminar.Tag.ToString();
				btn_Salir.Text = btn_Salir.Tag.ToString();
			}
        }  
		
		void Btn_SalirClick(object sender, EventArgs e)
		{
			proyecto1.Modelos.Idiomas.English = false;
			
			
			if (this.Owner != null)
			{
				this.Owner.Show();
			}
			this.Close();
		}
		
	
    }
}
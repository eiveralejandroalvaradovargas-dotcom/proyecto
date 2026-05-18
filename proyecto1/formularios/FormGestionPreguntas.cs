using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace proyecto1
{
	public partial class FormGestionPreguntas : Form
	{
		int Seleccion_de_ID = -1;
		
		public FormGestionPreguntas()
		{
			InitializeComponent();
			
			cmbPreguntas.DataSource = BaseDatos.ObtenerModulos();
			cmbPreguntas.DisplayMember = "Nombre";
			cmbPreguntas.ValueMember = "Id";
			
			foreach(Control Textos_Properties in this.Controls)
			{
				Textos_Properties.Tag = Textos_Properties.Text;
			}
			this.Regisstrar.Click += RegisstrarClick;
			Verificar();
		}
		
		void Actualizar()
		{
			dataPreguntas.CurrentCell = null;
			dataPreguntas.DataSource = null;
			
			var Modulo_Actual = cmbPreguntas.SelectedItem as ModuloEducativo;
			if(Modulo_Actual != null)
			{
				var Filtro = BaseDatos.ObtenerPreguntas().Where(Objeto => Objeto.IdModulo == Modulo_Actual.Id).ToList();
				dataPreguntas.DataSource = Filtro;
			}
			else
			{
				dataPreguntas.DataSource = BaseDatos.ObtenerPreguntas();
			}
			
			dataPreguntas.Refresh();
		}
		
		void Limpiar_Casillas()
		{
			Pregunta_ESP.Clear();
			Pregunta_ENG.Clear();
		}
		
		void RegisstrarClick(object sender, EventArgs e)
		{
			var Modulo_Actual = cmbPreguntas.SelectedItem as ModuloEducativo;
			if(cmbPreguntas.SelectedItem == null)
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Select a course"
					: "Seleccione una materia";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);return;
				
			}
			else if (string.IsNullOrEmpty(Pregunta_ESP.Text) || string.IsNullOrEmpty(Pregunta_ENG.Text))
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Please, fill all the fields"
					: "Por favor, llenar todos los campos solicitados";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);return;
				
			}
			else
			{
			    Pregunta New_Question = new Pregunta (0, Modulo_Actual.Id, Pregunta_ESP.Text, Pregunta_ENG.Text, "");
			    BaseDatos.AgregarPregunta(New_Question);
			    Actualizar();
			    Limpiar_Casillas();
			}
		}
		
		void ModificarClick(object sender, EventArgs e)
		{
			if (Seleccion_de_ID == -1)
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Please, select a question from the list"
					: "Seleccionada una pregunta de la  tabla";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);return;
			}
			
			Pregunta Encontrada = BaseDatos.ObtenerPreguntas().Find(Objeto => Objeto.Id == Seleccion_de_ID);
			if (Encontrada !=null)
			{
				Encontrada.TextoEs = Pregunta_ESP.Text;
				Encontrada.TextoEn = Pregunta_ENG.Text;
				BaseDatos.ActualizarPregunta(Encontrada);
				Actualizar();
				Limpiar_Casillas();
				
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "The question was edited sucessfully"
					:  "Se ha modificado la pregunta correctamente";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
			}
			
		}
		
		void EliminarClick(object sender, EventArgs e)
		{
			if (Seleccion_de_ID == -1)
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Select a question to delete"
					:  "Seleccione una pregunta para eliminar";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title); return;
			}
			Pregunta Encontrada = BaseDatos.ObtenerPreguntas().Find(Objeto => Objeto.Id == Seleccion_de_ID);
			if (Encontrada != null)
			{
				BaseDatos.EliminarPregunta(Seleccion_de_ID);
				Actualizar();
				Limpiar_Casillas();
				Seleccion_de_ID = -1;
				
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "The question was deleted sucessfully"
					:  "Se ha eliminado la pregunta correctamente";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
				
			}
			
		}
		
		void CmbPreguntasSelectedIndexChanged(object sender, EventArgs e)
		{
			var Modulo_Actual = cmbPreguntas.SelectedItem as ModuloEducativo;
			
			if (Modulo_Actual != null)
			{
				Seleccion_de_ID = -1;
				var Filtro = BaseDatos.ObtenerPreguntas().Where(Objeto => Objeto.IdModulo == Modulo_Actual.Id).ToList();
				
				dataPreguntas.DataSource = null;
				dataPreguntas.DataSource = Filtro;
			}
		}
		
		void Ver_TodoClick(object sender, EventArgs e)
		{
			cmbPreguntas.SelectedIndex = -1;
			
			dataPreguntas.DataSource = null;
			dataPreguntas.DataSource = BaseDatos.ObtenerPreguntas();
		}
		
		void DataPreguntasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dataPreguntas.Rows.Count)
			{
				var Fila = dataPreguntas.Rows[e.RowIndex];
				if (Fila.Cells["Id"].Value != null)
				{
				  Seleccion_de_ID = int.Parse(Fila.Cells["Id"].Value.ToString());
				
				  Pregunta_ESP.Text = Fila.Cells["TextoES"].Value.ToString();
				  Pregunta_ENG.Text = Fila.Cells["TextoEN"].Value.ToString();
				}
			}
		}
		
		void VolverClick(object sender, EventArgs e)
		{
			if (this.Owner != null)
			{
				this.Owner.Show();
			}
			this.Close();
		}
		
		void Verificar()
		{
			if(proyecto1.Modelos.Idiomas.English == true)
			{
				lbl_Title.Text = "Module";
				lbl_Preg_Español.Text = "Spanish question";
				lbl_Preg_Ingles.Text = "English question";
				
				Regisstrar.Text = "Save question";
				Modificar.Text = "Edit";
				Eliminar.Text = "Delete";
				Volver.Text = "Back";
			}
			else
			{
				lbl_Title.Text = lbl_Title.Tag.ToString();
				lbl_Preg_Español.Text = lbl_Preg_Español.Tag.ToString();
				lbl_Preg_Ingles.Text = lbl_Preg_Ingles.Tag.ToString();
				
				Regisstrar.Text = Regisstrar.Tag.ToString();
				Modificar.Text = Modificar.Tag.ToString();
				Eliminar.Text = Eliminar.Tag.ToString();
				Volver.Text = Volver.Tag.ToString();
			}
		}
	}
}

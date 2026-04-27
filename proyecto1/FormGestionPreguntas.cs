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
			
			cmbPreguntas.DataSource = MainForm.ListaModulos;
			cmbPreguntas.DisplayMember = "Nombre";
		}
		
		void Actualizar()
		{
			dataPreguntas.CurrentCell = null;
			dataPreguntas.DataSource = null;
			
			var Modulo_Actual = cmbPreguntas.SelectedItem as ModuloEducativo;
			if(Modulo_Actual != null)
			{
				dataPreguntas.DataSource = null;
				var Filtro = MainForm.ListaPreguntas.Where(Objeto => Objeto.IdModulo == Modulo_Actual.Id).ToList();
				dataPreguntas.DataSource = Filtro;
			}
			else
			{
				dataPreguntas.DataSource = MainForm.ListaPreguntas;
			}
			
			dataPreguntas.Refresh();
		}
		
		void Limpiar_Casillas()
		{
			Pregunta_ESP.Clear();
			Pregunta_ENG.Clear();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			var Modulo_Actual = cmbPreguntas.SelectedItem as ModuloEducativo;
			if(cmbPreguntas.SelectedItem == null)
			{
				MessageBox.Show("Seleccione una materia", "Advertencia"); return;
			}
			
			int New_ID = MainForm.ListaPreguntas.Count +1;
			
			Pregunta New_Question = new Pregunta (New_ID, Modulo_Actual.Id, Pregunta_ESP.Text, Pregunta_ENG.Text, "");
			
			MainForm.ListaPreguntas.Add(New_Question);
			Actualizar();
			Limpiar_Casillas();
		}
		
		void ModificarClick(object sender, EventArgs e)
		{
			if (Seleccion_de_ID == -1)
			{
				MessageBox.Show("Seleccionada una pregunta de la  tabla", "Modificacion"); return;
			}
			
			Pregunta Encontrada = MainForm.ListaPreguntas.Find(Objeto => Objeto.Id == Seleccion_de_ID);
			if (Encontrada !=null)
			{
				Encontrada.TextoEs = Pregunta_ESP.Text;
				Encontrada.TextoEn = Pregunta_ENG.Text;
				Actualizar();
				Limpiar_Casillas();
				MessageBox.Show("Se ha modificado la pregunta correctamente", "Yeeeeih");
			}
			
		}
		
		void EliminarClick(object sender, EventArgs e)
		{
			if (Seleccion_de_ID == -1)
			{
				MessageBox.Show("Seleccione una pregunta para eliminar", "Eliminacion"); return;
			}
			Pregunta Encontrada = MainForm.ListaPreguntas.Find(Objeto => Objeto.Id == Seleccion_de_ID);
			if (Encontrada != null)
			{
				MainForm.ListaPreguntas.Remove(Encontrada);
				Actualizar();
				Limpiar_Casillas();
				Seleccion_de_ID = -1;
				
				MessageBox.Show("Se ha eliminado la pregunta correctamente", "Eliminacion");
			}
			
		}
		
		void CmbPreguntasSelectedIndexChanged(object sender, EventArgs e)
		{
			var Modulo_Actual = cmbPreguntas.SelectedItem as ModuloEducativo;
			
			if (Modulo_Actual != null)
			{
				Seleccion_de_ID = -1;
				var Filtro = MainForm.ListaPreguntas.Where(Objeto => Objeto.IdModulo == Modulo_Actual.Id).ToList();
				
				dataPreguntas.DataSource = null;
				dataPreguntas.DataSource = Filtro;
			}
		}
		
		void Ver_TodoClick(object sender, EventArgs e)
		{
			cmbPreguntas.SelectedIndex = -1;
			
			dataPreguntas.DataSource = null;
			dataPreguntas.DataSource = MainForm.ListaPreguntas;
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
			FormMenuAdmin Menu_Administrador = new FormMenuAdmin();
			Menu_Administrador.Show();
			this.Close();
		}
	}
}

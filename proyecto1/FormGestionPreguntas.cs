using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto1
{
	public partial class FormGestionPreguntas : Form
	{
		public FormGestionPreguntas()
		{
			InitializeComponent();
			Actualizar();
		}
		
		void Actualizar()
		{
			dataPreguntas.DataSource = null;
			dataPreguntas.DataSource = MainForm.ListaPreguntas;
		}
	}
}

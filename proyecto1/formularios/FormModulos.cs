using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto1
{
	public partial class FormModulos : Form
	{
		public FormModulos()
		{
			InitializeComponent();
			Actualizar();
		}
		
		void Actualizar()
		{
			dataModulos.DataSource = null;
			dataModulos.DataSource = MainForm.ListaModulos;
			
			cmbNombre.DataSource = null;
			cmbNombre.DataSource = MainForm.ListaModulos;
			cmbNombre.ValueMember = "nombre";
			cmbNombre.DisplayMember ="nombre";
			
			textDescripcion.Text = "";
			textNombre.Text = "";
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textNombre.Text) && string.IsNullOrEmpty(textDescripcion.Text))
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "No exists information in the fields"
					: "No hay informacion en los campos";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);

			}
			else
			{
				int IdModulo = MainForm.ListaModulos.Count + 1;
			    string nombre = textNombre.Text;
			    string descripcion = textDescripcion.Text;
			
			MainForm.ListaModulos.Add(new ModuloEducativo(IdModulo, nombre, descripcion));
			Actualizar();
			}
			
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			ModuloEducativo Modificar = (ModuloEducativo)cmbNombre.SelectedItem;
			string nom = textNombre.Text;
			string des = textDescripcion.Text;		
			
			if(nom != "")
			{
				Modificar.Nombre = textNombre.Text;
				
			}
			if(des != "")
			{
				Modificar.Descripcion = textDescripcion.Text;
			}
			
			if(des != "" || nom != "")
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Correctly updated"
					: "Modificacion exitosa";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);

			}
			
			Actualizar();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			ModuloEducativo Eliminar = (ModuloEducativo)cmbNombre.SelectedItem;
			MainForm.ListaModulos.Remove(Eliminar);
			Actualizar();
			
			string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Module deleted sucessfully"
					: "Modulo eliminado exitoxamente";
				
			string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			FormMenuAdmin MenuAdmin = new FormMenuAdmin();			
			if (this.Owner != null)
			{
				this.Owner.Show();
			}
			this.Close();
		}
	}
}

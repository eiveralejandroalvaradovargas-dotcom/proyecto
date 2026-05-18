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
			var modulos = BaseDatos.ObtenerModulos();
			dataModulos.DataSource = null;
			dataModulos.DataSource = modulos;
			
			cmbNombre.DataSource = null;
			cmbNombre.DataSource = modulos;
			cmbNombre.DisplayMember ="Nombre";
			cmbNombre.ValueMember = "Id";
			
			textDescripcion.Text = "";
			textNombre.Text = "";
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			string name = textNombre.Text.Trim();
			string desc = textDescripcion.Text.Trim();
			if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(desc))
			{
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "No exists information in the fields"
					: "No hay informacion en los campos";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
				return;
			}
			ModuloEducativo nuevo = new ModuloEducativo(0, name, desc);
			BaseDatos.AgregarModulo(nuevo);
			Actualizar();
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			ModuloEducativo Modificar = cmbNombre.SelectedItem as ModuloEducativo;
			if(Modificar == null) return;
			string nom = textNombre.Text.Trim();
			string des = textDescripcion.Text.Trim();
			if(!string.IsNullOrEmpty(nom)) Modificar.Nombre = nom;
			if(!string.IsNullOrEmpty(des)) Modificar.Descripcion = des;
			BaseDatos.ActualizarModulo(Modificar);
	
				string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Correctly updated"
					: "Modificacion exitosa";
				
				string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
			Actualizar();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			ModuloEducativo Eliminar = cmbNombre.SelectedItem as ModuloEducativo;
			if(Eliminar == null) return;
			BaseDatos.EliminarModulo(Eliminar.Id);
			
			string Mensaje = proyecto1.Modelos.Idiomas.English
					? "Module deleted sucessfully"
					: "Modulo eliminado exitoxamente";
				
			string Title = proyecto1.Modelos.Idiomas.English
					? "Advice"
					: "Aviso";
					
				MessageBox.Show(Mensaje, Title);
				Actualizar();
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

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
		    cmbNombre.DisplayMember = "NombreEs";
		    cmbNombre.ValueMember = "Id";
		    
		    textDescripcion.Text = "";
		    textNombreEs.Text = "";
		    textNombreEn.Text = "";
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
		    string nombreEs = textNombreEs.Text.Trim();
		    string nombreEn = textNombreEn.Text.Trim();
		    string desc = textDescripcion.Text.Trim();
		    if (string.IsNullOrEmpty(nombreEs) || string.IsNullOrEmpty(nombreEn) || string.IsNullOrEmpty(desc))
		    {
		        string Mensaje = proyecto1.Modelos.Idiomas.English ? "Complete all fields" : "Complete todos los campos";
		        string Title = proyecto1.Modelos.Idiomas.English ? "Advice" : "Aviso";
		        MessageBox.Show(Mensaje, Title);
		        return;
		    }
		    ModuloEducativo nuevo = new ModuloEducativo(0, nombreEs, nombreEn, desc);
		    BaseDatos.AgregarModulo(nuevo);
		    Actualizar();
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
		    ModuloEducativo Modificar = cmbNombre.SelectedItem as ModuloEducativo;
		    if (Modificar == null) return;
		    string nomEs = textNombreEs.Text.Trim();
		    string nomEn = textNombreEn.Text.Trim();
		    string des = textDescripcion.Text.Trim();
		    
		    if (!string.IsNullOrEmpty(nomEs)) Modificar.NombreEs = nomEs;
		    if (!string.IsNullOrEmpty(nomEn)) Modificar.NombreEn = nomEn;
		    if (!string.IsNullOrEmpty(des)) Modificar.Descripcion = des;
		    
		    BaseDatos.ActualizarModulo(Modificar);
		    string Mensaje = proyecto1.Modelos.Idiomas.English ? "Correctly updated" : "Modificacion exitosa";
		    string Title = proyecto1.Modelos.Idiomas.English ? "Advice" : "Aviso";
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

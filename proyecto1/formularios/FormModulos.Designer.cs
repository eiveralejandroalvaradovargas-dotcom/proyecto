/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 14/4/2026
 * Time: 12:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormModulos
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.cmbNombre = new System.Windows.Forms.ComboBox();
			this.dataModulos = new System.Windows.Forms.DataGridView();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.textDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataModulos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(82, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Interfaz de Modulos";
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(95, 288);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(77, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 288);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(77, 23);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(178, 288);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(77, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// cmbNombre
			// 
			this.cmbNombre.FormattingEnabled = true;
			this.cmbNombre.Location = new System.Drawing.Point(72, 87);
			this.cmbNombre.Name = "cmbNombre";
			this.cmbNombre.Size = new System.Drawing.Size(121, 21);
			this.cmbNombre.TabIndex = 5;
			// 
			// dataModulos
			// 
			this.dataModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataModulos.Location = new System.Drawing.Point(272, 12);
			this.dataModulos.Name = "dataModulos";
			this.dataModulos.Size = new System.Drawing.Size(331, 299);
			this.dataModulos.TabIndex = 6;
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(62, 151);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(147, 20);
			this.textNombre.TabIndex = 7;
			// 
			// textDescripcion
			// 
			this.textDescripcion.Location = new System.Drawing.Point(62, 221);
			this.textDescripcion.Name = "textDescripcion";
			this.textDescripcion.Size = new System.Drawing.Size(147, 20);
			this.textDescripcion.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(82, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nombre del modulo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(95, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Descripcion";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(12, 12);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 11;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// FormModulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 323);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textDescripcion);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.dataModulos);
			this.Controls.Add(this.cmbNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.label1);
			this.Name = "FormModulos";
			this.Text = "FormModulos";
			((System.ComponentModel.ISupportInitialize)(this.dataModulos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textDescripcion;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.DataGridView dataModulos;
		private System.Windows.Forms.ComboBox cmbNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label label1;
		
	}
}

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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModulos));
			this.lbl_Title = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.cmbNombre = new System.Windows.Forms.ComboBox();
			this.dataModulos = new System.Windows.Forms.DataGridView();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.textDescripcion = new System.Windows.Forms.TextBox();
			this.lbl_Descripcion = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.textNombreEs = new System.Windows.Forms.TextBox();
			this.textNombreEn = new System.Windows.Forms.TextBox();
			this.lbl_Nombre_Esp = new System.Windows.Forms.Label();
			this.lbl_Nombre_Eng = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataModulos)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Title.Location = new System.Drawing.Point(123, 65);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(229, 30);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Interfaz de Modulos";
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnModificar.Location = new System.Drawing.Point(188, 465);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(114, 47);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnAgregar.Location = new System.Drawing.Point(25, 465);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(114, 47);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnEliminar.Location = new System.Drawing.Point(351, 465);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 47);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// cmbNombre
			// 
			this.cmbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.cmbNombre.FormattingEnabled = true;
			this.cmbNombre.Location = new System.Drawing.Point(123, 98);
			this.cmbNombre.Name = "cmbNombre";
			this.cmbNombre.Size = new System.Drawing.Size(241, 29);
			this.cmbNombre.TabIndex = 5;
			// 
			// dataModulos
			// 
			this.dataModulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataModulos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataModulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
			this.dataModulos.Location = new System.Drawing.Point(497, 75);
			this.dataModulos.Name = "dataModulos";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			this.dataModulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataModulos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
			this.dataModulos.Size = new System.Drawing.Size(449, 437);
			this.dataModulos.TabIndex = 6;
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(0, 0);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(100, 20);
			this.textNombre.TabIndex = 15;
			// 
			// textDescripcion
			// 
			this.textDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDescripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textDescripcion.Location = new System.Drawing.Point(123, 381);
			this.textDescripcion.Name = "textDescripcion";
			this.textDescripcion.Size = new System.Drawing.Size(241, 33);
			this.textDescripcion.TabIndex = 9;
			// 
			// lbl_Descripcion
			// 
			this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Descripcion.Location = new System.Drawing.Point(123, 347);
			this.lbl_Descripcion.Name = "lbl_Descripcion";
			this.lbl_Descripcion.Size = new System.Drawing.Size(130, 31);
			this.lbl_Descripcion.TabIndex = 11;
			this.lbl_Descripcion.Text = "Descripcion";
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnCerrar.Location = new System.Drawing.Point(12, 12);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(112, 41);
			this.btnCerrar.TabIndex = 12;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// textNombreEs
			// 
			this.textNombreEs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textNombreEs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNombreEs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNombreEs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textNombreEs.Location = new System.Drawing.Point(123, 190);
			this.textNombreEs.Name = "textNombreEs";
			this.textNombreEs.Size = new System.Drawing.Size(241, 33);
			this.textNombreEs.TabIndex = 7;
			// 
			// textNombreEn
			// 
			this.textNombreEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textNombreEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNombreEn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNombreEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textNombreEn.Location = new System.Drawing.Point(123, 283);
			this.textNombreEn.Name = "textNombreEn";
			this.textNombreEn.Size = new System.Drawing.Size(241, 33);
			this.textNombreEn.TabIndex = 13;
			// 
			// lbl_Nombre_Esp
			// 
			this.lbl_Nombre_Esp.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Nombre_Esp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombre_Esp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Nombre_Esp.Location = new System.Drawing.Point(123, 160);
			this.lbl_Nombre_Esp.Name = "lbl_Nombre_Esp";
			this.lbl_Nombre_Esp.Size = new System.Drawing.Size(279, 27);
			this.lbl_Nombre_Esp.TabIndex = 14;
			this.lbl_Nombre_Esp.Text = "Nombre del modulo español";
			// 
			// lbl_Nombre_Eng
			// 
			this.lbl_Nombre_Eng.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Nombre_Eng.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Nombre_Eng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Nombre_Eng.Location = new System.Drawing.Point(123, 250);
			this.lbl_Nombre_Eng.Name = "lbl_Nombre_Eng";
			this.lbl_Nombre_Eng.Size = new System.Drawing.Size(257, 30);
			this.lbl_Nombre_Eng.TabIndex = 10;
			this.lbl_Nombre_Eng.Text = "Nombre del modulo ingles";
			// 
			// FormModulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.lbl_Nombre_Esp);
			this.Controls.Add(this.textNombreEn);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.lbl_Descripcion);
			this.Controls.Add(this.lbl_Nombre_Eng);
			this.Controls.Add(this.textDescripcion);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.textNombreEs);
			this.Controls.Add(this.dataModulos);
			this.Controls.Add(this.cmbNombre);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.lbl_Title);
			this.DoubleBuffered = true;
			this.Name = "FormModulos";
			this.Text = "FormModulos";
			this.Load += new System.EventHandler(this.FormModulosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataModulos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		// Declaración de controles (TODOS declarados correctamente)
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label lbl_Descripcion;
		private System.Windows.Forms.Label lbl_Nombre_Eng;
		private System.Windows.Forms.TextBox textDescripcion;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.DataGridView dataModulos;
		private System.Windows.Forms.ComboBox cmbNombre;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.TextBox textNombreEs;
		private System.Windows.Forms.TextBox textNombreEn;
		private System.Windows.Forms.Label lbl_Nombre_Esp;
	}
}
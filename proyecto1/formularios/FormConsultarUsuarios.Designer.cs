/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 1/4/2026
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormConsultarUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.dataUsuario = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.textContraseña = new System.Windows.Forms.TextBox();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbID = new System.Windows.Forms.ComboBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Consulta de Usuarios";
			// 
			// dataUsuario
			// 
			this.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataUsuario.Location = new System.Drawing.Point(12, 39);
			this.dataUsuario.Name = "dataUsuario";
			this.dataUsuario.ReadOnly = true;
			this.dataUsuario.Size = new System.Drawing.Size(322, 324);
			this.dataUsuario.TabIndex = 1;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(478, 283);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(94, 34);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(593, 283);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(94, 34);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
									"Todos",
									"Jugador",
									"Admin"});
			this.cmbRol.Location = new System.Drawing.Point(467, 323);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(121, 21);
			this.cmbRol.TabIndex = 6;
			this.cmbRol.Text = "Todos";
			this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRolSelectedIndexChanged);
			// 
			// textContraseña
			// 
			this.textContraseña.Location = new System.Drawing.Point(363, 152);
			this.textContraseña.Name = "textContraseña";
			this.textContraseña.Size = new System.Drawing.Size(94, 20);
			this.textContraseña.TabIndex = 8;
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(363, 89);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(94, 20);
			this.textNombre.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(480, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "ID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(363, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Contraseña";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(363, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "Nombre";
			// 
			// cmbID
			// 
			this.cmbID.FormattingEnabled = true;
			this.cmbID.Location = new System.Drawing.Point(480, 86);
			this.cmbID.Name = "cmbID";
			this.cmbID.Size = new System.Drawing.Size(92, 21);
			this.cmbID.TabIndex = 14;
			this.cmbID.SelectedIndexChanged += new System.EventHandler(this.CmbIDSelectedIndexChanged);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(363, 283);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(86, 34);
			this.btnRegistrar.TabIndex = 15;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// FormConsultarUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 375);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.cmbID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.textContraseña);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dataUsuario);
			this.Controls.Add(this.label1);
			this.Name = "FormConsultarUsuarios";
			this.Text = "Consultar Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ComboBox cmbID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.TextBox textContraseña;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.DataGridView dataUsuario;
		private System.Windows.Forms.Label label1;
	}
}

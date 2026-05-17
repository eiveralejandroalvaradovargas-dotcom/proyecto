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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarUsuarios));
			this.lbl_Title = new System.Windows.Forms.Label();
			this.dataUsuario = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.textContraseña = new System.Windows.Forms.TextBox();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_Contraseña = new System.Windows.Forms.Label();
			this.lbl_Usuario = new System.Windows.Forms.Label();
			this.cmbID = new System.Windows.Forms.ComboBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btn_Volver = new System.Windows.Forms.Button();
			this.lbl_Ver = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
<<<<<<< HEAD
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(284, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Consulta de Usuarios";
=======
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(235, 13);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(173, 23);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Consulta de Usuarios";
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			// 
			// dataUsuario
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
			this.dataUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataUsuario.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
			this.dataUsuario.Location = new System.Drawing.Point(12, 80);
			this.dataUsuario.Name = "dataUsuario";
			this.dataUsuario.ReadOnly = true;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.dataUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataUsuario.Size = new System.Drawing.Size(322, 324);
			this.dataUsuario.TabIndex = 1;
			// 
			// btnModificar
			// 
<<<<<<< HEAD
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnModificar.Location = new System.Drawing.Point(523, 310);
=======
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnModificar.Location = new System.Drawing.Point(478, 283);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(114, 45);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnEliminar.Location = new System.Drawing.Point(667, 310);
=======
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(363, 323);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 45);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// cmbRol
			// 
			this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
									"Todos",
									"Jugador",
									"Admin"});
<<<<<<< HEAD
			this.cmbRol.Location = new System.Drawing.Point(512, 383);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(139, 31);
=======
			this.cmbRol.Location = new System.Drawing.Point(478, 153);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(96, 21);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.cmbRol.TabIndex = 6;
			this.cmbRol.Text = "Todos";
			this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRolSelectedIndexChanged);
			// 
			// textContraseña
			// 
			this.textContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContraseña.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textContraseña.Location = new System.Drawing.Point(363, 220);
			this.textContraseña.Name = "textContraseña";
			this.textContraseña.Size = new System.Drawing.Size(139, 30);
			this.textContraseña.TabIndex = 8;
			// 
			// textNombre
			// 
			this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNombre.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textNombre.Location = new System.Drawing.Point(363, 142);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(139, 30);
			this.textNombre.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(580, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "ID";
			// 
			// lbl_Contraseña
			// 
<<<<<<< HEAD
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(363, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 28);
			this.label3.TabIndex = 12;
			this.label3.Text = "Contraseña";
=======
			this.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Contraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Contraseña.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Contraseña.Location = new System.Drawing.Point(363, 126);
			this.lbl_Contraseña.Name = "lbl_Contraseña";
			this.lbl_Contraseña.Size = new System.Drawing.Size(94, 20);
			this.lbl_Contraseña.TabIndex = 12;
			this.lbl_Contraseña.Text = "Contraseña";
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			// 
			// lbl_Usuario
			// 
<<<<<<< HEAD
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(363, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "Nombre";
=======
			this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Usuario.Location = new System.Drawing.Point(363, 59);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(94, 24);
			this.lbl_Usuario.TabIndex = 13;
			this.lbl_Usuario.Text = "Nombre";
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			// 
			// cmbID
			// 
			this.cmbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.cmbID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbID.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.cmbID.FormattingEnabled = true;
			this.cmbID.Location = new System.Drawing.Point(580, 141);
			this.cmbID.Name = "cmbID";
			this.cmbID.Size = new System.Drawing.Size(139, 31);
			this.cmbID.TabIndex = 14;
			this.cmbID.SelectedIndexChanged += new System.EventHandler(this.CmbIDSelectedIndexChanged);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnRegistrar.Location = new System.Drawing.Point(377, 310);
			this.btnRegistrar.Name = "btnRegistrar";
<<<<<<< HEAD
			this.btnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnRegistrar.Size = new System.Drawing.Size(114, 45);
=======
			this.btnRegistrar.Size = new System.Drawing.Size(94, 34);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.btnRegistrar.TabIndex = 15;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btn_Volver
			// 
			this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Volver.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_Volver.Location = new System.Drawing.Point(478, 323);
			this.btn_Volver.Name = "btn_Volver";
			this.btn_Volver.Size = new System.Drawing.Size(94, 34);
			this.btn_Volver.TabIndex = 16;
			this.btn_Volver.Text = "Volver";
			this.btn_Volver.UseVisualStyleBackColor = false;
			this.btn_Volver.Click += new System.EventHandler(this.Btn_VolverClick);
			// 
			// lbl_Ver
			// 
			this.lbl_Ver.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Ver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Ver.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Ver.Location = new System.Drawing.Point(478, 126);
			this.lbl_Ver.Name = "lbl_Ver";
			this.lbl_Ver.Size = new System.Drawing.Size(94, 20);
			this.lbl_Ver.TabIndex = 17;
			this.lbl_Ver.Text = "Ver";
			// 
			// FormConsultarUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
<<<<<<< HEAD
			this.ClientSize = new System.Drawing.Size(811, 429);
=======
			this.ClientSize = new System.Drawing.Size(600, 382);
			this.Controls.Add(this.lbl_Ver);
			this.Controls.Add(this.btn_Volver);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.cmbID);
			this.Controls.Add(this.lbl_Usuario);
			this.Controls.Add(this.lbl_Contraseña);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.textContraseña);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.dataUsuario);
<<<<<<< HEAD
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
=======
			this.Controls.Add(this.lbl_Title);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.Name = "FormConsultarUsuarios";
			this.Text = "Consultar Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbl_Ver;
		private System.Windows.Forms.Button btn_Volver;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ComboBox cmbID;
		private System.Windows.Forms.Label lbl_Usuario;
		private System.Windows.Forms.Label lbl_Contraseña;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.TextBox textContraseña;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.DataGridView dataUsuario;
		private System.Windows.Forms.Label lbl_Title;
	}
}

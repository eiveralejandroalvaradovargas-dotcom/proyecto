/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 1/4/2026
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormMenuAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
			this.lb_Titulo = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.BtnGestionarPreguntas = new System.Windows.Forms.Button();
			this.btnGestionarModulos = new System.Windows.Forms.Button();
			this.btn_Cerrar_Sesion = new System.Windows.Forms.Button();
			this.btnOpciones = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_Titulo
			// 
			this.lb_Titulo.BackColor = System.Drawing.Color.Transparent;
			this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Titulo.ForeColor = System.Drawing.Color.White;
			this.lb_Titulo.Location = new System.Drawing.Point(297, 58);
			this.lb_Titulo.Name = "lb_Titulo";
			this.lb_Titulo.Size = new System.Drawing.Size(399, 40);
			this.lb_Titulo.TabIndex = 0;
			this.lb_Titulo.Text = "Menu de Administrador";
			this.lb_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnConsultar.Location = new System.Drawing.Point(654, 156);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(142, 83);
			this.btnConsultar.TabIndex = 6;
			this.btnConsultar.Text = "Consultar usuarios";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// BtnGestionarPreguntas
			// 
			this.BtnGestionarPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.BtnGestionarPreguntas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.BtnGestionarPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGestionarPreguntas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGestionarPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.BtnGestionarPreguntas.Location = new System.Drawing.Point(178, 371);
			this.BtnGestionarPreguntas.Name = "BtnGestionarPreguntas";
			this.BtnGestionarPreguntas.Size = new System.Drawing.Size(142, 83);
			this.BtnGestionarPreguntas.TabIndex = 7;
			this.BtnGestionarPreguntas.Text = "Gestionar Preguntas";
			this.BtnGestionarPreguntas.UseVisualStyleBackColor = false;
			this.BtnGestionarPreguntas.Click += new System.EventHandler(this.BtnGestionarPreguntasClick);
			// 
			// btnGestionarModulos
			// 
			this.btnGestionarModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnGestionarModulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnGestionarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGestionarModulos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionarModulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnGestionarModulos.Location = new System.Drawing.Point(178, 156);
			this.btnGestionarModulos.Name = "btnGestionarModulos";
			this.btnGestionarModulos.Size = new System.Drawing.Size(142, 83);
			this.btnGestionarModulos.TabIndex = 8;
			this.btnGestionarModulos.Text = "Gestionar Modulos";
			this.btnGestionarModulos.UseVisualStyleBackColor = false;
			this.btnGestionarModulos.Click += new System.EventHandler(this.BtnGestionarModulosClick);
			// 
			// btn_Cerrar_Sesion
			// 
			this.btn_Cerrar_Sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btn_Cerrar_Sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btn_Cerrar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cerrar_Sesion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cerrar_Sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btn_Cerrar_Sesion.Location = new System.Drawing.Point(654, 371);
			this.btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
			this.btn_Cerrar_Sesion.Size = new System.Drawing.Size(142, 83);
			this.btn_Cerrar_Sesion.TabIndex = 9;
			this.btn_Cerrar_Sesion.Text = "Cerrar sesion";
			this.btn_Cerrar_Sesion.UseVisualStyleBackColor = false;
			this.btn_Cerrar_Sesion.Click += new System.EventHandler(this.Btn_Cerrar_SesionClick);
			// 
			// btnOpciones
			// 
			this.btnOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(214)))), ((int)(((byte)(203)))));
			this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpciones.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnOpciones.Location = new System.Drawing.Point(418, 245);
			this.btnOpciones.Name = "btnOpciones";
			this.btnOpciones.Size = new System.Drawing.Size(142, 83);
			this.btnOpciones.TabIndex = 10;
			this.btnOpciones.Text = "Gestionar Opciones";
			this.btnOpciones.UseVisualStyleBackColor = false;
			this.btnOpciones.Click += new System.EventHandler(this.BtnOpcionesClick);
			// 
			// FormMenuAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.btnOpciones);
			this.Controls.Add(this.btn_Cerrar_Sesion);
			this.Controls.Add(this.btnGestionarModulos);
			this.Controls.Add(this.BtnGestionarPreguntas);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.lb_Titulo);
			this.DoubleBuffered = true;
			this.Name = "FormMenuAdmin";
			this.Text = "FormMenuAdmin";
			this.Activated += new System.EventHandler(this.FormMenuAdminActivated);
			this.Click += new System.EventHandler(this.Btn_Cerrar_SesionClick);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnOpciones;
		private System.Windows.Forms.Button btn_Cerrar_Sesion;
		private System.Windows.Forms.Button btnGestionarModulos;
		private System.Windows.Forms.Button BtnGestionarPreguntas;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Label lb_Titulo;
		

		
		void FormMenuAdminActivated(object sender, System.EventArgs e)
		{
			Verificar();
		}
	}
}

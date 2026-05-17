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
<<<<<<< HEAD
    partial class FormMenuAdmin
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
        
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnConsultar = new System.Windows.Forms.Button();
        	this.BtnGestionarPreguntas = new System.Windows.Forms.Button();
        	this.btnGestionarModulos = new System.Windows.Forms.Button();
        	this.Añadir_preguntas = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.Transparent;
        	this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(288, 38);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(208, 39);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Menu de Admin";
        	// 
        	// btnConsultar
        	// 
        	this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
        	this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
        	this.btnConsultar.Location = new System.Drawing.Point(173, 277);
        	this.btnConsultar.Name = "btnConsultar";
        	this.btnConsultar.Size = new System.Drawing.Size(176, 95);
        	this.btnConsultar.TabIndex = 6;
        	this.btnConsultar.Text = "Consultar usuarios";
        	this.btnConsultar.UseVisualStyleBackColor = false;
        	this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
        	// 
        	// BtnGestionarPreguntas
        	// 
        	this.BtnGestionarPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
        	this.BtnGestionarPreguntas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	this.BtnGestionarPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnGestionarPreguntas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.BtnGestionarPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
        	this.BtnGestionarPreguntas.Location = new System.Drawing.Point(458, 277);
        	this.BtnGestionarPreguntas.Name = "BtnGestionarPreguntas";
        	this.BtnGestionarPreguntas.Size = new System.Drawing.Size(176, 95);
        	this.BtnGestionarPreguntas.TabIndex = 7;
        	this.BtnGestionarPreguntas.Text = "Gestionar Preguntas";
        	this.BtnGestionarPreguntas.UseVisualStyleBackColor = false;
        	this.BtnGestionarPreguntas.Click += new System.EventHandler(this.BtnGestionarPreguntasClick);
        	// 
        	// btnGestionarModulos
        	// 
        	this.btnGestionarModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
        	this.btnGestionarModulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	this.btnGestionarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnGestionarModulos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnGestionarModulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
        	this.btnGestionarModulos.Location = new System.Drawing.Point(173, 138);
        	this.btnGestionarModulos.Name = "btnGestionarModulos";
        	this.btnGestionarModulos.Size = new System.Drawing.Size(176, 95);
        	this.btnGestionarModulos.TabIndex = 8;
        	this.btnGestionarModulos.Text = "Gestionar Modulos";
        	this.btnGestionarModulos.UseVisualStyleBackColor = false;
        	this.btnGestionarModulos.Click += new System.EventHandler(this.BtnGestionarModulosClick);
        	// 
        	// Añadir_preguntas
        	// 
        	this.Añadir_preguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
        	this.Añadir_preguntas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	this.Añadir_preguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.Añadir_preguntas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Añadir_preguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
        	this.Añadir_preguntas.Location = new System.Drawing.Point(458, 138);
        	this.Añadir_preguntas.Name = "Añadir_preguntas";
        	this.Añadir_preguntas.Size = new System.Drawing.Size(176, 95);
        	this.Añadir_preguntas.TabIndex = 9;
        	this.Añadir_preguntas.Text = "Añadir Preguntas";
        	this.Añadir_preguntas.UseVisualStyleBackColor = false;
        	this.Añadir_preguntas.Click += new System.EventHandler(this.Añadir_preguntasClick);
        	// 
        	// FormMenuAdmin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        	this.ClientSize = new System.Drawing.Size(811, 429);
        	this.Controls.Add(this.Añadir_preguntas);
        	this.Controls.Add(this.btnGestionarModulos);
        	this.Controls.Add(this.BtnGestionarPreguntas);
        	this.Controls.Add(this.btnConsultar);
        	this.Controls.Add(this.label1);
        	this.DoubleBuffered = true;
        	this.Name = "FormMenuAdmin";
        	this.Text = "FormMenuAdmin";
        	this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnGestionarModulos;
        private System.Windows.Forms.Button BtnGestionarPreguntas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Añadir_preguntas;
    }
}
=======
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
			this.SuspendLayout();
			// 
			// lb_Titulo
			// 
			this.lb_Titulo.BackColor = System.Drawing.Color.Transparent;
			this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Titulo.ForeColor = System.Drawing.Color.White;
			this.lb_Titulo.Location = new System.Drawing.Point(-1, 9);
			this.lb_Titulo.Name = "lb_Titulo";
			this.lb_Titulo.Size = new System.Drawing.Size(393, 23);
			this.lb_Titulo.TabIndex = 0;
			this.lb_Titulo.Text = "Menu de Administrador";
			this.lb_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnConsultar.Location = new System.Drawing.Point(245, 47);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(86, 44);
			this.btnConsultar.TabIndex = 6;
			this.btnConsultar.Text = "Consultar usuarios";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// BtnGestionarPreguntas
			// 
			this.BtnGestionarPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnGestionarPreguntas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnGestionarPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGestionarPreguntas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGestionarPreguntas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.BtnGestionarPreguntas.Location = new System.Drawing.Point(51, 129);
			this.BtnGestionarPreguntas.Name = "BtnGestionarPreguntas";
			this.BtnGestionarPreguntas.Size = new System.Drawing.Size(86, 44);
			this.BtnGestionarPreguntas.TabIndex = 7;
			this.BtnGestionarPreguntas.Text = "Gestionar Preguntas";
			this.BtnGestionarPreguntas.UseVisualStyleBackColor = false;
			this.BtnGestionarPreguntas.Click += new System.EventHandler(this.BtnGestionarPreguntasClick);
			// 
			// btnGestionarModulos
			// 
			this.btnGestionarModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnGestionarModulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnGestionarModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGestionarModulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionarModulos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnGestionarModulos.Location = new System.Drawing.Point(51, 47);
			this.btnGestionarModulos.Name = "btnGestionarModulos";
			this.btnGestionarModulos.Size = new System.Drawing.Size(86, 46);
			this.btnGestionarModulos.TabIndex = 8;
			this.btnGestionarModulos.Text = "Gestionar Modulos";
			this.btnGestionarModulos.UseVisualStyleBackColor = false;
			this.btnGestionarModulos.Click += new System.EventHandler(this.BtnGestionarModulosClick);
			// 
			// btn_Cerrar_Sesion
			// 
			this.btn_Cerrar_Sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Cerrar_Sesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Cerrar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cerrar_Sesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cerrar_Sesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Cerrar_Sesion.Location = new System.Drawing.Point(245, 129);
			this.btn_Cerrar_Sesion.Name = "btn_Cerrar_Sesion";
			this.btn_Cerrar_Sesion.Size = new System.Drawing.Size(86, 44);
			this.btn_Cerrar_Sesion.TabIndex = 9;
			this.btn_Cerrar_Sesion.Text = "Cerrar sesion";
			this.btn_Cerrar_Sesion.UseVisualStyleBackColor = false;
			this.btn_Cerrar_Sesion.Click += new System.EventHandler(this.Btn_Cerrar_SesionClick);
			// 
			// FormMenuAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(393, 210);
			this.Controls.Add(this.btn_Cerrar_Sesion);
			this.Controls.Add(this.btnGestionarModulos);
			this.Controls.Add(this.BtnGestionarPreguntas);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.lb_Titulo);
			this.Name = "FormMenuAdmin";
			this.Text = "FormMenuAdmin";
			this.Activated += new System.EventHandler(this.FormMenuAdminActivated);
			this.Click += new System.EventHandler(this.Btn_Cerrar_SesionClick);
			this.ResumeLayout(false);
		}
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
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd

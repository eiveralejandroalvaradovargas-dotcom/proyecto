/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 1/4/2026
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.textUsuario = new System.Windows.Forms.TextBox();
			this.textContraseña = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.lblDesc_shift_btn = new System.Windows.Forms.Label();
			this.btn_Cambiar_Idioma = new System.Windows.Forms.Button();
			this.lblDesc_shift_btn_2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblTitulo.Location = new System.Drawing.Point(2, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(393, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Inicio de Sesion";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblUsuario.Location = new System.Drawing.Point(103, 47);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(76, 23);
			this.lblUsuario.TabIndex = 1;
			this.lblUsuario.Text = "Usuario :";
			// 
			// lblContraseña
			// 
			this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
			this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContraseña.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblContraseña.Location = new System.Drawing.Point(85, 88);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(100, 23);
			this.lblContraseña.TabIndex = 2;
			this.lblContraseña.Text = "Contraseña :";
			// 
			// btnAcceder
			// 
			this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAcceder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAcceder.Location = new System.Drawing.Point(199, 139);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(107, 37);
			this.btnAcceder.TabIndex = 3;
			this.btnAcceder.Text = "Acceder";
			this.btnAcceder.UseVisualStyleBackColor = false;
			this.btnAcceder.Click += new System.EventHandler(this.BtnAccederClick);
			// 
			// textUsuario
			// 
			this.textUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textUsuario.ForeColor = System.Drawing.Color.Gainsboro;
			this.textUsuario.Location = new System.Drawing.Point(199, 47);
			this.textUsuario.Name = "textUsuario";
			this.textUsuario.Size = new System.Drawing.Size(100, 22);
			this.textUsuario.TabIndex = 4;
			// 
			// textContraseña
			// 
			this.textContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.textContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textContraseña.ForeColor = System.Drawing.Color.Gainsboro;
			this.textContraseña.Location = new System.Drawing.Point(199, 89);
			this.textContraseña.Name = "textContraseña";
			this.textContraseña.Size = new System.Drawing.Size(100, 22);
			this.textContraseña.TabIndex = 5;
			this.textContraseña.UseSystemPasswordChar = true;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(72, 139);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(107, 37);
			this.btnRegistrar.TabIndex = 6;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// lblDesc_shift_btn
			// 
			this.lblDesc_shift_btn.BackColor = System.Drawing.Color.Transparent;
			this.lblDesc_shift_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesc_shift_btn.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblDesc_shift_btn.Location = new System.Drawing.Point(35, 196);
			this.lblDesc_shift_btn.Name = "lblDesc_shift_btn";
			this.lblDesc_shift_btn.Size = new System.Drawing.Size(335, 23);
			this.lblDesc_shift_btn.TabIndex = 7;
			this.lblDesc_shift_btn.Text = "Desea cambiar el idioma a ingles? presione aqui :D";
			// 
			// btn_Cambiar_Idioma
			// 
			this.btn_Cambiar_Idioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Cambiar_Idioma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Cambiar_Idioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cambiar_Idioma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cambiar_Idioma.Location = new System.Drawing.Point(143, 222);
			this.btn_Cambiar_Idioma.Name = "btn_Cambiar_Idioma";
			this.btn_Cambiar_Idioma.Size = new System.Drawing.Size(107, 37);
			this.btn_Cambiar_Idioma.TabIndex = 8;
			this.btn_Cambiar_Idioma.Text = "Cambiar idioma";
			this.btn_Cambiar_Idioma.UseVisualStyleBackColor = false;
			this.btn_Cambiar_Idioma.Click += new System.EventHandler(this.Btn_Cambiar_IdiomaClick);
			// 
			// lblDesc_shift_btn_2
			// 
			this.lblDesc_shift_btn_2.BackColor = System.Drawing.Color.Transparent;
			this.lblDesc_shift_btn_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesc_shift_btn_2.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblDesc_shift_btn_2.Location = new System.Drawing.Point(31, 266);
			this.lblDesc_shift_btn_2.Name = "lblDesc_shift_btn_2";
			this.lblDesc_shift_btn_2.Size = new System.Drawing.Size(335, 23);
			this.lblDesc_shift_btn_2.TabIndex = 9;
			this.lblDesc_shift_btn_2.Text = "Esta opcion no podra ser cambiada mas adelante";
			this.lblDesc_shift_btn_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(396, 302);
			this.Controls.Add(this.lblDesc_shift_btn_2);
			this.Controls.Add(this.btn_Cambiar_Idioma);
			this.Controls.Add(this.lblDesc_shift_btn);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.textContraseña);
			this.Controls.Add(this.textUsuario);
			this.Controls.Add(this.btnAcceder);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblTitulo);
			this.Name = "MainForm";
			this.Text = "Plataforma educativa(?";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblDesc_shift_btn_2;
		private System.Windows.Forms.Button btn_Cambiar_Idioma;
		private System.Windows.Forms.Label lblDesc_shift_btn;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox textContraseña;
		private System.Windows.Forms.TextBox textUsuario;
		private System.Windows.Forms.Button btnAcceder;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblTitulo;

	}
}

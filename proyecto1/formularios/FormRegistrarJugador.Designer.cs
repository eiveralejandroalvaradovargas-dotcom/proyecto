/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 1/4/2026
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormRegistrarJugador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarJugador));
			this.lbl_Title = new System.Windows.Forms.Label();
			this.lbl_Usuario = new System.Windows.Forms.Label();
			this.lbl_Contraseña = new System.Windows.Forms.Label();
			this.textUsuario = new System.Windows.Forms.TextBox();
			this.textContraseña = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
<<<<<<< HEAD
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(350, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registrar";
=======
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Title.Location = new System.Drawing.Point(0, 12);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(395, 23);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Registrar";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			// 
			// lbl_Usuario
			// 
<<<<<<< HEAD
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(209, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario :";
=======
			this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Usuario.Location = new System.Drawing.Point(104, 65);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(80, 23);
			this.lbl_Usuario.TabIndex = 1;
			this.lbl_Usuario.Text = "Usuario :";
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			// 
			// lbl_Contraseña
			// 
<<<<<<< HEAD
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(209, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña :";
=======
			this.lbl_Contraseña.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Contraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Contraseña.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Contraseña.Location = new System.Drawing.Point(104, 122);
			this.lbl_Contraseña.Name = "lbl_Contraseña";
			this.lbl_Contraseña.Size = new System.Drawing.Size(89, 23);
			this.lbl_Contraseña.TabIndex = 2;
			this.lbl_Contraseña.Text = "Contraseña :";
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			// 
			// textUsuario
			// 
			this.textUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
			this.textUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textUsuario.Location = new System.Drawing.Point(438, 141);
=======
			this.textUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textUsuario.Location = new System.Drawing.Point(202, 65);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.textUsuario.Name = "textUsuario";
			this.textUsuario.Size = new System.Drawing.Size(219, 33);
			this.textUsuario.TabIndex = 3;
			// 
			// textContraseña
			// 
			this.textContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.textContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
			this.textContraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.textContraseña.Location = new System.Drawing.Point(438, 230);
=======
			this.textContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.textContraseña.Location = new System.Drawing.Point(202, 122);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.textContraseña.Name = "textContraseña";
			this.textContraseña.Size = new System.Drawing.Size(219, 33);
			this.textContraseña.TabIndex = 4;
			this.textContraseña.UseSystemPasswordChar = true;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
			this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.btnRegistrar.Location = new System.Drawing.Point(326, 328);
=======
			this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRegistrar.Location = new System.Drawing.Point(140, 187);
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(147, 55);
			this.btnRegistrar.TabIndex = 5;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// FormRegistrarJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
<<<<<<< HEAD
			this.ClientSize = new System.Drawing.Size(811, 429);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.textContraseña);
			this.Controls.Add(this.textUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.White;
=======
			this.ClientSize = new System.Drawing.Size(396, 302);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.textContraseña);
			this.Controls.Add(this.textUsuario);
			this.Controls.Add(this.lbl_Contraseña);
			this.Controls.Add(this.lbl_Usuario);
			this.Controls.Add(this.lbl_Title);
			this.ForeColor = System.Drawing.Color.Coral;
>>>>>>> 4e151eb3ee3730911d69bdd4fb0681431e01c1bd
			this.Name = "FormRegistrarJugador";
			this.Text = "Registrar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox textContraseña;
		private System.Windows.Forms.TextBox textUsuario;
		private System.Windows.Forms.Label lbl_Contraseña;
		private System.Windows.Forms.Label lbl_Usuario;
		private System.Windows.Forms.Label lbl_Title;
	}
}

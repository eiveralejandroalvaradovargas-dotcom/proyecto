/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 10/4/2026
 * Time: 19:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormMenuJugador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuJugador));
			this.Bienvenida = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Puntuacion_Modulo = new System.Windows.Forms.Label();
			this.Modulos_Menu = new System.Windows.Forms.Button();
			this.Seleccion_Modulo_Pts = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Bienvenida
			// 
			this.Bienvenida.BackColor = System.Drawing.Color.Transparent;
			this.Bienvenida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Bienvenida.ForeColor = System.Drawing.Color.Gainsboro;
			this.Bienvenida.Location = new System.Drawing.Point(97, 23);
			this.Bienvenida.Name = "Bienvenida";
			this.Bienvenida.Size = new System.Drawing.Size(134, 24);
			this.Bienvenida.TabIndex = 0;
			this.Bienvenida.Text = "label1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 59);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Puntuacion_Modulo
			// 
			this.Puntuacion_Modulo.BackColor = System.Drawing.Color.Transparent;
			this.Puntuacion_Modulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Puntuacion_Modulo.ForeColor = System.Drawing.Color.Gainsboro;
			this.Puntuacion_Modulo.Location = new System.Drawing.Point(159, 100);
			this.Puntuacion_Modulo.Name = "Puntuacion_Modulo";
			this.Puntuacion_Modulo.Size = new System.Drawing.Size(100, 23);
			this.Puntuacion_Modulo.TabIndex = 2;
			this.Puntuacion_Modulo.Text = "label2";
			// 
			// Modulos_Menu
			// 
			this.Modulos_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Modulos_Menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Modulos_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modulos_Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modulos_Menu.Location = new System.Drawing.Point(68, 169);
			this.Modulos_Menu.Name = "Modulos_Menu";
			this.Modulos_Menu.Size = new System.Drawing.Size(146, 37);
			this.Modulos_Menu.TabIndex = 3;
			this.Modulos_Menu.Text = "Ver Modulos";
			this.Modulos_Menu.UseVisualStyleBackColor = false;
			this.Modulos_Menu.Click += new System.EventHandler(this.Modulos_MenuClick);
			// 
			// Seleccion_Modulo_Pts
			// 
			this.Seleccion_Modulo_Pts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.Seleccion_Modulo_Pts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Seleccion_Modulo_Pts.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Seleccion_Modulo_Pts.ForeColor = System.Drawing.Color.Gainsboro;
			this.Seleccion_Modulo_Pts.FormattingEnabled = true;
			this.Seleccion_Modulo_Pts.Location = new System.Drawing.Point(12, 102);
			this.Seleccion_Modulo_Pts.Name = "Seleccion_Modulo_Pts";
			this.Seleccion_Modulo_Pts.Size = new System.Drawing.Size(121, 21);
			this.Seleccion_Modulo_Pts.TabIndex = 4;
			this.Seleccion_Modulo_Pts.SelectedIndexChanged += new System.EventHandler(this.Seleccion_Modulo_PtsSelectedIndexChanged);
			// 
			// FormMenuJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.Seleccion_Modulo_Pts);
			this.Controls.Add(this.Modulos_Menu);
			this.Controls.Add(this.Puntuacion_Modulo);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Bienvenida);
			this.Name = "FormMenuJugador";
			this.Text = "FormMenuJugador";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox Seleccion_Modulo_Pts;
		private System.Windows.Forms.Button Modulos_Menu;
		private System.Windows.Forms.Label Puntuacion_Modulo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label Bienvenida;
	}
}

/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 1/4/2026
 * Time: 18:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormJuego
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJuego));
			this.cmbModulo = new System.Windows.Forms.ComboBox();
			this.cmbIdioma = new System.Windows.Forms.ComboBox();
			this.lblPregunta = new System.Windows.Forms.Label();
			this.picImagen = new System.Windows.Forms.PictureBox();
			this.rbOpcion1 = new System.Windows.Forms.RadioButton();
			this.rbOpcion2 = new System.Windows.Forms.RadioButton();
			this.rbOpcion3 = new System.Windows.Forms.RadioButton();
			this.rbOpcion4 = new System.Windows.Forms.RadioButton();
			this.btnResponder = new System.Windows.Forms.Button();
			this.lblPuntuacion = new System.Windows.Forms.Label();
			this.Volver = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbModulo
			// 
			this.cmbModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.cmbModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbModulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbModulo.ForeColor = System.Drawing.Color.Gainsboro;
			this.cmbModulo.FormattingEnabled = true;
			this.cmbModulo.Location = new System.Drawing.Point(30, 30);
			this.cmbModulo.Name = "cmbModulo";
			this.cmbModulo.Size = new System.Drawing.Size(180, 21);
			this.cmbModulo.TabIndex = 0;
			this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.CmbModuloSelectedIndexChanged);
			// 
			// cmbIdioma
			// 
			this.cmbIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.cmbIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbIdioma.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbIdioma.ForeColor = System.Drawing.Color.Gainsboro;
			this.cmbIdioma.Location = new System.Drawing.Point(230, 30);
			this.cmbIdioma.Name = "cmbIdioma";
			this.cmbIdioma.Size = new System.Drawing.Size(120, 21);
			this.cmbIdioma.TabIndex = 1;
			this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.CmbIdiomaSelectedIndexChanged);
			// 
			// lblPregunta
			// 
			this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
			this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.lblPregunta.Location = new System.Drawing.Point(30, 70);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(500, 60);
			this.lblPregunta.TabIndex = 2;
			// 
			// picImagen
			// 
			this.picImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.picImagen.Location = new System.Drawing.Point(30, 104);
			this.picImagen.Name = "picImagen";
			this.picImagen.Size = new System.Drawing.Size(150, 150);
			this.picImagen.TabIndex = 3;
			this.picImagen.TabStop = false;
			// 
			// rbOpcion1
			// 
			this.rbOpcion1.BackColor = System.Drawing.Color.Transparent;
			this.rbOpcion1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOpcion1.ForeColor = System.Drawing.Color.Gainsboro;
			this.rbOpcion1.Location = new System.Drawing.Point(200, 140);
			this.rbOpcion1.Name = "rbOpcion1";
			this.rbOpcion1.Size = new System.Drawing.Size(300, 24);
			this.rbOpcion1.TabIndex = 4;
			this.rbOpcion1.TabStop = true;
			this.rbOpcion1.UseVisualStyleBackColor = false;
			this.rbOpcion1.CheckedChanged += new System.EventHandler(this.RbOpcion1CheckedChanged);
			// 
			// rbOpcion2
			// 
			this.rbOpcion2.BackColor = System.Drawing.Color.Transparent;
			this.rbOpcion2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOpcion2.ForeColor = System.Drawing.Color.Gainsboro;
			this.rbOpcion2.Location = new System.Drawing.Point(200, 170);
			this.rbOpcion2.Name = "rbOpcion2";
			this.rbOpcion2.Size = new System.Drawing.Size(300, 24);
			this.rbOpcion2.TabIndex = 5;
			this.rbOpcion2.TabStop = true;
			this.rbOpcion2.UseVisualStyleBackColor = false;
			// 
			// rbOpcion3
			// 
			this.rbOpcion3.BackColor = System.Drawing.Color.Transparent;
			this.rbOpcion3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOpcion3.ForeColor = System.Drawing.Color.Gainsboro;
			this.rbOpcion3.Location = new System.Drawing.Point(200, 200);
			this.rbOpcion3.Name = "rbOpcion3";
			this.rbOpcion3.Size = new System.Drawing.Size(300, 24);
			this.rbOpcion3.TabIndex = 6;
			this.rbOpcion3.TabStop = true;
			this.rbOpcion3.UseVisualStyleBackColor = false;
			// 
			// rbOpcion4
			// 
			this.rbOpcion4.BackColor = System.Drawing.Color.Transparent;
			this.rbOpcion4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOpcion4.ForeColor = System.Drawing.Color.Gainsboro;
			this.rbOpcion4.Location = new System.Drawing.Point(200, 230);
			this.rbOpcion4.Name = "rbOpcion4";
			this.rbOpcion4.Size = new System.Drawing.Size(300, 24);
			this.rbOpcion4.TabIndex = 7;
			this.rbOpcion4.TabStop = true;
			this.rbOpcion4.UseVisualStyleBackColor = false;
			// 
			// btnResponder
			// 
			this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnResponder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResponder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResponder.Location = new System.Drawing.Point(200, 270);
			this.btnResponder.Name = "btnResponder";
			this.btnResponder.Size = new System.Drawing.Size(100, 30);
			this.btnResponder.TabIndex = 8;
			this.btnResponder.Text = "Responder";
			this.btnResponder.UseVisualStyleBackColor = false;
			this.btnResponder.Click += new System.EventHandler(this.BtnResponderClick);
			// 
			// lblPuntuacion
			// 
			this.lblPuntuacion.BackColor = System.Drawing.Color.Transparent;
			this.lblPuntuacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPuntuacion.ForeColor = System.Drawing.Color.Cyan;
			this.lblPuntuacion.Location = new System.Drawing.Point(320, 270);
			this.lblPuntuacion.Name = "lblPuntuacion";
			this.lblPuntuacion.Size = new System.Drawing.Size(150, 30);
			this.lblPuntuacion.TabIndex = 9;
			this.lblPuntuacion.Text = "Puntuacion 0";
			// 
			// Volver
			// 
			this.Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Volver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Volver.Location = new System.Drawing.Point(30, 272);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(100, 28);
			this.Volver.TabIndex = 10;
			this.Volver.Text = "Volver";
			this.Volver.UseVisualStyleBackColor = false;
			this.Volver.Click += new System.EventHandler(this.VolverClick);
			// 
			// FormJuego
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(550, 330);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.lblPuntuacion);
			this.Controls.Add(this.btnResponder);
			this.Controls.Add(this.rbOpcion4);
			this.Controls.Add(this.rbOpcion3);
			this.Controls.Add(this.rbOpcion2);
			this.Controls.Add(this.rbOpcion1);
			this.Controls.Add(this.picImagen);
			this.Controls.Add(this.lblPregunta);
			this.Controls.Add(this.cmbIdioma);
			this.Controls.Add(this.cmbModulo);
			this.Name = "FormJuego";
			this.Text = "FormJuego";
			((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Volver;
		private System.Windows.Forms.Label lblPuntuacion;
		private System.Windows.Forms.Button btnResponder;
		private System.Windows.Forms.RadioButton rbOpcion4;
		private System.Windows.Forms.RadioButton rbOpcion3;
		private System.Windows.Forms.RadioButton rbOpcion2;
		private System.Windows.Forms.RadioButton rbOpcion1;
		private System.Windows.Forms.PictureBox picImagen;
		private System.Windows.Forms.Label lblPregunta;
		private System.Windows.Forms.ComboBox cmbIdioma;
		private System.Windows.Forms.ComboBox cmbModulo;
		
		void RbOpcion1CheckedChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}

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
			this.label1 = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.BtnGestionarPreguntas = new System.Windows.Forms.Button();
			this.btnGestionarModulos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(138, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu de Admin";
			// 
			// btnConsultar
			// 
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(51, 135);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(86, 38);
			this.btnConsultar.TabIndex = 6;
			this.btnConsultar.Text = "Consultar usuarios";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// BtnGestionarPreguntas
			// 
			this.BtnGestionarPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGestionarPreguntas.Location = new System.Drawing.Point(236, 135);
			this.BtnGestionarPreguntas.Name = "BtnGestionarPreguntas";
			this.BtnGestionarPreguntas.Size = new System.Drawing.Size(86, 38);
			this.BtnGestionarPreguntas.TabIndex = 7;
			this.BtnGestionarPreguntas.Text = "Gestionar Preguntas";
			this.BtnGestionarPreguntas.UseVisualStyleBackColor = true;
			this.BtnGestionarPreguntas.Click += new System.EventHandler(this.BtnGestionarPreguntasClick);
			// 
			// btnGestionarModulos
			// 
			this.btnGestionarModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGestionarModulos.Location = new System.Drawing.Point(51, 55);
			this.btnGestionarModulos.Name = "btnGestionarModulos";
			this.btnGestionarModulos.Size = new System.Drawing.Size(86, 38);
			this.btnGestionarModulos.TabIndex = 8;
			this.btnGestionarModulos.Text = "Gestionar Modulos";
			this.btnGestionarModulos.UseVisualStyleBackColor = true;
			this.btnGestionarModulos.Click += new System.EventHandler(this.BtnGestionarModulosClick);
			// 
			// FormMenuAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 210);
			this.Controls.Add(this.btnGestionarModulos);
			this.Controls.Add(this.BtnGestionarPreguntas);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.label1);
			this.Name = "FormMenuAdmin";
			this.Text = "FormMenuAdmin";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnGestionarModulos;
		private System.Windows.Forms.Button BtnGestionarPreguntas;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Label label1;
		

	}
}

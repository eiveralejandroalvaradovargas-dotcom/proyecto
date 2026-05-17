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
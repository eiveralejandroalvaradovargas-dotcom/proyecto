/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 10/4/2026
 * Time: 19:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormGestionPreguntas
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
			this.cmbPreguntas = new System.Windows.Forms.ComboBox();
			this.dataPreguntas = new System.Windows.Forms.DataGridView();
			this.Regisstrar = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Pregunta_ESP = new System.Windows.Forms.TextBox();
			this.Pregunta_ENG = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Volver = new System.Windows.Forms.Button();
			this.Ver_Todo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataPreguntas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(238, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modulo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbPreguntas
			// 
			this.cmbPreguntas.FormattingEnabled = true;
			this.cmbPreguntas.Location = new System.Drawing.Point(142, 50);
			this.cmbPreguntas.Name = "cmbPreguntas";
			this.cmbPreguntas.Size = new System.Drawing.Size(261, 21);
			this.cmbPreguntas.TabIndex = 1;
			this.cmbPreguntas.SelectedIndexChanged += new System.EventHandler(this.CmbPreguntasSelectedIndexChanged);
			// 
			// dataPreguntas
			// 
			this.dataPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPreguntas.Location = new System.Drawing.Point(51, 86);
			this.dataPreguntas.Name = "dataPreguntas";
			this.dataPreguntas.ReadOnly = true;
			this.dataPreguntas.Size = new System.Drawing.Size(453, 185);
			this.dataPreguntas.TabIndex = 2;
			this.dataPreguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPreguntasCellClick);
			// 
			// Regisstrar
			// 
			this.Regisstrar.Location = new System.Drawing.Point(12, 378);
			this.Regisstrar.Name = "Regisstrar";
			this.Regisstrar.Size = new System.Drawing.Size(89, 37);
			this.Regisstrar.TabIndex = 3;
			this.Regisstrar.Text = "Registrar";
			this.Regisstrar.UseVisualStyleBackColor = true;
			this.Regisstrar.Click += new System.EventHandler(this.Button1Click);
			// 
			// Modificar
			// 
			this.Modificar.Location = new System.Drawing.Point(249, 378);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(89, 37);
			this.Modificar.TabIndex = 4;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = true;
			this.Modificar.Click += new System.EventHandler(this.ModificarClick);
			// 
			// Eliminar
			// 
			this.Eliminar.Location = new System.Drawing.Point(357, 378);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(89, 37);
			this.Eliminar.TabIndex = 5;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = true;
			this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// Pregunta_ESP
			// 
			this.Pregunta_ESP.Location = new System.Drawing.Point(64, 316);
			this.Pregunta_ESP.Name = "Pregunta_ESP";
			this.Pregunta_ESP.Size = new System.Drawing.Size(124, 20);
			this.Pregunta_ESP.TabIndex = 6;
			// 
			// Pregunta_ENG
			// 
			this.Pregunta_ENG.Location = new System.Drawing.Point(380, 316);
			this.Pregunta_ENG.Name = "Pregunta_ENG";
			this.Pregunta_ENG.Size = new System.Drawing.Size(124, 20);
			this.Pregunta_ENG.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 290);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Pregunta en español";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(393, 290);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Pregunta en ingles";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Volver
			// 
			this.Volver.Location = new System.Drawing.Point(514, 12);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(75, 23);
			this.Volver.TabIndex = 10;
			this.Volver.Text = "Volver";
			this.Volver.UseVisualStyleBackColor = true;
			// 
			// Ver_Todo
			// 
			this.Ver_Todo.Location = new System.Drawing.Point(126, 378);
			this.Ver_Todo.Name = "Ver_Todo";
			this.Ver_Todo.Size = new System.Drawing.Size(89, 37);
			this.Ver_Todo.TabIndex = 11;
			this.Ver_Todo.Text = "Ver todo";
			this.Ver_Todo.UseVisualStyleBackColor = true;
			this.Ver_Todo.Click += new System.EventHandler(this.Ver_TodoClick);
			// 
			// FormGestionPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 427);
			this.Controls.Add(this.Ver_Todo);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Pregunta_ENG);
			this.Controls.Add(this.Pregunta_ESP);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.Regisstrar);
			this.Controls.Add(this.dataPreguntas);
			this.Controls.Add(this.cmbPreguntas);
			this.Controls.Add(this.label1);
			this.Name = "FormGestionPreguntas";
			this.Text = "Gestion de Preguntas";
			((System.ComponentModel.ISupportInitialize)(this.dataPreguntas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Ver_Todo;
		private System.Windows.Forms.Button Volver;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Pregunta_ENG;
		private System.Windows.Forms.TextBox Pregunta_ESP;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.Button Modificar;
		private System.Windows.Forms.Button Regisstrar;
		private System.Windows.Forms.DataGridView dataPreguntas;
		private System.Windows.Forms.ComboBox cmbPreguntas;
		private System.Windows.Forms.Label label1;
	}
}

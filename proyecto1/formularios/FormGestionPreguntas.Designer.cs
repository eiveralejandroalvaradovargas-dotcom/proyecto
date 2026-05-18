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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPreguntas));
			this.lbl_Title = new System.Windows.Forms.Label();
			this.cmbPreguntas = new System.Windows.Forms.ComboBox();
			this.dataPreguntas = new System.Windows.Forms.DataGridView();
			this.Regisstrar = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Pregunta_ESP = new System.Windows.Forms.TextBox();
			this.Pregunta_ENG = new System.Windows.Forms.TextBox();
			this.lbl_Preg_Español = new System.Windows.Forms.Label();
			this.lbl_Preg_Ingles = new System.Windows.Forms.Label();
			this.Volver = new System.Windows.Forms.Button();
			this.Ver_Todo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataPreguntas)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Title.Location = new System.Drawing.Point(238, 24);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(100, 23);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Modulo";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbPreguntas
			// 
			this.cmbPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.cmbPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbPreguntas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPreguntas.ForeColor = System.Drawing.Color.Gainsboro;
			this.cmbPreguntas.FormattingEnabled = true;
			this.cmbPreguntas.Location = new System.Drawing.Point(142, 50);
			this.cmbPreguntas.Name = "cmbPreguntas";
			this.cmbPreguntas.Size = new System.Drawing.Size(261, 21);
			this.cmbPreguntas.TabIndex = 1;
			this.cmbPreguntas.SelectedIndexChanged += new System.EventHandler(this.CmbPreguntasSelectedIndexChanged);
			// 
			// dataPreguntas
			// 
			this.dataPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
			this.dataPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPreguntas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.dataPreguntas.Location = new System.Drawing.Point(51, 86);
			this.dataPreguntas.Name = "dataPreguntas";
			this.dataPreguntas.ReadOnly = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			this.dataPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataPreguntas.Size = new System.Drawing.Size(453, 185);
			this.dataPreguntas.TabIndex = 2;
			this.dataPreguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPreguntasCellClick);
			// 
			// Regisstrar
			// 
			this.Regisstrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Regisstrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Regisstrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Regisstrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Regisstrar.Location = new System.Drawing.Point(32, 378);
			this.Regisstrar.Name = "Regisstrar";
			this.Regisstrar.Size = new System.Drawing.Size(89, 37);
			this.Regisstrar.TabIndex = 3;
			this.Regisstrar.Text = "Registrar";
			this.Regisstrar.UseVisualStyleBackColor = false;
			// 
			// Modificar
			// 
			this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modificar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modificar.Location = new System.Drawing.Point(331, 378);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(89, 37);
			this.Modificar.TabIndex = 4;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = false;
			this.Modificar.Click += new System.EventHandler(this.ModificarClick);
			// 
			// Eliminar
			// 
			this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Eliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Eliminar.Location = new System.Drawing.Point(457, 378);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(89, 37);
			this.Eliminar.TabIndex = 5;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = false;
			this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// Pregunta_ESP
			// 
			this.Pregunta_ESP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.Pregunta_ESP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pregunta_ESP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pregunta_ESP.ForeColor = System.Drawing.Color.Gainsboro;
			this.Pregunta_ESP.Location = new System.Drawing.Point(64, 316);
			this.Pregunta_ESP.Multiline = true;
			this.Pregunta_ESP.Name = "Pregunta_ESP";
			this.Pregunta_ESP.Size = new System.Drawing.Size(124, 20);
			this.Pregunta_ESP.TabIndex = 6;
			// 
			// Pregunta_ENG
			// 
			this.Pregunta_ENG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
			this.Pregunta_ENG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pregunta_ENG.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pregunta_ENG.ForeColor = System.Drawing.Color.Gainsboro;
			this.Pregunta_ENG.Location = new System.Drawing.Point(380, 316);
			this.Pregunta_ENG.Multiline = true;
			this.Pregunta_ENG.Name = "Pregunta_ENG";
			this.Pregunta_ENG.Size = new System.Drawing.Size(124, 20);
			this.Pregunta_ENG.TabIndex = 7;
			// 
			// lbl_Preg_Español
			// 
			this.lbl_Preg_Español.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Preg_Español.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Preg_Español.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Preg_Español.Location = new System.Drawing.Point(51, 290);
			this.lbl_Preg_Español.Name = "lbl_Preg_Español";
			this.lbl_Preg_Español.Size = new System.Drawing.Size(145, 23);
			this.lbl_Preg_Español.TabIndex = 8;
			this.lbl_Preg_Español.Text = "Pregunta en español";
			this.lbl_Preg_Español.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Preg_Ingles
			// 
			this.lbl_Preg_Ingles.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Preg_Ingles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Preg_Ingles.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbl_Preg_Ingles.Location = new System.Drawing.Point(380, 290);
			this.lbl_Preg_Ingles.Name = "lbl_Preg_Ingles";
			this.lbl_Preg_Ingles.Size = new System.Drawing.Size(128, 23);
			this.lbl_Preg_Ingles.TabIndex = 9;
			this.lbl_Preg_Ingles.Text = "Pregunta en ingles";
			this.lbl_Preg_Ingles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Volver
			// 
			this.Volver.BackColor = System.Drawing.Color.CadetBlue;
			this.Volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Volver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Volver.Location = new System.Drawing.Point(514, 12);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(75, 23);
			this.Volver.TabIndex = 10;
			this.Volver.Text = "Volver";
			this.Volver.UseVisualStyleBackColor = true;
			this.Volver.Click += new System.EventHandler(this.VolverClick);
			// 
			// Ver_Todo
			// 
			this.Ver_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Ver_Todo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Ver_Todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Ver_Todo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ver_Todo.Location = new System.Drawing.Point(185, 378);
			this.Ver_Todo.Name = "Ver_Todo";
			this.Ver_Todo.Size = new System.Drawing.Size(89, 37);
			this.Ver_Todo.TabIndex = 11;
			this.Ver_Todo.Text = "Ver todo";
			this.Ver_Todo.UseVisualStyleBackColor = false;
			this.Ver_Todo.Click += new System.EventHandler(this.Ver_TodoClick);
			// 
			// FormGestionPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(600, 446);
			this.Controls.Add(this.Ver_Todo);
			this.Controls.Add(this.Volver);
			this.Controls.Add(this.lbl_Preg_Ingles);
			this.Controls.Add(this.lbl_Preg_Español);
			this.Controls.Add(this.Pregunta_ENG);
			this.Controls.Add(this.Pregunta_ESP);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.Regisstrar);
			this.Controls.Add(this.dataPreguntas);
			this.Controls.Add(this.cmbPreguntas);
			this.Controls.Add(this.lbl_Title);
			this.Name = "FormGestionPreguntas";
			this.Text = "Gestion de Preguntas";
			((System.ComponentModel.ISupportInitialize)(this.dataPreguntas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Ver_Todo;
		private System.Windows.Forms.Button Volver;
		private System.Windows.Forms.Label lbl_Preg_Ingles;
		private System.Windows.Forms.Label lbl_Preg_Español;
		private System.Windows.Forms.TextBox Pregunta_ENG;
		private System.Windows.Forms.TextBox Pregunta_ESP;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.Button Modificar;
		private System.Windows.Forms.Button Regisstrar;
		private System.Windows.Forms.DataGridView dataPreguntas;
		private System.Windows.Forms.ComboBox cmbPreguntas;
		private System.Windows.Forms.Label lbl_Title;
	}
}

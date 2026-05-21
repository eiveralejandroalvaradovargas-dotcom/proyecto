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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPreguntas));
			this.lbl_Title = new System.Windows.Forms.Label();
			this.cmbPreguntas = new System.Windows.Forms.ComboBox();
			this.Regisstrar = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Pregunta_ESP = new System.Windows.Forms.TextBox();
			this.Pregunta_ENG = new System.Windows.Forms.TextBox();
			this.lbl_Preg_Español = new System.Windows.Forms.Label();
			this.lbl_Preg_Ingles = new System.Windows.Forms.Label();
			this.Volver = new System.Windows.Forms.Button();
			this.Ver_Todo = new System.Windows.Forms.Button();
			this.dataPreguntas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataPreguntas)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Title.Location = new System.Drawing.Point(404, 16);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(137, 42);
			this.lbl_Title.TabIndex = 0;
			this.lbl_Title.Text = "Modulo";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbPreguntas
			// 
			this.cmbPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.cmbPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbPreguntas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.cmbPreguntas.FormattingEnabled = true;
			this.cmbPreguntas.Location = new System.Drawing.Point(329, 61);
			this.cmbPreguntas.Name = "cmbPreguntas";
			this.cmbPreguntas.Size = new System.Drawing.Size(291, 25);
			this.cmbPreguntas.TabIndex = 1;
			this.cmbPreguntas.SelectedIndexChanged += new System.EventHandler(this.CmbPreguntasSelectedIndexChanged);
			// 
			// Regisstrar
			// 
			this.Regisstrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.Regisstrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Regisstrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Regisstrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Regisstrar.Location = new System.Drawing.Point(69, 475);
			this.Regisstrar.Name = "Regisstrar";
			this.Regisstrar.Size = new System.Drawing.Size(108, 37);
			this.Regisstrar.TabIndex = 3;
			this.Regisstrar.Text = "Registrar";
			this.Regisstrar.UseVisualStyleBackColor = false;
			// 
			// Modificar
			// 
			this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Modificar.Location = new System.Drawing.Point(564, 475);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(108, 37);
			this.Modificar.TabIndex = 4;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = false;
			this.Modificar.Click += new System.EventHandler(this.ModificarClick);
			// 
			// Eliminar
			// 
			this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Eliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Eliminar.Location = new System.Drawing.Point(794, 475);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(108, 37);
			this.Eliminar.TabIndex = 5;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = false;
			this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// Pregunta_ESP
			// 
			this.Pregunta_ESP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.Pregunta_ESP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pregunta_ESP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pregunta_ESP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Pregunta_ESP.Location = new System.Drawing.Point(83, 397);
			this.Pregunta_ESP.Multiline = true;
			this.Pregunta_ESP.Name = "Pregunta_ESP";
			this.Pregunta_ESP.Size = new System.Drawing.Size(332, 55);
			this.Pregunta_ESP.TabIndex = 6;
			// 
			// Pregunta_ENG
			// 
			this.Pregunta_ENG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
			this.Pregunta_ENG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pregunta_ENG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pregunta_ENG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Pregunta_ENG.Location = new System.Drawing.Point(564, 397);
			this.Pregunta_ENG.Multiline = true;
			this.Pregunta_ENG.Name = "Pregunta_ENG";
			this.Pregunta_ENG.Size = new System.Drawing.Size(332, 55);
			this.Pregunta_ENG.TabIndex = 7;
			// 
			// lbl_Preg_Español
			// 
			this.lbl_Preg_Español.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Preg_Español.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Preg_Español.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Preg_Español.Location = new System.Drawing.Point(124, 355);
			this.lbl_Preg_Español.Name = "lbl_Preg_Español";
			this.lbl_Preg_Español.Size = new System.Drawing.Size(236, 39);
			this.lbl_Preg_Español.TabIndex = 8;
			this.lbl_Preg_Español.Text = "Pregunta en español";
			this.lbl_Preg_Español.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Preg_Ingles
			// 
			this.lbl_Preg_Ingles.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Preg_Ingles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Preg_Ingles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.lbl_Preg_Ingles.Location = new System.Drawing.Point(627, 355);
			this.lbl_Preg_Ingles.Name = "lbl_Preg_Ingles";
			this.lbl_Preg_Ingles.Size = new System.Drawing.Size(206, 39);
			this.lbl_Preg_Ingles.TabIndex = 9;
			this.lbl_Preg_Ingles.Text = "Pregunta en ingles";
			this.lbl_Preg_Ingles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Volver
			// 
			this.Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Volver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Volver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Volver.Location = new System.Drawing.Point(854, 26);
			this.Volver.Name = "Volver";
			this.Volver.Size = new System.Drawing.Size(100, 51);
			this.Volver.TabIndex = 10;
			this.Volver.Text = "Volver";
			this.Volver.UseVisualStyleBackColor = false;
			this.Volver.Click += new System.EventHandler(this.VolverClick);
			// 
			// Ver_Todo
			// 
			this.Ver_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			this.Ver_Todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Ver_Todo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ver_Todo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
			this.Ver_Todo.Location = new System.Drawing.Point(307, 475);
			this.Ver_Todo.Name = "Ver_Todo";
			this.Ver_Todo.Size = new System.Drawing.Size(108, 37);
			this.Ver_Todo.TabIndex = 11;
			this.Ver_Todo.Text = "Ver todo";
			this.Ver_Todo.UseVisualStyleBackColor = false;
			this.Ver_Todo.Click += new System.EventHandler(this.Ver_TodoClick);
			// 
			// dataPreguntas
			// 
			this.dataPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataPreguntas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataPreguntas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(223)))), ((int)(((byte)(215)))));
			this.dataPreguntas.Location = new System.Drawing.Point(124, 128);
			this.dataPreguntas.Name = "dataPreguntas";
			this.dataPreguntas.ReadOnly = true;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			this.dataPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataPreguntas.Size = new System.Drawing.Size(720, 224);
			this.dataPreguntas.TabIndex = 2;
			this.dataPreguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPreguntasCellClick);
			// 
			// FormGestionPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(984, 561);
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
			this.DoubleBuffered = true;
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

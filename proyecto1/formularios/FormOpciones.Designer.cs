/*
 * Created by SharpDevelop.
 * User: Nabil-2
 * Date: 13-05-2026
 * Time: 7:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto1
{
	partial class FormOpciones
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
			this.cmbPreguntas = new System.Windows.Forms.ComboBox();
			this.textNombreEs2 = new System.Windows.Forms.TextBox();
			this.textNombreEs4 = new System.Windows.Forms.TextBox();
			this.textNombreEs3 = new System.Windows.Forms.TextBox();
			this.textNombreEs1 = new System.Windows.Forms.TextBox();
			this.textNombreEn1 = new System.Windows.Forms.TextBox();
			this.textNombreEn3 = new System.Windows.Forms.TextBox();
			this.textNombreEn2 = new System.Windows.Forms.TextBox();
			this.textNombreEn4 = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.rob1 = new System.Windows.Forms.RadioButton();
			this.rob2 = new System.Windows.Forms.RadioButton();
			this.rob3 = new System.Windows.Forms.RadioButton();
			this.rob4 = new System.Windows.Forms.RadioButton();
			this.dataOpciones = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataOpciones)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbPreguntas
			// 
			this.cmbPreguntas.FormattingEnabled = true;
			this.cmbPreguntas.Location = new System.Drawing.Point(26, 38);
			this.cmbPreguntas.Name = "cmbPreguntas";
			this.cmbPreguntas.Size = new System.Drawing.Size(280, 21);
			this.cmbPreguntas.TabIndex = 0;
			// 
			// textNombreEs2
			// 
			this.textNombreEs2.Location = new System.Drawing.Point(26, 142);
			this.textNombreEs2.Name = "textNombreEs2";
			this.textNombreEs2.Size = new System.Drawing.Size(126, 20);
			this.textNombreEs2.TabIndex = 1;
			// 
			// textNombreEs4
			// 
			this.textNombreEs4.Location = new System.Drawing.Point(26, 243);
			this.textNombreEs4.Name = "textNombreEs4";
			this.textNombreEs4.Size = new System.Drawing.Size(126, 20);
			this.textNombreEs4.TabIndex = 2;
			// 
			// textNombreEs3
			// 
			this.textNombreEs3.Location = new System.Drawing.Point(26, 190);
			this.textNombreEs3.Name = "textNombreEs3";
			this.textNombreEs3.Size = new System.Drawing.Size(126, 20);
			this.textNombreEs3.TabIndex = 3;
			// 
			// textNombreEs1
			// 
			this.textNombreEs1.Location = new System.Drawing.Point(26, 96);
			this.textNombreEs1.Name = "textNombreEs1";
			this.textNombreEs1.Size = new System.Drawing.Size(126, 20);
			this.textNombreEs1.TabIndex = 4;
			// 
			// textNombreEn1
			// 
			this.textNombreEn1.Location = new System.Drawing.Point(180, 96);
			this.textNombreEn1.Name = "textNombreEn1";
			this.textNombreEn1.Size = new System.Drawing.Size(126, 20);
			this.textNombreEn1.TabIndex = 5;
			// 
			// textNombreEn3
			// 
			this.textNombreEn3.Location = new System.Drawing.Point(180, 190);
			this.textNombreEn3.Name = "textNombreEn3";
			this.textNombreEn3.Size = new System.Drawing.Size(126, 20);
			this.textNombreEn3.TabIndex = 6;
			// 
			// textNombreEn2
			// 
			this.textNombreEn2.Location = new System.Drawing.Point(180, 142);
			this.textNombreEn2.Name = "textNombreEn2";
			this.textNombreEn2.Size = new System.Drawing.Size(126, 20);
			this.textNombreEn2.TabIndex = 7;
			// 
			// textNombreEn4
			// 
			this.textNombreEn4.Location = new System.Drawing.Point(180, 243);
			this.textNombreEn4.Name = "textNombreEn4";
			this.textNombreEn4.Size = new System.Drawing.Size(126, 20);
			this.textNombreEn4.TabIndex = 8;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(26, 317);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(109, 37);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(268, 317);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(109, 37);
			this.btnModificar.TabIndex = 10;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(144, 317);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(109, 37);
			this.btnEliminar.TabIndex = 11;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// rob1
			// 
			this.rob1.Location = new System.Drawing.Point(338, 93);
			this.rob1.Name = "rob1";
			this.rob1.Size = new System.Drawing.Size(104, 24);
			this.rob1.TabIndex = 13;
			this.rob1.TabStop = true;
			this.rob1.Text = "1";
			this.rob1.UseVisualStyleBackColor = true;
			// 
			// rob2
			// 
			this.rob2.Location = new System.Drawing.Point(338, 139);
			this.rob2.Name = "rob2";
			this.rob2.Size = new System.Drawing.Size(104, 24);
			this.rob2.TabIndex = 14;
			this.rob2.TabStop = true;
			this.rob2.Text = "2";
			this.rob2.UseVisualStyleBackColor = true;
			// 
			// rob3
			// 
			this.rob3.Location = new System.Drawing.Point(338, 187);
			this.rob3.Name = "rob3";
			this.rob3.Size = new System.Drawing.Size(104, 24);
			this.rob3.TabIndex = 15;
			this.rob3.TabStop = true;
			this.rob3.Text = "3";
			this.rob3.UseVisualStyleBackColor = true;
			// 
			// rob4
			// 
			this.rob4.Location = new System.Drawing.Point(338, 240);
			this.rob4.Name = "rob4";
			this.rob4.Size = new System.Drawing.Size(104, 24);
			this.rob4.TabIndex = 16;
			this.rob4.TabStop = true;
			this.rob4.Text = "4";
			this.rob4.UseVisualStyleBackColor = true;
			// 
			// dataOpciones
			// 
			this.dataOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOpciones.Location = new System.Drawing.Point(404, 12);
			this.dataOpciones.Name = "dataOpciones";
			this.dataOpciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataOpciones.Size = new System.Drawing.Size(373, 342);
			this.dataOpciones.TabIndex = 21;
			// 
			// FormOpciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 366);
			this.Controls.Add(this.dataOpciones);
			this.Controls.Add(this.rob4);
			this.Controls.Add(this.rob3);
			this.Controls.Add(this.rob2);
			this.Controls.Add(this.rob1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.textNombreEn4);
			this.Controls.Add(this.textNombreEn2);
			this.Controls.Add(this.textNombreEn3);
			this.Controls.Add(this.textNombreEn1);
			this.Controls.Add(this.textNombreEs1);
			this.Controls.Add(this.textNombreEs3);
			this.Controls.Add(this.textNombreEs4);
			this.Controls.Add(this.textNombreEs2);
			this.Controls.Add(this.cmbPreguntas);
			this.Name = "FormOpciones";
			this.Text = "FormOpciones";
			((System.ComponentModel.ISupportInitialize)(this.dataOpciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataOpciones;
		private System.Windows.Forms.RadioButton rob4;
		private System.Windows.Forms.RadioButton rob3;
		private System.Windows.Forms.RadioButton rob2;
		private System.Windows.Forms.RadioButton rob1;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox textNombreEn4;
		private System.Windows.Forms.TextBox textNombreEn2;
		private System.Windows.Forms.TextBox textNombreEn3;
		private System.Windows.Forms.TextBox textNombreEn1;
		private System.Windows.Forms.TextBox textNombreEs1;
		private System.Windows.Forms.TextBox textNombreEs3;
		private System.Windows.Forms.TextBox textNombreEs4;
		private System.Windows.Forms.TextBox textNombreEs2;
		private System.Windows.Forms.ComboBox cmbPreguntas;
	}
}

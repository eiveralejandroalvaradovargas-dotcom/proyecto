using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace proyecto1
{

	public partial class FormRegistrarJugador : Form
	{
		public FormRegistrarJugador()
		{
			InitializeComponent();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			
			
			string user = textUsuario.Text;
			string pass = textContraseña.Text;
			string rol = "Jugador";
			
			if(user != "" && pass!= "")
			{
				int nuevoId = MainForm.ListaUsuario.Count + 1;
                MainForm.ListaUsuario.Add(new Usuarios(nuevoId, user, pass, rol));
                MessageBox.Show("Jugador registrado exitosamente");
                this.Close();
			}
			else
			{
				MessageBox.Show("Complete todos los campos");
			}
			
			
		}
	}
}

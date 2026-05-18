using System;
using System.Windows.Forms;
using proyecto1.Modelos;  // Para usar Idiomas

namespace proyecto1
{
    public partial class FormRegistrarAdmin : Form
    {
        public FormRegistrarAdmin()
        {
            InitializeComponent();
            foreach (Control c in this.Controls) c.Tag = c.Text;
            Verificar();
        }
        
        void BtnRegistrarClick(object sender, EventArgs e)
        {
            string user = textUsuario.Text.Trim();
            string pass = textContraseña.Text.Trim();
            
            string Mensaje = "";
            string Title = "";
            
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                Mensaje = Idiomas.English ? "Please, complete all the fields" : "Complete todos los campos";
                Title = Idiomas.English ? "Advice" : "Aviso";
                MessageBox.Show(Mensaje, Title);
                return;
            }
            
            var usuarios = BaseDatos.ObtenerUsuarios();
            if (usuarios.Exists(u => u.Username == user))
            {
                Mensaje = Idiomas.English ? "This information belongs to an existing account" : "Estos datos pertenecen a una cuenta existente";
                Title = Idiomas.English ? "Registration failed" : "Registro fallido";
                MessageBox.Show(Mensaje, Title, MessageBoxButtons.RetryCancel);
                return;
            }
            
            Usuarios nuevo = new Usuarios(0, user, pass, "Admin");
            BaseDatos.AgregarUsuario(nuevo);
            Mensaje = Idiomas.English ? "Administrator signed up successfully!" : "Administrador registrado exitosamente!";
            Title = Idiomas.English ? "Registration done" : "Registro terminado";
            MessageBox.Show(Mensaje, Title);
            this.Close();
        }
        
        void Verificar()
        {
            if (Idiomas.English)
            {
                lbl_Title.Text = "Sign up Administrator";
                lbl_Usuario.Text = "Username";
                lbl_Contraseña.Text = "Password";
                btnRegistrar.Text = "Done";
            }
            else
            {
                lbl_Title.Text = lbl_Title.Tag.ToString();
                lbl_Usuario.Text = lbl_Usuario.Tag.ToString();
                lbl_Contraseña.Text = lbl_Contraseña.Tag.ToString();
                btnRegistrar.Text = btnRegistrar.Tag.ToString();
            }
        }
    }
}
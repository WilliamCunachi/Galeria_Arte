using Galeria_Arte.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galeria_Arte.Views;

namespace Galeria_Arte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string Usuario = txt_Usuario.Text;
            string Contraseña = txt_Contraseña.Text;
            var usuario = UsuarioController.AutenticarUsuario(Usuario, Contraseña);
            if (usuario != null)
            {
                MessageBox.Show($"Biembenido {usuario.Usuario}.Rol: {usuario.Rol}");
                switch (usuario.Rol)
                {
                    case "Administrador":
                        frm_Administrador _frm_Administrador = new frm_Administrador();
                        _frm_Administrador.Show();
                        this.Hide();

                        break;
                  

                }

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
            }
        }
    }
}


using Galeria_Arte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria_Arte.Controllers
{
    internal class UsuarioController
    {
        public static UsuarioModel AutenticarUsuario(string usuario, string contraseña)
        {
            return UsuarioModel.ValidarUsuario(usuario, contraseña);
        }
    }
}
